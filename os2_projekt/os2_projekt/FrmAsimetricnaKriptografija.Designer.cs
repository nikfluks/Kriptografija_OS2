namespace os2_projekt
{
    partial class FrmAsimetricnaKriptografija
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
            this.btnKreirajAsimetricniKljuc = new System.Windows.Forms.Button();
            this.btnKriptirajAsimetricnimKljucem = new System.Windows.Forms.Button();
            this.btnDekriptirajAsimetricnimKljucem = new System.Windows.Forms.Button();
            this.txtOriginalniTekst = new System.Windows.Forms.TextBox();
            this.lblOriginalniTekst = new System.Windows.Forms.Label();
            this.lblTajniKljuc = new System.Windows.Forms.Label();
            this.txtTajniKljuc = new System.Windows.Forms.TextBox();
            this.lblKriptiraniTekst = new System.Windows.Forms.Label();
            this.txtKriptiraniTekst = new System.Windows.Forms.TextBox();
            this.lblDekriptiraniTekst = new System.Windows.Forms.Label();
            this.txtDekriptiraniTekst = new System.Windows.Forms.TextBox();
            this.btnUsporediOriginalniIDekriptiraniTekst = new System.Windows.Forms.Button();
            this.btnOtvoriDatoteku = new System.Windows.Forms.Button();
            this.lblJavniKljuc = new System.Windows.Forms.Label();
            this.txtJavniKljuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKreirajAsimetricniKljuc
            // 
            this.btnKreirajAsimetricniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreirajAsimetricniKljuc.Location = new System.Drawing.Point(456, 124);
            this.btnKreirajAsimetricniKljuc.Name = "btnKreirajAsimetricniKljuc";
            this.btnKreirajAsimetricniKljuc.Size = new System.Drawing.Size(165, 110);
            this.btnKreirajAsimetricniKljuc.TabIndex = 2;
            this.btnKreirajAsimetricniKljuc.Text = "Kreiraj asimetrične ključeve";
            this.btnKreirajAsimetricniKljuc.UseVisualStyleBackColor = true;
            this.btnKreirajAsimetricniKljuc.Click += new System.EventHandler(this.btnKreirajAsimetricniKljuc_Click);
            // 
            // btnKriptirajAsimetricnimKljucem
            // 
            this.btnKriptirajAsimetricnimKljucem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKriptirajAsimetricnimKljucem.Location = new System.Drawing.Point(456, 422);
            this.btnKriptirajAsimetricnimKljucem.Name = "btnKriptirajAsimetricnimKljucem";
            this.btnKriptirajAsimetricnimKljucem.Size = new System.Drawing.Size(165, 110);
            this.btnKriptirajAsimetricnimKljucem.TabIndex = 3;
            this.btnKriptirajAsimetricnimKljucem.Text = "Kriptiraj javnim asimetričnim ključem";
            this.btnKriptirajAsimetricnimKljucem.UseVisualStyleBackColor = true;
            this.btnKriptirajAsimetricnimKljucem.Click += new System.EventHandler(this.btnKriptirajAsimetricnimKljucem_Click);
            // 
            // btnDekriptirajAsimetricnimKljucem
            // 
            this.btnDekriptirajAsimetricnimKljucem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDekriptirajAsimetricnimKljucem.Location = new System.Drawing.Point(457, 573);
            this.btnDekriptirajAsimetricnimKljucem.Name = "btnDekriptirajAsimetricnimKljucem";
            this.btnDekriptirajAsimetricnimKljucem.Size = new System.Drawing.Size(165, 110);
            this.btnDekriptirajAsimetricnimKljucem.TabIndex = 4;
            this.btnDekriptirajAsimetricnimKljucem.Text = "Dekriptiraj tajnim asimetričnim ključem";
            this.btnDekriptirajAsimetricnimKljucem.UseVisualStyleBackColor = true;
            this.btnDekriptirajAsimetricnimKljucem.Click += new System.EventHandler(this.btnDekriptirajAsimetricnimKljucem_Click);
            // 
            // txtOriginalniTekst
            // 
            this.txtOriginalniTekst.Location = new System.Drawing.Point(31, 124);
            this.txtOriginalniTekst.Multiline = true;
            this.txtOriginalniTekst.Name = "txtOriginalniTekst";
            this.txtOriginalniTekst.ReadOnly = true;
            this.txtOriginalniTekst.Size = new System.Drawing.Size(400, 110);
            this.txtOriginalniTekst.TabIndex = 3;
            this.txtOriginalniTekst.TabStop = false;
            // 
            // lblOriginalniTekst
            // 
            this.lblOriginalniTekst.AutoSize = true;
            this.lblOriginalniTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOriginalniTekst.Location = new System.Drawing.Point(27, 101);
            this.lblOriginalniTekst.Name = "lblOriginalniTekst";
            this.lblOriginalniTekst.Size = new System.Drawing.Size(126, 20);
            this.lblOriginalniTekst.TabIndex = 4;
            this.lblOriginalniTekst.Text = "Originalni tekst:";
            // 
            // lblTajniKljuc
            // 
            this.lblTajniKljuc.AutoSize = true;
            this.lblTajniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTajniKljuc.Location = new System.Drawing.Point(27, 399);
            this.lblTajniKljuc.Name = "lblTajniKljuc";
            this.lblTajniKljuc.Size = new System.Drawing.Size(89, 20);
            this.lblTajniKljuc.TabIndex = 6;
            this.lblTajniKljuc.Text = "Tajni ključ:";
            // 
            // txtTajniKljuc
            // 
            this.txtTajniKljuc.Location = new System.Drawing.Point(31, 422);
            this.txtTajniKljuc.Multiline = true;
            this.txtTajniKljuc.Name = "txtTajniKljuc";
            this.txtTajniKljuc.ReadOnly = true;
            this.txtTajniKljuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTajniKljuc.Size = new System.Drawing.Size(400, 110);
            this.txtTajniKljuc.TabIndex = 5;
            this.txtTajniKljuc.TabStop = false;
            // 
            // lblKriptiraniTekst
            // 
            this.lblKriptiraniTekst.AutoSize = true;
            this.lblKriptiraniTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKriptiraniTekst.Location = new System.Drawing.Point(27, 550);
            this.lblKriptiraniTekst.Name = "lblKriptiraniTekst";
            this.lblKriptiraniTekst.Size = new System.Drawing.Size(122, 20);
            this.lblKriptiraniTekst.TabIndex = 8;
            this.lblKriptiraniTekst.Text = "Kriptirani tekst:";
            // 
            // txtKriptiraniTekst
            // 
            this.txtKriptiraniTekst.Location = new System.Drawing.Point(31, 573);
            this.txtKriptiraniTekst.Multiline = true;
            this.txtKriptiraniTekst.Name = "txtKriptiraniTekst";
            this.txtKriptiraniTekst.ReadOnly = true;
            this.txtKriptiraniTekst.Size = new System.Drawing.Size(400, 110);
            this.txtKriptiraniTekst.TabIndex = 7;
            this.txtKriptiraniTekst.TabStop = false;
            // 
            // lblDekriptiraniTekst
            // 
            this.lblDekriptiraniTekst.AutoSize = true;
            this.lblDekriptiraniTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDekriptiraniTekst.Location = new System.Drawing.Point(27, 706);
            this.lblDekriptiraniTekst.Name = "lblDekriptiraniTekst";
            this.lblDekriptiraniTekst.Size = new System.Drawing.Size(141, 20);
            this.lblDekriptiraniTekst.TabIndex = 10;
            this.lblDekriptiraniTekst.Text = "Dekriptirani tekst:";
            // 
            // txtDekriptiraniTekst
            // 
            this.txtDekriptiraniTekst.Location = new System.Drawing.Point(31, 729);
            this.txtDekriptiraniTekst.Multiline = true;
            this.txtDekriptiraniTekst.Name = "txtDekriptiraniTekst";
            this.txtDekriptiraniTekst.ReadOnly = true;
            this.txtDekriptiraniTekst.Size = new System.Drawing.Size(400, 110);
            this.txtDekriptiraniTekst.TabIndex = 9;
            this.txtDekriptiraniTekst.TabStop = false;
            // 
            // btnUsporediOriginalniIDekriptiraniTekst
            // 
            this.btnUsporediOriginalniIDekriptiraniTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsporediOriginalniIDekriptiraniTekst.Location = new System.Drawing.Point(457, 729);
            this.btnUsporediOriginalniIDekriptiraniTekst.Name = "btnUsporediOriginalniIDekriptiraniTekst";
            this.btnUsporediOriginalniIDekriptiraniTekst.Size = new System.Drawing.Size(165, 110);
            this.btnUsporediOriginalniIDekriptiraniTekst.TabIndex = 5;
            this.btnUsporediOriginalniIDekriptiraniTekst.Text = "Usporedi originalni i dekriptirani tekst";
            this.btnUsporediOriginalniIDekriptiraniTekst.UseVisualStyleBackColor = true;
            this.btnUsporediOriginalniIDekriptiraniTekst.Click += new System.EventHandler(this.btnUsporediOriginalniIDekriptiraniTekst_Click);
            // 
            // btnOtvoriDatoteku
            // 
            this.btnOtvoriDatoteku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOtvoriDatoteku.Location = new System.Drawing.Point(31, 23);
            this.btnOtvoriDatoteku.Name = "btnOtvoriDatoteku";
            this.btnOtvoriDatoteku.Size = new System.Drawing.Size(400, 43);
            this.btnOtvoriDatoteku.TabIndex = 1;
            this.btnOtvoriDatoteku.Text = "Otvori datoteku";
            this.btnOtvoriDatoteku.UseVisualStyleBackColor = true;
            this.btnOtvoriDatoteku.Click += new System.EventHandler(this.btnOtvoriDatoteku_Click);
            // 
            // lblJavniKljuc
            // 
            this.lblJavniKljuc.AutoSize = true;
            this.lblJavniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJavniKljuc.Location = new System.Drawing.Point(27, 252);
            this.lblJavniKljuc.Name = "lblJavniKljuc";
            this.lblJavniKljuc.Size = new System.Drawing.Size(92, 20);
            this.lblJavniKljuc.TabIndex = 14;
            this.lblJavniKljuc.Text = "Javni ključ:";
            // 
            // txtJavniKljuc
            // 
            this.txtJavniKljuc.Location = new System.Drawing.Point(31, 275);
            this.txtJavniKljuc.Multiline = true;
            this.txtJavniKljuc.Name = "txtJavniKljuc";
            this.txtJavniKljuc.ReadOnly = true;
            this.txtJavniKljuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJavniKljuc.Size = new System.Drawing.Size(400, 110);
            this.txtJavniKljuc.TabIndex = 13;
            this.txtJavniKljuc.TabStop = false;
            // 
            // FrmAsimetricnaKriptografija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 873);
            this.Controls.Add(this.lblJavniKljuc);
            this.Controls.Add(this.txtJavniKljuc);
            this.Controls.Add(this.btnOtvoriDatoteku);
            this.Controls.Add(this.btnUsporediOriginalniIDekriptiraniTekst);
            this.Controls.Add(this.lblDekriptiraniTekst);
            this.Controls.Add(this.txtDekriptiraniTekst);
            this.Controls.Add(this.lblKriptiraniTekst);
            this.Controls.Add(this.txtKriptiraniTekst);
            this.Controls.Add(this.lblTajniKljuc);
            this.Controls.Add(this.txtTajniKljuc);
            this.Controls.Add(this.lblOriginalniTekst);
            this.Controls.Add(this.txtOriginalniTekst);
            this.Controls.Add(this.btnDekriptirajAsimetricnimKljucem);
            this.Controls.Add(this.btnKriptirajAsimetricnimKljucem);
            this.Controls.Add(this.btnKreirajAsimetricniKljuc);
            this.Name = "FrmAsimetricnaKriptografija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asimetrično kriptiranje - RSA";
            this.Load += new System.EventHandler(this.FrmAsimetricnaKriptografija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKreirajAsimetricniKljuc;
        private System.Windows.Forms.Button btnKriptirajAsimetricnimKljucem;
        private System.Windows.Forms.Button btnDekriptirajAsimetricnimKljucem;
        private System.Windows.Forms.TextBox txtOriginalniTekst;
        private System.Windows.Forms.Label lblOriginalniTekst;
        private System.Windows.Forms.Label lblTajniKljuc;
        private System.Windows.Forms.TextBox txtTajniKljuc;
        private System.Windows.Forms.Label lblKriptiraniTekst;
        private System.Windows.Forms.TextBox txtKriptiraniTekst;
        private System.Windows.Forms.Label lblDekriptiraniTekst;
        private System.Windows.Forms.TextBox txtDekriptiraniTekst;
        private System.Windows.Forms.Button btnUsporediOriginalniIDekriptiraniTekst;
        private System.Windows.Forms.Button btnOtvoriDatoteku;
        private System.Windows.Forms.Label lblJavniKljuc;
        private System.Windows.Forms.TextBox txtJavniKljuc;
    }
}

