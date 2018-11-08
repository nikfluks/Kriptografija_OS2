using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os2_projekt
{
    public partial class FrmAsimetricnaKriptografija : Form
    {
        string tajniKljucPutanja = Application.StartupPath + @"\datoteke\tajni_kljuc.txt";
        string javniKljucPutanja = Application.StartupPath + @"\datoteke\javni_kljuc.txt";
        string kriptiraniTekstPutanja = Application.StartupPath + @"\datoteke\kriptirani_tekst.txt";
        string dekriptiraniTekstPutanja = Application.StartupPath + @"\datoteke\dekriptirani_tekst.txt";
        string originalniTextPutanja = Application.StartupPath + @"\datoteke\originalni_tekst.txt";

        public FrmAsimetricnaKriptografija()
        {
            InitializeComponent();
        }

        private void FrmAsimetricnaKriptografija_Load(object sender, EventArgs e)
        {
            OnemoguciGumbove();
            OcistiTextBoxeve();

            if (File.Exists(originalniTextPutanja))
            {
                UpisiOriginalniTekst();
            }
        }

        private void OnemoguciGumbove()
        {
            btnKreirajAsimetricniKljuc.Enabled = false;
            btnKriptirajAsimetricnimKljucem.Enabled = false;
            btnDekriptirajAsimetricnimKljucem.Enabled = false;
            btnUsporediOriginalniIDekriptiraniTekst.Enabled = false;
        }

        private void OcistiTextBoxeve()
        {
            txtOriginalniTekst.Text = "";
            txtJavniKljuc.Text = "";
            txtTajniKljuc.Text = "";
            txtKriptiraniTekst.Text = "";
            txtDekriptiraniTekst.Text = "";
        }

        private void btnOtvoriDatoteku_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Otvori datoteku";
            ofd.InitialDirectory = Application.StartupPath + @"\datoteke\";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalniTextPutanja = Path.GetFullPath(ofd.FileName);
            }
            else
            {
                MessageBox.Show("Niste odabrali ni jednu datoteku!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpisiOriginalniTekst();
        }

        private void UpisiOriginalniTekst()
        {
            string originalniTekst = UcitajIzDatoteke(originalniTextPutanja);

            if (originalniTekst != "")
            {
                txtOriginalniTekst.Text = originalniTekst;
                btnKreirajAsimetricniKljuc.Enabled = true;
                UpisiKljuceve();
            }
            else
            {
                MessageBox.Show("Prazna datoteka se ne može kriptirati!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnemoguciGumbove();
                OcistiTextBoxeve();
            }
        }

        private void UpisiKljuceve()
        {
            if (File.Exists(javniKljucPutanja) && File.Exists(tajniKljucPutanja))
            {
                string javniKljuc = UcitajIzDatoteke(javniKljucPutanja);
                string tajniKljuc = UcitajIzDatoteke(tajniKljucPutanja);

                txtJavniKljuc.Text = javniKljuc;
                txtTajniKljuc.Text = tajniKljuc;

                btnKriptirajAsimetricnimKljucem.Enabled = true;
            }
        }

        private void btnKreirajAsimetricniKljuc_Click(object sender, EventArgs e)
        {
            KreirajAsimetricniKljuc();
            btnKriptirajAsimetricnimKljucem.Enabled = true;
        }

        private void KreirajAsimetricniKljuc()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

            string tajniKljuc = rsa.ToXmlString(true);
            ZapisiUDatoteku(tajniKljucPutanja, tajniKljuc);

            string javniKljuc = rsa.ToXmlString(false);
            ZapisiUDatoteku(javniKljucPutanja, javniKljuc);

            txtJavniKljuc.Text = javniKljuc;
            txtTajniKljuc.Text = tajniKljuc;

            rsa.Clear();
        }

        private void btnKriptirajAsimetricnimKljucem_Click(object sender, EventArgs e)
        {
            string originalniTekst = UcitajIzDatoteke(originalniTextPutanja);

            if (originalniTekst != "")//dobra putanja
            {
                string javniKljuc = UcitajIzDatoteke(javniKljucPutanja);

                if (javniKljuc != "")//dobra putanja
                {
                    byte[] kriptiraniTekstBytes = KriptirajTekst(originalniTekst, javniKljuc);

                    if (kriptiraniTekstBytes != null)
                    {
                        string kriptiraniTekstString = Convert.ToBase64String(kriptiraniTekstBytes);
                        ZapisiUDatoteku(kriptiraniTekstPutanja, kriptiraniTekstString);

                        MessageBox.Show("Kriptiranje uspješno!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtKriptiraniTekst.Text = kriptiraniTekstString;
                        btnDekriptirajAsimetricnimKljucem.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Pogrešan ključ za kriptiranje!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Niste kreirali javni ključ!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private byte[] KriptirajTekst(string originalniTekst, string javniKljuc)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

            byte[] orginalniTekstBytes = Encoding.Default.GetBytes(originalniTekst);

            byte[] kriptiraniTextBytes = null;

            try
            {
                rsa.FromXmlString(javniKljuc);
                kriptiraniTextBytes = rsa.Encrypt(orginalniTekstBytes, true);
            }
            catch (CryptographicException)
            {
                kriptiraniTextBytes = null;
            }
            catch (FormatException)
            {
                kriptiraniTextBytes = null;
            }
            rsa.Clear();
            return kriptiraniTextBytes;
        }

        private void btnDekriptirajAsimetricnimKljucem_Click(object sender, EventArgs e)
        {
            string kriptiraniTekst = UcitajIzDatoteke(kriptiraniTekstPutanja);

            if (kriptiraniTekst != "")
            {
                string tajniKljuc = UcitajIzDatoteke(tajniKljucPutanja);

                if (tajniKljuc != "")
                {
                    byte[] dekriptiraniTekstBytes = DekriptirajTekst(kriptiraniTekst, tajniKljuc);

                    if (dekriptiraniTekstBytes != null)
                    {
                        string dekriptiraniTekstString = Encoding.Default.GetString(dekriptiraniTekstBytes);
                        ZapisiUDatoteku(dekriptiraniTekstPutanja, dekriptiraniTekstString);

                        MessageBox.Show("Dekriptiranje uspješno!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDekriptiraniTekst.Text = dekriptiraniTekstString;
                        btnUsporediOriginalniIDekriptiraniTekst.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Pogrešan ključ za dekriptiranje!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Niste kreirali tajni ključ!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Niste kriptirali originalni tekst!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] DekriptirajTekst(string kriptiraniTekst, string tajniKljuc)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

            byte[] dekriptiraniTekstBytes = null;

            try
            {
                byte[] kriptiraniTekstBytes = Convert.FromBase64String(kriptiraniTekst);

                rsa.FromXmlString(tajniKljuc);
                dekriptiraniTekstBytes = rsa.Decrypt(kriptiraniTekstBytes, true);
            }
            catch (CryptographicException)
            {
                dekriptiraniTekstBytes = null;
            }
            catch (FormatException)
            {
                dekriptiraniTekstBytes = null;
            }
            rsa.Clear();
            return dekriptiraniTekstBytes;
        }

        private void btnUsporediOriginalniIDekriptiraniTekst_Click(object sender, EventArgs e)
        {
            string originalniTekst = UcitajIzDatoteke(originalniTextPutanja);
            string dekriptiraniTekst = UcitajIzDatoteke(dekriptiraniTekstPutanja);

            if (string.Equals(originalniTekst,dekriptiraniTekst))
            {
                MessageBox.Show("Originalni tekst i dekriptirani su jednaki!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Orginalni tekst i dekriptirani su različiti!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZapisiUDatoteku(string putanjaDoDatoteke, string tekst)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(putanjaDoDatoteke, false, Encoding.Default);
                sw.Write(tekst.Trim());
                sw.Flush();
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        private string UcitajIzDatoteke(string putanjaDoDatoteke)
        {
            string tekst = "";

            try
            {
                tekst = File.ReadAllText(putanjaDoDatoteke, Encoding.Default);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Datoteka ne postoji!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Niste unijeli orginalni tekst!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tekst.Trim();
        }
    }
}
