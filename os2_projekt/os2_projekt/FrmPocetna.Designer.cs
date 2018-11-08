namespace os2_projekt
{
    partial class FrmPocetna
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
            this.lblOdabirNacinaKriptiranja = new System.Windows.Forms.Label();
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnAES = new System.Windows.Forms.Button();
            this.btnDigitalniPotpis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOdabirNacinaKriptiranja
            // 
            this.lblOdabirNacinaKriptiranja.AutoSize = true;
            this.lblOdabirNacinaKriptiranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabirNacinaKriptiranja.Location = new System.Drawing.Point(77, 39);
            this.lblOdabirNacinaKriptiranja.Name = "lblOdabirNacinaKriptiranja";
            this.lblOdabirNacinaKriptiranja.Size = new System.Drawing.Size(244, 25);
            this.lblOdabirNacinaKriptiranja.TabIndex = 0;
            this.lblOdabirNacinaKriptiranja.Text = "Odaberite način kriptiranja:";
            // 
            // btnRSA
            // 
            this.btnRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRSA.Location = new System.Drawing.Point(35, 104);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(140, 110);
            this.btnRSA.TabIndex = 1;
            this.btnRSA.Text = "Asimetrično kriptiranje (RSA)";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnAES
            // 
            this.btnAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAES.Location = new System.Drawing.Point(236, 104);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(140, 110);
            this.btnAES.TabIndex = 2;
            this.btnAES.Text = "Simetrično kriptiranje (AES)";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // btnDigitalniPotpis
            // 
            this.btnDigitalniPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDigitalniPotpis.Location = new System.Drawing.Point(134, 247);
            this.btnDigitalniPotpis.Name = "btnDigitalniPotpis";
            this.btnDigitalniPotpis.Size = new System.Drawing.Size(140, 110);
            this.btnDigitalniPotpis.TabIndex = 3;
            this.btnDigitalniPotpis.Text = "Digitalni potpis";
            this.btnDigitalniPotpis.UseVisualStyleBackColor = true;
            this.btnDigitalniPotpis.Click += new System.EventHandler(this.btnDigitalniPotpis_Click);
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 393);
            this.Controls.Add(this.btnDigitalniPotpis);
            this.Controls.Add(this.btnAES);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.lblOdabirNacinaKriptiranja);
            this.Name = "FrmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dobrodošli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdabirNacinaKriptiranja;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Button btnDigitalniPotpis;
    }
}