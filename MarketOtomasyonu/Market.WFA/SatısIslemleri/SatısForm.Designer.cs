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
            this.nuAdet = new System.Windows.Forms.NumericUpDown();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.rdKkartı = new System.Windows.Forms.RadioButton();
            this.rdPesin = new System.Windows.Forms.RadioButton();
            this.pPesinPanel = new System.Windows.Forms.Panel();
            this.lblParaüstü = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nuNakit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.cbPoset = new System.Windows.Forms.CheckBox();
            this.nuPoset = new System.Windows.Forms.NumericUpDown();
            this.btnOde = new System.Windows.Forms.Button();
            this.pnlOdemeTip = new System.Windows.Forms.Panel();
            this.pnlOdemeAl = new System.Windows.Forms.Panel();
            this.pnlBarkod = new System.Windows.Forms.Panel();
            this.pnlPoset = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nuAdet)).BeginInit();
            this.pPesinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuNakit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPoset)).BeginInit();
            this.pnlOdemeTip.SuspendLayout();
            this.pnlOdemeAl.SuspendLayout();
            this.pnlBarkod.SuspendLayout();
            this.pnlPoset.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSatılacakurunler
            // 
            this.lstSatılacakurunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSatılacakurunler.FormattingEnabled = true;
            this.lstSatılacakurunler.ItemHeight = 16;
            this.lstSatılacakurunler.Location = new System.Drawing.Point(442, 12);
            this.lstSatılacakurunler.Name = "lstSatılacakurunler";
            this.lstSatılacakurunler.Size = new System.Drawing.Size(442, 212);
            this.lstSatılacakurunler.TabIndex = 0;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkod.Location = new System.Drawing.Point(130, 13);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(129, 22);
            this.txtBarkod.TabIndex = 1;
          
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod No :";
            // 
            // nuAdet
            // 
            this.nuAdet.Location = new System.Drawing.Point(130, 54);
            this.nuAdet.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nuAdet.Name = "nuAdet";
            this.nuAdet.Size = new System.Drawing.Size(129, 20);
            this.nuAdet.TabIndex = 3;
            this.nuAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTamamla
            // 
            this.btnTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamamla.Location = new System.Drawing.Point(11, 140);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(347, 60);
            this.btnTamamla.TabIndex = 4;
            this.btnTamamla.Text = "Satıs";
            this.btnTamamla.UseVisualStyleBackColor = true;
            // 
            // rdKkartı
            // 
            this.rdKkartı.AutoSize = true;
            this.rdKkartı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKkartı.Location = new System.Drawing.Point(107, 6);
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
            this.rdPesin.Location = new System.Drawing.Point(6, 5);
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
            this.pPesinPanel.Controls.Add(this.nuNakit);
            this.pPesinPanel.Location = new System.Drawing.Point(9, 39);
            this.pPesinPanel.Name = "pPesinPanel";
            this.pPesinPanel.Size = new System.Drawing.Size(278, 86);
            this.pPesinPanel.TabIndex = 7;
            // 
            // lblParaüstü
            // 
            this.lblParaüstü.AutoSize = true;
            this.lblParaüstü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParaüstü.Location = new System.Drawing.Point(128, 43);
            this.lblParaüstü.Name = "lblParaüstü";
            this.lblParaüstü.Size = new System.Drawing.Size(76, 16);
            this.lblParaüstü.TabIndex = 12;
            this.lblParaüstü.Text = "Para Üstü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nakit Girişi";
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
            // nuNakit
            // 
            this.nuNakit.Location = new System.Drawing.Point(129, 13);
            this.nuNakit.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nuNakit.Name = "nuNakit";
            this.nuNakit.Size = new System.Drawing.Size(129, 20);
            this.nuNakit.TabIndex = 11;
            this.nuNakit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(652, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ToplamTutar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adet";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamFiyat.Location = new System.Drawing.Point(772, 255);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(0, 16);
            this.lblToplamFiyat.TabIndex = 10;
            // 
            // cbPoset
            // 
            this.cbPoset.AutoSize = true;
            this.cbPoset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPoset.Location = new System.Drawing.Point(5, 6);
            this.cbPoset.Name = "cbPoset";
            this.cbPoset.Size = new System.Drawing.Size(79, 24);
            this.cbPoset.TabIndex = 19;
            this.cbPoset.Text = "Poset:";
            this.cbPoset.UseVisualStyleBackColor = true;
            this.cbPoset.CheckedChanged += new System.EventHandler(this.cbPoset_CheckedChanged);
            // 
            // nuPoset
            // 
            this.nuPoset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nuPoset.Location = new System.Drawing.Point(90, 5);
            this.nuPoset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nuPoset.Name = "nuPoset";
            this.nuPoset.Size = new System.Drawing.Size(75, 26);
            this.nuPoset.TabIndex = 18;
            this.nuPoset.Visible = false;
            this.nuPoset.ValueChanged += new System.EventHandler(this.nuPoset_ValueChanged);
            this.nuPoset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nuPoset_KeyUp);
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(441, 286);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(443, 37);
            this.btnOde.TabIndex = 16;
            this.btnOde.Text = "Ödeme Al";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // pnlOdemeTip
            // 
            this.pnlOdemeTip.Controls.Add(this.rdPesin);
            this.pnlOdemeTip.Controls.Add(this.rdKkartı);
            this.pnlOdemeTip.Location = new System.Drawing.Point(9, 3);
            this.pnlOdemeTip.Name = "pnlOdemeTip";
            this.pnlOdemeTip.Size = new System.Drawing.Size(236, 30);
            this.pnlOdemeTip.TabIndex = 20;
            this.pnlOdemeTip.Visible = false;
            // 
            // pnlOdemeAl
            // 
            this.pnlOdemeAl.Controls.Add(this.pnlOdemeTip);
            this.pnlOdemeAl.Controls.Add(this.btnTamamla);
            this.pnlOdemeAl.Controls.Add(this.pPesinPanel);
            this.pnlOdemeAl.Location = new System.Drawing.Point(444, 350);
            this.pnlOdemeAl.Name = "pnlOdemeAl";
            this.pnlOdemeAl.Size = new System.Drawing.Size(388, 213);
            this.pnlOdemeAl.TabIndex = 21;
            this.pnlOdemeAl.Visible = false;
            // 
            // pnlBarkod
            // 
            this.pnlBarkod.Controls.Add(this.txtBarkod);
            this.pnlBarkod.Controls.Add(this.label1);
            this.pnlBarkod.Controls.Add(this.nuAdet);
            this.pnlBarkod.Controls.Add(this.label3);
            this.pnlBarkod.Location = new System.Drawing.Point(12, 27);
            this.pnlBarkod.Name = "pnlBarkod";
            this.pnlBarkod.Size = new System.Drawing.Size(273, 96);
            this.pnlBarkod.TabIndex = 22;
            // 
            // pnlPoset
            // 
            this.pnlPoset.Controls.Add(this.nuPoset);
            this.pnlPoset.Controls.Add(this.cbPoset);
            this.pnlPoset.Location = new System.Drawing.Point(442, 240);
            this.pnlPoset.Name = "pnlPoset";
            this.pnlPoset.Size = new System.Drawing.Size(183, 40);
            this.pnlPoset.TabIndex = 23;
            // 
            // SatısForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 603);
            this.Controls.Add(this.pnlPoset);
            this.Controls.Add(this.pnlBarkod);
            this.Controls.Add(this.pnlOdemeAl);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSatılacakurunler);
            this.Name = "SatısForm";
            this.Text = "SatısForm";
            ((System.ComponentModel.ISupportInitialize)(this.nuAdet)).EndInit();
            this.pPesinPanel.ResumeLayout(false);
            this.pPesinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuNakit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPoset)).EndInit();
            this.pnlOdemeTip.ResumeLayout(false);
            this.pnlOdemeTip.PerformLayout();
            this.pnlOdemeAl.ResumeLayout(false);
            this.pnlBarkod.ResumeLayout(false);
            this.pnlBarkod.PerformLayout();
            this.pnlPoset.ResumeLayout(false);
            this.pnlPoset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSatılacakurunler;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuAdet;
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
        private System.Windows.Forms.NumericUpDown nuNakit;
        private System.Windows.Forms.CheckBox cbPoset;
        private System.Windows.Forms.NumericUpDown nuPoset;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Panel pnlOdemeTip;
        private System.Windows.Forms.Panel pnlOdemeAl;
        private System.Windows.Forms.Panel pnlBarkod;
        private System.Windows.Forms.Panel pnlPoset;
    }
}