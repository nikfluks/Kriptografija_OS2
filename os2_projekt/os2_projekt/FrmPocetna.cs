using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os2_projekt
{
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            FrmAsimetricnaKriptografija frmAsimetricnaKriptografija = new FrmAsimetricnaKriptografija();
            frmAsimetricnaKriptografija.ShowDialog();
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            FrmSimetricnaKriptografija frmSimetricnaKriptografija = new FrmSimetricnaKriptografija();
            frmSimetricnaKriptografija.ShowDialog();
        }

        private void btnDigitalniPotpis_Click(object sender, EventArgs e)
        {
            FrmDigitalniPotpis frmDigitalniPotpis = new FrmDigitalniPotpis();
            frmDigitalniPotpis.ShowDialog();
        }
    }
}
