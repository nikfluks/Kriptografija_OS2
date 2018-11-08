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
    public partial class FrmDigitalniPotpis : Form
    {
        string tajniKljucPutanja = Application.StartupPath + @"\datoteke\tajni_kljuc.txt";
        string javniKljucPutanja = Application.StartupPath + @"\datoteke\javni_kljuc.txt";
        string hashPutanja = Application.StartupPath + @"\datoteke\hash.txt";
        string digitalniPotpisPutanja = Application.StartupPath + @"\datoteke\digitalni_potpis.txt";
        string originalniTextPutanja = Application.StartupPath + @"\datoteke\originalni_tekst.txt";

        public FrmDigitalniPotpis()
        {
            InitializeComponent();
        }

        private void FrmDigitalniPotpis_Load(object sender, EventArgs e)
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
            btnIzracunajHash.Enabled = false;
            btnIzracunajDigitalniPotpis.Enabled = false;
            btnProvjeriDigitalniPotp.Enabled = false;
        }

        private void OcistiTextBoxeve()
        {
            txtOriginalniTekst.Text = "";
            txtJavniKljuc.Text = "";
            txtTajniKljuc.Text = "";
            txtHash.Text = "";
            txtKriptiraniDigitalniPotpis.Text = "";
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
            if (File.Exists(tajniKljucPutanja) && File.Exists(javniKljucPutanja))
            {
                string tajniKljuc = UcitajIzDatoteke(tajniKljucPutanja);
                string javniKljuc = UcitajIzDatoteke(javniKljucPutanja);

                txtTajniKljuc.Text = tajniKljuc;
                txtJavniKljuc.Text = javniKljuc;

                btnIzracunajHash.Enabled = true;
            }
        }

        private void btnKreirajAsimetricniKljuc_Click(object sender, EventArgs e)
        {
            KreirajAsimetricniKljuc();
            btnIzracunajHash.Enabled = true;
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

        private void btnIzracunajHash_Click(object sender, EventArgs e)
        {
            IzracunajHash();
            btnIzracunajDigitalniPotpis.Enabled = true;
        }

        private void IzracunajHash()
        {
            string originalniText = UcitajIzDatoteke(originalniTextPutanja);
            byte[] originalniTextBytes = Encoding.Default.GetBytes(originalniText);

            SHA256 sha = SHA256.Create();

            byte[] hashBytes = sha.ComputeHash(originalniTextBytes);

            string hashString = Convert.ToBase64String(hashBytes);
            ZapisiUDatoteku(hashPutanja, hashString);
            txtHash.Text = hashString;
        }

        private void btnIzracunajDigitalniPotpis_Click(object sender, EventArgs e)
        {
            string tajniKljuc = UcitajIzDatoteke(tajniKljucPutanja);

            if (tajniKljuc != "")
            {
                string hash = UcitajIzDatoteke(hashPutanja);

                if (hash != "")
                {
                    byte[] digitalniPotpisBytes = IzracunajDigitalniPotpis(tajniKljuc, hash);

                    if (digitalniPotpisBytes != null)
                    {
                        string digitalniPotpisString = Convert.ToBase64String(digitalniPotpisBytes);
                        ZapisiUDatoteku(digitalniPotpisPutanja, digitalniPotpisString);

                        MessageBox.Show("Digitalni potpis uspješno izrađen!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtKriptiraniDigitalniPotpis.Text = digitalniPotpisString;
                        btnProvjeriDigitalniPotp.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Pogrešan ključ za kriptiranje!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Niste kreirali hash!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Niste kreirali tajni ključ!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] IzracunajDigitalniPotpis(string tajniKljuc, string hash)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

            byte[] hashBytes = Convert.FromBase64String(hash);

            byte[] digitalniPotpis = null;

            try
            {
                rsa.FromXmlString(tajniKljuc);
                digitalniPotpis = rsa.SignHash(hashBytes, HashAlgorithmName.SHA256.Name);
            }
            catch (CryptographicException)
            {
                digitalniPotpis = null;
            }
            catch (FormatException)
            {
                digitalniPotpis = null;
            }
            rsa.Clear();
            return digitalniPotpis;
        }

        private void btnProvjeriDigitalniPotp_Click(object sender, EventArgs e)
        {
            string digitalniPotpis = UcitajIzDatoteke(digitalniPotpisPutanja);

            if (digitalniPotpis != "")
            {
                string javniKljuc = UcitajIzDatoteke(javniKljucPutanja);

                if (javniKljuc != "")
                {
                    string originalniTekst = UcitajIzDatoteke(originalniTextPutanja);

                    if (originalniTekst != "")
                    {
                        bool ispravanDigitalniPotpis = ProvjeriDigitalniPotpis(digitalniPotpis, javniKljuc, originalniTekst);

                        if (ispravanDigitalniPotpis)
                        {
                            MessageBox.Show("Digitalni potpis je ispravan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Digitalni potpis NIJE ispravan!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Originalni tekst nije unešen!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Niste kreirali javni ključ!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Niste kreirali digitalni potpis!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ProvjeriDigitalniPotpis(string digitalniPotpis, string javniKljuc, string originalniTekst)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

            bool ispravanDigPotpis = false;

            try
            {
                byte[] originalniTekstBytes = Encoding.Default.GetBytes(originalniTekst);
                byte[] digPotpisBytes = Convert.FromBase64String(digitalniPotpis);

                rsa.FromXmlString(javniKljuc);
                ispravanDigPotpis = rsa.VerifyData(originalniTekstBytes, HashAlgorithmName.SHA256.Name, digPotpisBytes);
            }
            catch (CryptographicException)
            {
                ispravanDigPotpis = false;
            }
            catch (FormatException)
            {
                ispravanDigPotpis = false;
            }
            rsa.Clear();
            return ispravanDigPotpis;
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
