namespace os2_projekt
{
    partial class FrmSimetricnaKriptografija
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
            this.btnOtvoriDatoteku = new System.Windows.Forms.Button();
            this.btnUsporediOriginalniIDekriptiraniTekst = new System.Windows.Forms.Button();
            this.lblDekriptiraniTekst = new System.Windows.Forms.Label();
            this.txtDekriptiraniTekst = new System.Windows.Forms.TextBox();
            this.lblKriptiraniTekst = new System.Windows.Forms.Label();
            this.txtKriptiraniTekst = new System.Windows.Forms.TextBox();
            this.lblPrivatniKljuc = new System.Windows.Forms.Label();
            this.txtPrivatniKljuc = new System.Windows.Forms.TextBox();
            this.lblOriginalniTekst = new System.Windows.Forms.Label();
            this.txtOriginalniTekst = new System.Windows.Forms.TextBox();
            this.btnDekriptirajSimetricnimKljucem = new System.Windows.Forms.Button();
            this.btnKriptirajSimetricnimKljucem = new System.Windows.Forms.Button();
            this.btnKreirajSimetricniKljuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOtvoriDatoteku
            // 
            this.btnOtvoriDatoteku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOtvoriDatoteku.Location = new System.Drawing.Point(27, 19);
            this.btnOtvoriDatoteku.Name = "btnOtvoriDatoteku";
            this.btnOtvoriDatoteku.Size = new System.Drawing.Size(400, 43);
            this.btnOtvoriDatoteku.TabIndex = 1;
            this.btnOtvoriDatoteku.Text = "Otvori datoteku";
            this.btnOtvoriDatoteku.UseVisualStyleBackColor = true;
            this.btnOtvoriDatoteku.Click += new System.EventHandler(this.btnOtvoriDatoteku_Click);
            // 
            // btnUsporediOriginalniIDekriptiraniTekst
            // 
            this.btnUsporediOriginalniIDekriptiraniTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsporediOriginalniIDekriptiraniTekst.Location = new System.Drawing.Point(478, 569);
            this.btnUsporediOriginalniIDekriptiraniTekst.Name = "btnUsporediOriginalniIDekriptiraniTekst";
            this.btnUsporediOriginalniIDekriptiraniTekst.Size = new System.Drawing.Size(160, 110);
            this.btnUsporediOriginalniIDekriptiraniTekst.TabIndex = 5;
            this.btnUsporediOriginalniIDekriptiraniTekst.Text = "Usporedi originalni i dekriptirani tekst";
            this.btnUsporediOriginalniIDekriptiraniTekst.UseVisualStyleBackColor = true;
            this.btnUsporediOriginalniIDekriptiraniTekst.Click += new System.EventHandler(this.btnUsporediOriginalniIDekriptiraniTekst_Click);
            // 
            // lblDekriptiraniTekst
            // 
            this.lblDekriptiraniTekst.AutoSize = true;
            this.lblDekriptiraniTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDekriptiraniTekst.Location = new System.Drawing.Point(23, 546);
            this.lblDekriptiraniTekst.Name = "lblDekriptiraniTekst";
            this.lblDekriptiraniTekst.Size = new System.Drawing.Size(141, 20);
            this.lblDekriptiraniTekst.TabIndex = 23;
            this.lblDekriptiraniTekst.Text = "Dekriptirani tekst:";
            // 
            // txtDekriptiraniTekst
            // 
            this.txtDekriptiraniTekst.Location = new System.Drawing.Point(27, 569);
            this.txtDekriptiraniTekst.Multiline = true;
            this.txtDekriptiraniTekst.Name = "txtDekriptiraniTekst";
            this.txtDekriptiraniTekst.ReadOnly = true;
            this.txtDekriptiraniTekst.Size = new System.Drawing.Size(420, 110);
            this.txtDekriptiraniTekst.TabIndex = 22;
            this.txtDekriptiraniTekst.TabStop = false;
            // 
            // lblKriptiraniTekst
            // 
            this.lblKriptiraniTekst.AutoSize = true;
            this.lblKriptiraniTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKriptiraniTekst.Location = new System.Drawing.Point(23, 390);
            this.lblKriptiraniTekst.Name = "lblKriptiraniTekst";
            this.lblKriptiraniTekst.Size = new System.Drawing.Size(122, 20);
            this.lblKriptiraniTekst.TabIndex = 21;
            this.lblKriptiraniTekst.Text = "Kriptirani tekst:";
            // 
            // txtKriptiraniTekst
            // 
            this.txtKriptiraniTekst.Location = new System.Drawing.Point(27, 413);
            this.txtKriptiraniTekst.Multiline = true;
            this.txtKriptiraniTekst.Name = "txtKriptiraniTekst";
            this.txtKriptiraniTekst.ReadOnly = true;
            this.txtKriptiraniTekst.Size = new System.Drawing.Size(420, 110);
            this.txtKriptiraniTekst.TabIndex = 20;
            this.txtKriptiraniTekst.TabStop = false;
            // 
            // lblPrivatniKljuc
            // 
            this.lblPrivatniKljuc.AutoSize = true;
            this.lblPrivatniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrivatniKljuc.Location = new System.Drawing.Point(23, 239);
            this.lblPrivatniKljuc.Name = "lblPrivatniKljuc";
            this.lblPrivatniKljuc.Size = new System.Drawing.Size(280, 20);
            this.lblPrivatniKljuc.TabIndex = 19;
            this.lblPrivatniKljuc.Text = "Privatni ključ i inicijalizacijski vektor:";
            // 
            // txtPrivatniKljuc
            // 
            this.txtPrivatniKljuc.Location = new System.Drawing.Point(27, 262);
            this.txtPrivatniKljuc.Multiline = true;
            this.txtPrivatniKljuc.Name = "txtPrivatniKljuc";
            this.txtPrivatniKljuc.ReadOnly = true;
            this.txtPrivatniKljuc.Size = new System.Drawing.Size(420, 110);
            this.txtPrivatniKljuc.TabIndex = 18;
            this.txtPrivatniKljuc.TabStop = false;
            // 
            // lblOriginalniTekst
            // 
            this.lblOriginalniTekst.AutoSize = true;
            this.lblOriginalniTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOriginalniTekst.Location = new System.Drawing.Point(23, 87);
            this.lblOriginalniTekst.Name = "lblOriginalniTekst";
            this.lblOriginalniTekst.Size = new System.Drawing.Size(126, 20);
            this.lblOriginalniTekst.TabIndex = 17;
            this.lblOriginalniTekst.Text = "Originalni tekst:";
            // 
            // txtOriginalniTekst
            // 
            this.txtOriginalniTekst.Location = new System.Drawing.Point(27, 110);
            this.txtOriginalniTekst.Multiline = true;
            this.txtOriginalniTekst.Name = "txtOriginalniTekst";
            this.txtOriginalniTekst.ReadOnly = true;
            this.txtOriginalniTekst.Size = new System.Drawing.Size(420, 110);
            this.txtOriginalniTekst.TabIndex = 16;
            this.txtOriginalniTekst.TabStop = false;
            // 
            // btnDekriptirajSimetricnimKljucem
            // 
            this.btnDekriptirajSimetricnimKljucem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDekriptirajSimetricnimKljucem.Location = new System.Drawing.Point(478, 413);
            this.btnDekriptirajSimetricnimKljucem.Name = "btnDekriptirajSimetricnimKljucem";
            this.btnDekriptirajSimetricnimKljucem.Size = new System.Drawing.Size(160, 110);
            this.btnDekriptirajSimetricnimKljucem.TabIndex = 4;
            this.btnDekriptirajSimetricnimKljucem.Text = "Dekriptiraj simetričnim ključem";
            this.btnDekriptirajSimetricnimKljucem.UseVisualStyleBackColor = true;
            this.btnDekriptirajSimetricnimKljucem.Click += new System.EventHandler(this.btnDekriptirajSimetricnimKljucem_Click);
            // 
            // btnKriptirajSimetricnimKljucem
            // 
            this.btnKriptirajSimetricnimKljucem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKriptirajSimetricnimKljucem.Location = new System.Drawing.Point(478, 262);
            this.btnKriptirajSimetricnimKljucem.Name = "btnKriptirajSimetricnimKljucem";
            this.btnKriptirajSimetricnimKljucem.Size = new System.Drawing.Size(160, 110);
            this.btnKriptirajSimetricnimKljucem.TabIndex = 3;
            this.btnKriptirajSimetricnimKljucem.Text = "Kriptiraj simetričnim ključem";
            this.btnKriptirajSimetricnimKljucem.UseVisualStyleBackColor = true;
            this.btnKriptirajSimetricnimKljucem.Click += new System.EventHandler(this.btnKriptirajSimetricnimKljucem_Click);
            // 
            // btnKreirajSimetricniKljuc
            // 
            this.btnKreirajSimetricniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreirajSimetricniKljuc.Location = new System.Drawing.Point(477, 110);
            this.btnKreirajSimetricniKljuc.Name = "btnKreirajSimetricniKljuc";
            this.btnKreirajSimetricniKljuc.Size = new System.Drawing.Size(160, 110);
            this.btnKreirajSimetricniKljuc.TabIndex = 2;
            this.btnKreirajSimetricniKljuc.Text = "Kreiraj simetrični ključ";
            this.btnKreirajSimetricniKljuc.UseVisualStyleBackColor = true;
            this.btnKreirajSimetricniKljuc.Click += new System.EventHandler(this.btnKreirajSimetricniKljuc_Click);
            // 
            // FrmSimetricnaKriptografija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 703);
            this.Controls.Add(this.btnOtvoriDatoteku);
            this.Controls.Add(this.btnUsporediOriginalniIDekriptiraniTekst);
            this.Controls.Add(this.lblDekriptiraniTekst);
            this.Controls.Add(this.txtDekriptiraniTekst);
            this.Controls.Add(this.lblKriptiraniTekst);
            this.Controls.Add(this.txtKriptiraniTekst);
            this.Controls.Add(this.lblPrivatniKljuc);
            this.Controls.Add(this.txtPrivatniKljuc);
            this.Controls.Add(this.lblOriginalniTekst);
            this.Controls.Add(this.txtOriginalniTekst);
            this.Controls.Add(this.btnDekriptirajSimetricnimKljucem);
            this.Controls.Add(this.btnKriptirajSimetricnimKljucem);
            this.Controls.Add(this.btnKreirajSimetricniKljuc);
            this.Name = "FrmSimetricnaKriptografija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simetrično kriptiranje - AES";
            this.Load += new System.EventHandler(this.FrmSimetricnaKriptografija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtvoriDatoteku;
        private System.Windows.Forms.Button btnUsporediOriginalniIDekriptiraniTekst;
        private System.Windows.Forms.Label lblDekriptiraniTekst;
        private System.Windows.Forms.TextBox txtDekriptiraniTekst;
        private System.Windows.Forms.Label lblKriptiraniTekst;
        private System.Windows.Forms.TextBox txtKriptiraniTekst;
        private System.Windows.Forms.Label lblPrivatniKljuc;
        private System.Windows.Forms.TextBox txtPrivatniKljuc;
        private System.Windows.Forms.Label lblOriginalniTekst;
        private System.Windows.Forms.TextBox txtOriginalniTekst;
        private System.Windows.Forms.Button btnDekriptirajSimetricnimKljucem;
        private System.Windows.Forms.Button btnKriptirajSimetricnimKljucem;
        private System.Windows.Forms.Button btnKreirajSimetricniKljuc;
    }
}