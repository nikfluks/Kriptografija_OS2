namespace os2_projekt
{
    partial class FrmDigitalniPotpis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJavniKljuc = new System.Windows.Forms.Label();
            this.txtJavniKljuc = new System.Windows.Forms.TextBox();
            this.btnOtvoriDatoteku = new System.Windows.Forms.Button();
            this.lblTajniKljuc = new System.Windows.Forms.Label();
            this.txtTajniKljuc = new System.Windows.Forms.TextBox();
            this.lblOriginalniTekst = new System.Windows.Forms.Label();
            this.txtOriginalniTekst = new System.Windows.Forms.TextBox();
            this.btnKreirajAsimetricniKljuc = new System.Windows.Forms.Button();
            this.lblHash = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnIzracunajHash = new System.Windows.Forms.Button();
            this.lblKriptiraniDigitalniPotpis = new System.Windows.Forms.Label();
            this.txtKriptiraniDigitalniPotpis = new System.Windows.Forms.TextBox();
            this.btnIzracunajDigitalniPotpis = new System.Windows.Forms.Button();
            this.btnProvjeriDigitalniPotp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJavniKljuc
            // 
            this.lblJavniKljuc.AutoSize = true;
            this.lblJavniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJavniKljuc.Location = new System.Drawing.Point(19, 243);
            this.lblJavniKljuc.Name = "lblJavniKljuc";
            this.lblJavniKljuc.Size = new System.Drawing.Size(92, 20);
            this.lblJavniKljuc.TabIndex = 23;
            this.lblJavniKljuc.Text = "Javni ključ:";
            // 
            // txtJavniKljuc
            // 
            this.txtJavniKljuc.Location = new System.Drawing.Point(23, 266);
            this.txtJavniKljuc.Multiline = true;
            this.txtJavniKljuc.Name = "txtJavniKljuc";
            this.txtJavniKljuc.ReadOnly = true;
            this.txtJavniKljuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJavniKljuc.Size = new System.Drawing.Size(530, 110);
            this.txtJavniKljuc.TabIndex = 22;
            this.txtJavniKljuc.TabStop = false;
            // 
            // btnOtvoriDatoteku
            // 
            this.btnOtvoriDatoteku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOtvoriDatoteku.Location = new System.Drawing.Point(23, 20);
            this.btnOtvoriDatoteku.Name = "btnOtvoriDatoteku";
            this.btnOtvoriDatoteku.Size = new System.Drawing.Size(400, 43);
            this.btnOtvoriDatoteku.TabIndex = 1;
            this.btnOtvoriDatoteku.Text = "Otvori datoteku";
            this.btnOtvoriDatoteku.UseVisualStyleBackColor = true;
            this.btnOtvoriDatoteku.Click += new System.EventHandler(this.btnOtvoriDatoteku_Click);
            // 
            // lblTajniKljuc
            // 
            this.lblTajniKljuc.AutoSize = true;
            this.lblTajniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTajniKljuc.Location = new System.Drawing.Point(19, 393);
            this.lblTajniKljuc.Name = "lblTajniKljuc";
            this.lblTajniKljuc.Size = new System.Drawing.Size(89, 20);
            this.lblTajniKljuc.TabIndex = 20;
            this.lblTajniKljuc.Text = "Tajni ključ:";
            // 
            // txtTajniKljuc
            // 
            this.txtTajniKljuc.Location = new System.Drawing.Point(23, 416);
            this.txtTajniKljuc.Multiline = true;
            this.txtTajniKljuc.Name = "txtTajniKljuc";
            this.txtTajniKljuc.ReadOnly = true;
            this.txtTajniKljuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTajniKljuc.Size = new System.Drawing.Size(530, 110);
            this.txtTajniKljuc.TabIndex = 19;
            this.txtTajniKljuc.TabStop = false;
            // 
            // lblOriginalniTekst
            // 
            this.lblOriginalniTekst.AutoSize = true;
            this.lblOriginalniTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOriginalniTekst.Location = new System.Drawing.Point(19, 92);
            this.lblOriginalniTekst.Name = "lblOriginalniTekst";
            this.lblOriginalniTekst.Size = new System.Drawing.Size(126, 20);
            this.lblOriginalniTekst.TabIndex = 18;
            this.lblOriginalniTekst.Text = "Originalni tekst:";
            // 
            // txtOriginalniTekst
            // 
            this.txtOriginalniTekst.Location = new System.Drawing.Point(23, 115);
            this.txtOriginalniTekst.Multiline = true;
            this.txtOriginalniTekst.Name = "txtOriginalniTekst";
            this.txtOriginalniTekst.ReadOnly = true;
            this.txtOriginalniTekst.Size = new System.Drawing.Size(530, 110);
            this.txtOriginalniTekst.TabIndex = 17;
            this.txtOriginalniTekst.TabStop = false;
            // 
            // btnKreirajAsimetricniKljuc
            // 
            this.btnKreirajAsimetricniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreirajAsimetricniKljuc.Location = new System.Drawing.Point(582, 115);
            this.btnKreirajAsimetricniKljuc.Name = "btnKreirajAsimetricniKljuc";
            this.btnKreirajAsimetricniKljuc.Size = new System.Drawing.Size(165, 110);
            this.btnKreirajAsimetricniKljuc.TabIndex = 2;
            this.btnKreirajAsimetricniKljuc.Text = "Kreiraj asimetrične ključeve";
            this.btnKreirajAsimetricniKljuc.UseVisualStyleBackColor = true;
            this.btnKreirajAsimetricniKljuc.Click += new System.EventHandler(this.btnKreirajAsimetricniKljuc_Click);
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHash.Location = new System.Drawing.Point(19, 544);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(54, 20);
            this.lblHash.TabIndex = 26;
            this.lblHash.Text = "Hash:";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(23, 567);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.ReadOnly = true;
            this.txtHash.Size = new System.Drawing.Size(530, 110);
            this.txtHash.TabIndex = 25;
            this.txtHash.TabStop = false;
            // 
            // btnIzracunajHash
            // 
            this.btnIzracunajHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzracunajHash.Location = new System.Drawing.Point(588, 416);
            this.btnIzracunajHash.Name = "btnIzracunajHash";
            this.btnIzracunajHash.Size = new System.Drawing.Size(165, 110);
            this.btnIzracunajHash.TabIndex = 3;
            this.btnIzracunajHash.Text = "Izračunaj hash orginalnog teksta";
            this.btnIzracunajHash.UseVisualStyleBackColor = true;
            this.btnIzracunajHash.Click += new System.EventHandler(this.btnIzracunajHash_Click);
            // 
            // lblKriptiraniDigitalniPotpis
            // 
            this.lblKriptiraniDigitalniPotpis.AutoSize = true;
            this.lblKriptiraniDigitalniPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKriptiraniDigitalniPotpis.Location = new System.Drawing.Point(19, 697);
            this.lblKriptiraniDigitalniPotpis.Name = "lblKriptiraniDigitalniPotpis";
            this.lblKriptiraniDigitalniPotpis.Size = new System.Drawing.Size(355, 20);
            this.lblKriptiraniDigitalniPotpis.TabIndex = 29;
            this.lblKriptiraniDigitalniPotpis.Text = "Digitalni potpis (hash kriptiran tajnim ključem):";
            // 
            // txtKriptiraniDigitalniPotpis
            // 
            this.txtKriptiraniDigitalniPotpis.Location = new System.Drawing.Point(23, 720);
            this.txtKriptiraniDigitalniPotpis.Multiline = true;
            this.txtKriptiraniDigitalniPotpis.Name = "txtKriptiraniDigitalniPotpis";
            this.txtKriptiraniDigitalniPotpis.ReadOnly = true;
            this.txtKriptiraniDigitalniPotpis.Size = new System.Drawing.Size(530, 110);
            this.txtKriptiraniDigitalniPotpis.TabIndex = 28;
            this.txtKriptiraniDigitalniPotpis.TabStop = false;
            // 
            // btnIzracunajDigitalniPotpis
            // 
            this.btnIzracunajDigitalniPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzracunajDigitalniPotpis.Location = new System.Drawing.Point(588, 567);
            this.btnIzracunajDigitalniPotpis.Name = "btnIzracunajDigitalniPotpis";
            this.btnIzracunajDigitalniPotpis.Size = new System.Drawing.Size(165, 110);
            this.btnIzracunajDigitalniPotpis.TabIndex = 4;
            this.btnIzracunajDigitalniPotpis.Text = "Izračunaj digitalni potpis";
            this.btnIzracunajDigitalniPotpis.UseVisualStyleBackColor = true;
            this.btnIzracunajDigitalniPotpis.Click += new System.EventHandler(this.btnIzracunajDigitalniPotpis_Click);
            // 
            // btnProvjeriDigitalniPotp
            // 
            this.btnProvjeriDigitalniPotp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProvjeriDigitalniPotp.Location = new System.Drawing.Point(588, 720);
            this.btnProvjeriDigitalniPotp.Name = "btnProvjeriDigitalniPotp";
            this.btnProvjeriDigitalniPotp.Size = new System.Drawing.Size(165, 110);
            this.btnProvjeriDigitalniPotp.TabIndex = 5;
            this.btnProvjeriDigitalniPotp.Text = "Provjeri digitalni potpis";
            this.btnProvjeriDigitalniPotp.UseVisualStyleBackColor = true;
            this.btnProvjeriDigitalniPotp.Click += new System.EventHandler(this.btnProvjeriDigitalniPotp_Click);
            // 
            // FrmDigitalniPotpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 853);
            this.Controls.Add(this.btnProvjeriDigitalniPotp);
            this.Controls.Add(this.lblKriptiraniDigitalniPotpis);
            this.Controls.Add(this.txtKriptiraniDigitalniPotpis);
            this.Controls.Add(this.btnIzracunajDigitalniPotpis);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.btnIzracunajHash);
            this.Controls.Add(this.lblJavniKljuc);
            this.Controls.Add(this.txtJavniKljuc);
            this.Controls.Add(this.btnOtvoriDatoteku);
            this.Controls.Add(this.lblTajniKljuc);
            this.Controls.Add(this.txtTajniKljuc);
            this.Controls.Add(this.lblOriginalniTekst);
            this.Controls.Add(this.txtOriginalniTekst);
            this.Controls.Add(this.btnKreirajAsimetricniKljuc);
            this.Name = "FrmDigitalniPotpis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitalni potpis";
            this.Load += new System.EventHandler(this.FrmDigitalniPotpis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJavniKljuc;
        private System.Windows.Forms.TextBox txtJavniKljuc;
        private System.Windows.Forms.Button btnOtvoriDatoteku;
        private System.Windows.Forms.Label lblTajniKljuc;
        private System.Windows.Forms.TextBox txtTajniKljuc;
        private System.Windows.Forms.Label lblOriginalniTekst;
        private System.Windows.Forms.TextBox txtOriginalniTekst;
        private System.Windows.Forms.Button btnKreirajAsimetricniKljuc;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnIzracunajHash;
        private System.Windows.Forms.Label lblKriptiraniDigitalniPotpis;
        private System.Windows.Forms.TextBox txtKriptiraniDigitalniPotpis;
        private System.Windows.Forms.Button btnIzracunajDigitalniPotpis;
        private System.Windows.Forms.Button btnProvjeriDigitalniPotp;
    }
}