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
    public partial class FrmSimetricnaKriptografija : Form
    {
        string privatniKljucPutanja = Application.StartupPath + @"\datoteke\privatni_kljuc.txt";
        string kriptiraniTekstPutanja = Application.StartupPath + @"\datoteke\kriptirani_tekst.txt";
        string dekriptiraniTekstPutanja = Application.StartupPath + @"\datoteke\dekriptirani_tekst.txt";
        string inicijalizacijskiVektorPutanja = Application.StartupPath + @"\datoteke\inicijalizacijski_vektor.txt";
        string originalniTextPutanja = Application.StartupPath + @"\datoteke\originalni_tekst.txt";

        public FrmSimetricnaKriptografija()
        {
            InitializeComponent();
        }

        private void FrmSimetricnaKriptografija_Load(object sender, EventArgs e)
        {
            OnemoguciGumbove();
            OcistiTextBoxeve();

            if (File.Exists(originalniTextPutanja))
            {
                UpisiOriginalniTekst();
            }
        }

        private void OcistiTextBoxeve()
        {
            txtOriginalniTekst.Text = "";
            txtPrivatniKljuc.Text = "";
            txtKriptiraniTekst.Text = "";
            txtDekriptiraniTekst.Text = "";
        }

        private void OnemoguciGumbove()
        {
            btnKreirajSimetricniKljuc.Enabled = false;
            btnKriptirajSimetricnimKljucem.Enabled = false;
            btnDekriptirajSimetricnimKljucem.Enabled = false;
            btnUsporediOriginalniIDekriptiraniTekst.Enabled = false;
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
                btnKreirajSimetricniKljuc.Enabled = true;
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
            if (File.Exists(privatniKljucPutanja) && File.Exists(inicijalizacijskiVektorPutanja))
            {
                string privatniKljuc = UcitajIzDatoteke(privatniKljucPutanja);
                string inicijalizacijskiVektor = UcitajIzDatoteke(inicijalizacijskiVektorPutanja);

                txtPrivatniKljuc.Text = "Ključ:  " + Environment.NewLine + privatniKljuc;
                txtPrivatniKljuc.Text += Environment.NewLine + Environment.NewLine + "IV:  " + Environment.NewLine + inicijalizacijskiVektor;

                btnKriptirajSimetricnimKljucem.Enabled = true;
            }
        }

        private void btnKreirajSimetricniKljuc_Click(object sender, EventArgs e)
        {
            KreirajSimetricniKljuc();
            btnKriptirajSimetricnimKljucem.Enabled = true;
        }

        private void KreirajSimetricniKljuc()
        {
            AesManaged aes = new AesManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;

            byte[] privatniKljucBytes = aes.Key;
            string privatniKljucString = Convert.ToBase64String(privatniKljucBytes);

            ZapisiUDatoteku(privatniKljucPutanja, privatniKljucString);
            txtPrivatniKljuc.Text = "Ključ:  " + Environment.NewLine + privatniKljucString;

            byte[] inicijalizacijskiVektorBytes = aes.IV;
            string inicijalizacijskiVektorString = Convert.ToBase64String(inicijalizacijskiVektorBytes);

            ZapisiUDatoteku(inicijalizacijskiVektorPutanja, inicijalizacijskiVektorString);
            txtPrivatniKljuc.Text += Environment.NewLine + Environment.NewLine + "IV:  " + Environment.NewLine + inicijalizacijskiVektorString;

            aes.Clear();
        }

        private void btnKriptirajSimetricnimKljucem_Click(object sender, EventArgs e)
        {
            string originalniTekst = UcitajIzDatoteke(originalniTextPutanja);

            if (originalniTekst != "")
            {
                string privatniKljuc = UcitajIzDatoteke(privatniKljucPutanja);

                if (privatniKljuc != "")
                {
                    string inicijalizacijskiVektor = UcitajIzDatoteke(inicijalizacijskiVektorPutanja);

                    if (inicijalizacijskiVektor != "")
                    {
                        byte[] kriptiraniTekstBytes = KriptirajTekst(originalniTekst, privatniKljuc, inicijalizacijskiVektor);

                        if (kriptiraniTekstBytes != null)
                        {
                            string kriptiraniTekstString = Convert.ToBase64String(kriptiraniTekstBytes);
                            ZapisiUDatoteku(kriptiraniTekstPutanja, kriptiraniTekstString);

                            MessageBox.Show("Kriptiranje uspješno!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtKriptiraniTekst.Text = kriptiraniTekstString;
                            btnDekriptirajSimetricnimKljucem.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Pogrešan ključ za kriptiranje!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Niste kreirali inicijalizacijski vektor!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Niste kreirali privatni ključ!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private byte[] KriptirajTekst(string originalniTekst, string privatniKljuc, string inicijalizacijskiVektor)
        {
            AesManaged aes = new AesManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;

            byte[] privatniKljucBytes = null;
            byte[] inicijalizacijskiVektorBytes = null;
            byte[] kriptiraniTextBytes = null;

            try
            {
                privatniKljucBytes = Convert.FromBase64String(privatniKljuc);
                inicijalizacijskiVektorBytes = Convert.FromBase64String(inicijalizacijskiVektor);
            }
            catch (FormatException)
            {
                kriptiraniTextBytes = null;
                return kriptiraniTextBytes;
            }

            aes.Key = privatniKljucBytes;
            aes.IV = inicijalizacijskiVektorBytes;
            
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream msKriptiraj = new MemoryStream())
            {
                using (CryptoStream csKriptiraj = new CryptoStream(msKriptiraj, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swKriptiraj = new StreamWriter(csKriptiraj))
                    {
                        swKriptiraj.Write(originalniTekst);
                    }
                    kriptiraniTextBytes = msKriptiraj.ToArray();
                }
            }

            aes.Clear();

            return kriptiraniTextBytes;
        }

        private void btnDekriptirajSimetricnimKljucem_Click(object sender, EventArgs e)
        {
            string kriptiraniTekst = UcitajIzDatoteke(kriptiraniTekstPutanja);

            if (kriptiraniTekst != "")
            {
                string privatniKljuc = UcitajIzDatoteke(privatniKljucPutanja);

                if (privatniKljuc != "")
                {
                    string inicijalizacijskiVektor = UcitajIzDatoteke(inicijalizacijskiVektorPutanja);

                    if (inicijalizacijskiVektor != "")
                    {
                        string dekriptiraniTekstString = DekriptirajTekst(kriptiraniTekst, privatniKljuc, inicijalizacijskiVektor);

                        if (dekriptiraniTekstString != "" && dekriptiraniTekstString != null)
                        {
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
                        MessageBox.Show("Niste kreirali inicijalizacijski vektor!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Niste kreirali privatni ključ!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Niste kriptirali originalni tekst!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DekriptirajTekst(string kriptiraniTekst, string privatniKljuc, string inicijalizacijskiVektor)
        {
            AesManaged aes = new AesManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;

            byte[] kriptiraniTekstBytes = null;
            byte[] privatniKljucBytes = null;
            byte[] inicijalizacijskiVektorBytes = null;
            string dekriptiraniTextString = "";

            try
            {
                kriptiraniTekstBytes = Convert.FromBase64String(kriptiraniTekst);
                privatniKljucBytes = Convert.FromBase64String(privatniKljuc);
                inicijalizacijskiVektorBytes = Convert.FromBase64String(inicijalizacijskiVektor);
            }
            catch (FormatException)
            {
                dekriptiraniTextString = "";
                return dekriptiraniTextString;
            }

            aes.Key = privatniKljucBytes;
            aes.IV = inicijalizacijskiVektorBytes;

            try
            {
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream msDekriptiraj = new MemoryStream(kriptiraniTekstBytes))
                {
                    using (CryptoStream csDekriptiraj = new CryptoStream(msDekriptiraj, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDekriptiraj = new StreamReader(csDekriptiraj))
                        {
                            dekriptiraniTextString = srDekriptiraj.ReadToEnd();
                        }
                    }
                }
            }
            catch (CryptographicException)
            {
                dekriptiraniTextString = "";
                return dekriptiraniTextString;
            }

            aes.Clear();
            return dekriptiraniTextString;
        }

        private void btnUsporediOriginalniIDekriptiraniTekst_Click(object sender, EventArgs e)
        {
            string originalniTekst = UcitajIzDatoteke(originalniTextPutanja);
            string dekriptiraniTekst = UcitajIzDatoteke(dekriptiraniTekstPutanja);

            if (string.Equals(originalniTekst, dekriptiraniTekst))
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
