namespace Market.WFA.KayıtFormları
{
    partial class UrunEkle
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
            this.txtProductBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nuProductPrice = new System.Windows.Forms.NumericUpDown();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.pProductImage = new System.Windows.Forms.PictureBox();
            this.btnPictureAdd = new System.Windows.Forms.Button();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductBarkod
            // 
            this.txtProductBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductBarkod.Location = new System.Drawing.Point(177, 50);
            this.txtProductBarkod.Name = "txtProductBarkod";
            this.txtProductBarkod.Size = new System.Drawing.Size(138, 22);
            this.txtProductBarkod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Barkod No ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Adı";
            // 
            // nuProductPrice
            // 
            this.nuProductPrice.DecimalPlaces = 2;
            this.nuProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuProductPrice.Location = new System.Drawing.Point(177, 107);
            this.nuProductPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nuProductPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nuProductPrice.Name = "nuProductPrice";
            this.nuProductPrice.Size = new System.Drawing.Size(138, 22);
            this.nuProductPrice.TabIndex = 5;
            this.nuProductPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(177, 18);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(139, 24);
            this.cmbCategory.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kategori Seciniz ";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(177, 78);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(138, 22);
            this.txtProductName.TabIndex = 8;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductAdd.Location = new System.Drawing.Point(177, 162);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(138, 40);
            this.btnProductAdd.TabIndex = 9;
            this.btnProductAdd.Text = "Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // pProductImage
            // 
            this.pProductImage.Location = new System.Drawing.Point(353, 21);
            this.pProductImage.Name = "pProductImage";
            this.pProductImage.Size = new System.Drawing.Size(145, 108);
            this.pProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pProductImage.TabIndex = 10;
            this.pProductImage.TabStop = false;
            // 
            // btnPictureAdd
            // 
            this.btnPictureAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureAdd.Location = new System.Drawing.Point(353, 162);
            this.btnPictureAdd.Name = "btnPictureAdd";
            this.btnPictureAdd.Size = new System.Drawing.Size(145, 40);
            this.btnPictureAdd.TabIndex = 11;
            this.btnPictureAdd.Text = "Resim Ekle";
            this.btnPictureAdd.UseVisualStyleBackColor = true;
            this.btnPictureAdd.Click += new System.EventHandler(this.btnPictureAdd_Click);
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(9, 162);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 40);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Vazgec";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 359);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPictureAdd);
            this.Controls.Add(this.pProductImage);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.nuProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductBarkod);
            this.Name = "UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuProductPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.PictureBox pProductImage;
        private System.Windows.Forms.Button btnPictureAdd;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.Button btnClose;
    }
}