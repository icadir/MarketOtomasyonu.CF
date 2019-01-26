namespace Market.WFA.SatısIslemleri
{
    partial class SatısForm
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
            this.lstSatılacakurunler = new System.Windows.Forms.ListBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nuSayi = new System.Windows.Forms.NumericUpDown();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.rdKkartı = new System.Windows.Forms.RadioButton();
            this.rdPesin = new System.Windows.Forms.RadioButton();
            this.pPesinPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblParaüstü = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuSayi)).BeginInit();
            this.pPesinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSatılacakurunler
            // 
            this.lstSatılacakurunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSatılacakurunler.FormattingEnabled = true;
            this.lstSatılacakurunler.ItemHeight = 16;
            this.lstSatılacakurunler.Location = new System.Drawing.Point(442, 12);
            this.lstSatılacakurunler.Name = "lstSatılacakurunler";
            this.lstSatılacakurunler.Size = new System.Drawing.Size(391, 212);
            this.lstSatılacakurunler.TabIndex = 0;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkod.Location = new System.Drawing.Point(140, 48);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(129, 22);
            this.txtBarkod.TabIndex = 1;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod No :";
            // 
            // nuSayi
            // 
            this.nuSayi.Location = new System.Drawing.Point(140, 89);
            this.nuSayi.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nuSayi.Name = "nuSayi";
            this.nuSayi.Size = new System.Drawing.Size(129, 20);
            this.nuSayi.TabIndex = 3;
            this.nuSayi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTamamla
            // 
            this.btnTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamamla.Location = new System.Drawing.Point(441, 405);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(391, 60);
            this.btnTamamla.TabIndex = 4;
            this.btnTamamla.Text = "Satıs";
            this.btnTamamla.UseVisualStyleBackColor = true;
            // 
            // rdKkartı
            // 
            this.rdKkartı.AutoSize = true;
            this.rdKkartı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKkartı.Location = new System.Drawing.Point(562, 269);
            this.rdKkartı.Name = "rdKkartı";
            this.rdKkartı.Size = new System.Drawing.Size(97, 20);
            this.rdKkartı.TabIndex = 5;
            this.rdKkartı.TabStop = true;
            this.rdKkartı.Text = "Kredi Kartı";
            this.rdKkartı.UseVisualStyleBackColor = true;
            // 
            // rdPesin
            // 
            this.rdPesin.AutoSize = true;
            this.rdPesin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPesin.Location = new System.Drawing.Point(442, 269);
            this.rdPesin.Name = "rdPesin";
            this.rdPesin.Size = new System.Drawing.Size(65, 20);
            this.rdPesin.TabIndex = 6;
            this.rdPesin.TabStop = true;
            this.rdPesin.Text = "Peşin";
            this.rdPesin.UseVisualStyleBackColor = true;
            // 
            // pPesinPanel
            // 
            this.pPesinPanel.Controls.Add(this.lblParaüstü);
            this.pPesinPanel.Controls.Add(this.label4);
            this.pPesinPanel.Controls.Add(this.label6);
            this.pPesinPanel.Controls.Add(this.numericUpDown1);
            this.pPesinPanel.Location = new System.Drawing.Point(442, 295);
            this.pPesinPanel.Name = "pPesinPanel";
            this.pPesinPanel.Size = new System.Drawing.Size(278, 86);
            this.pPesinPanel.TabIndex = 7;
            this.pPesinPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ToplamTutar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adet";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamFiyat.Location = new System.Drawing.Point(559, 240);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(99, 16);
            this.lblToplamFiyat.TabIndex = 10;
            this.lblToplamFiyat.Text = "Toplam Fiyat";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(129, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(129, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nakit Ücreti";
            // 
            // lblParaüstü
            // 
            this.lblParaüstü.AutoSize = true;
            this.lblParaüstü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParaüstü.Location = new System.Drawing.Point(123, 43);
            this.lblParaüstü.Name = "lblParaüstü";
            this.lblParaüstü.Size = new System.Drawing.Size(76, 16);
            this.lblParaüstü.TabIndex = 12;
            this.lblParaüstü.Text = "Para Üstü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Para Üstü :";
            // 
            // SatısForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 510);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pPesinPanel);
            this.Controls.Add(this.rdPesin);
            this.Controls.Add(this.rdKkartı);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.nuSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lstSatılacakurunler);
            this.Name = "SatısForm";
            this.Text = "SatısForm";
            ((System.ComponentModel.ISupportInitialize)(this.nuSayi)).EndInit();
            this.pPesinPanel.ResumeLayout(false);
            this.pPesinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSatılacakurunler;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuSayi;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.RadioButton rdKkartı;
        private System.Windows.Forms.RadioButton rdPesin;
        private System.Windows.Forms.Panel pPesinPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label lblParaüstü;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}