﻿namespace Market.WFA.KayıtFormları
{
    partial class CokluUrunEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.nuPiece = new System.Windows.Forms.NumericUpDown();
            this.nuPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.richExplanation = new System.Windows.Forms.RichTextBox();
            this.btnMultiAdd = new System.Windows.Forms.Button();
            this.MultiProductPicture = new System.Windows.Forms.PictureBox();
            this.btnPictureSelect = new System.Windows.Forms.Button();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnMCategoryAdd = new System.Windows.Forms.Button();
            this.btnMProductAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Satıs Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Urun";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(128, 58);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(145, 24);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(128, 88);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(145, 24);
            this.cmbProduct.TabIndex = 6;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkod.Location = new System.Drawing.Point(127, 30);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.ReadOnly = true;
            this.txtBarkod.Size = new System.Drawing.Size(145, 22);
            this.txtBarkod.TabIndex = 7;
            // 
            // nuPiece
            // 
            this.nuPiece.Location = new System.Drawing.Point(128, 118);
            this.nuPiece.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuPiece.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuPiece.Name = "nuPiece";
            this.nuPiece.Size = new System.Drawing.Size(144, 20);
            this.nuPiece.TabIndex = 8;
            this.nuPiece.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuPrice
            // 
            this.nuPrice.DecimalPlaces = 2;
            this.nuPrice.Location = new System.Drawing.Point(129, 144);
            this.nuPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nuPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nuPrice.Name = "nuPrice";
            this.nuPrice.Size = new System.Drawing.Size(144, 20);
            this.nuPrice.TabIndex = 9;
            this.nuPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Urun Detay";
            // 
            // richExplanation
            // 
            this.richExplanation.Location = new System.Drawing.Point(129, 171);
            this.richExplanation.Name = "richExplanation";
            this.richExplanation.Size = new System.Drawing.Size(143, 68);
            this.richExplanation.TabIndex = 11;
            this.richExplanation.Text = "";
            // 
            // btnMultiAdd
            // 
            this.btnMultiAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiAdd.Location = new System.Drawing.Point(129, 275);
            this.btnMultiAdd.Name = "btnMultiAdd";
            this.btnMultiAdd.Size = new System.Drawing.Size(143, 52);
            this.btnMultiAdd.TabIndex = 12;
            this.btnMultiAdd.Text = "Kaydet";
            this.btnMultiAdd.UseVisualStyleBackColor = true;
            this.btnMultiAdd.Click += new System.EventHandler(this.btnMultiAdd_Click);
            // 
            // MultiProductPicture
            // 
            this.MultiProductPicture.Location = new System.Drawing.Point(481, 30);
            this.MultiProductPicture.Name = "MultiProductPicture";
            this.MultiProductPicture.Size = new System.Drawing.Size(157, 134);
            this.MultiProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MultiProductPicture.TabIndex = 13;
            this.MultiProductPicture.TabStop = false;
            // 
            // btnPictureSelect
            // 
            this.btnPictureSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureSelect.Location = new System.Drawing.Point(480, 199);
            this.btnPictureSelect.Name = "btnPictureSelect";
            this.btnPictureSelect.Size = new System.Drawing.Size(158, 52);
            this.btnPictureSelect.TabIndex = 14;
            this.btnPictureSelect.Text = "Resim Sec";
            this.btnPictureSelect.UseVisualStyleBackColor = true;
            this.btnPictureSelect.Click += new System.EventHandler(this.btnPictureSelect_Click);
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openFileDialog1";
            // 
            // btnMCategoryAdd
            // 
            this.btnMCategoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCategoryAdd.Location = new System.Drawing.Point(279, 58);
            this.btnMCategoryAdd.Name = "btnMCategoryAdd";
            this.btnMCategoryAdd.Size = new System.Drawing.Size(162, 24);
            this.btnMCategoryAdd.TabIndex = 15;
            this.btnMCategoryAdd.Text = "Kategori Ekle";
            this.btnMCategoryAdd.UseVisualStyleBackColor = true;
            this.btnMCategoryAdd.Click += new System.EventHandler(this.btnMCategoryAdd_Click);
            // 
            // btnMProductAdd
            // 
            this.btnMProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMProductAdd.Location = new System.Drawing.Point(279, 88);
            this.btnMProductAdd.Name = "btnMProductAdd";
            this.btnMProductAdd.Size = new System.Drawing.Size(162, 24);
            this.btnMProductAdd.TabIndex = 16;
            this.btnMProductAdd.Text = "Ürün Ekle";
            this.btnMProductAdd.UseVisualStyleBackColor = true;
            this.btnMProductAdd.Click += new System.EventHandler(this.btnMProductAdd_Click);
            // 
            // CokluUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMProductAdd);
            this.Controls.Add(this.btnMCategoryAdd);
            this.Controls.Add(this.btnPictureSelect);
            this.Controls.Add(this.MultiProductPicture);
            this.Controls.Add(this.btnMultiAdd);
            this.Controls.Add(this.richExplanation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nuPrice);
            this.Controls.Add(this.nuPiece);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CokluUrunEkle";
            this.Text = "CokluUrunEkle";
            this.Load += new System.EventHandler(this.CokluUrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiProductPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nuPiece;
        private System.Windows.Forms.NumericUpDown nuPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richExplanation;
        private System.Windows.Forms.Button btnMultiAdd;
        private System.Windows.Forms.PictureBox MultiProductPicture;
        private System.Windows.Forms.Button btnPictureSelect;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.Button btnMCategoryAdd;
        private System.Windows.Forms.Button btnMProductAdd;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.ComboBox cmbProduct;
        public System.Windows.Forms.TextBox txtBarkod;
    }
}