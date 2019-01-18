namespace Market.WFA.IşlemFormları
{
    partial class UrunKabulForm
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
            this.txtBarkodNoDef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMultiAdd = new System.Windows.Forms.Button();
            this.richExplanation = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nuPrice = new System.Windows.Forms.NumericUpDown();
            this.nuPiece = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nuTakenPieces = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuTakenPieces)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkodNoDef
            // 
            this.txtBarkodNoDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkodNoDef.Location = new System.Drawing.Point(144, 16);
            this.txtBarkodNoDef.Name = "txtBarkodNoDef";
            this.txtBarkodNoDef.ReadOnly = true;
            this.txtBarkodNoDef.Size = new System.Drawing.Size(153, 22);
            this.txtBarkodNoDef.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Barkod";
            // 
            // btnMultiAdd
            // 
            this.btnMultiAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiAdd.Location = new System.Drawing.Point(6, 295);
            this.btnMultiAdd.Name = "btnMultiAdd";
            this.btnMultiAdd.Size = new System.Drawing.Size(291, 52);
            this.btnMultiAdd.TabIndex = 32;
            this.btnMultiAdd.Text = "Urun Kabul";
            this.btnMultiAdd.UseVisualStyleBackColor = true;
            // 
            // richExplanation
            // 
            this.richExplanation.Location = new System.Drawing.Point(143, 163);
            this.richExplanation.Name = "richExplanation";
            this.richExplanation.ReadOnly = true;
            this.richExplanation.Size = new System.Drawing.Size(154, 68);
            this.richExplanation.TabIndex = 31;
            this.richExplanation.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Urun Detay";
            // 
            // nuPrice
            // 
            this.nuPrice.DecimalPlaces = 2;
            this.nuPrice.Location = new System.Drawing.Point(144, 137);
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
            this.nuPrice.ReadOnly = true;
            this.nuPrice.Size = new System.Drawing.Size(152, 20);
            this.nuPrice.TabIndex = 29;
            this.nuPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // nuPiece
            // 
            this.nuPiece.Location = new System.Drawing.Point(143, 111);
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
            this.nuPiece.ReadOnly = true;
            this.nuPiece.Size = new System.Drawing.Size(152, 20);
            this.nuPiece.TabIndex = 28;
            this.nuPiece.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Satıs Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adet Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Urun";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(143, 55);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ReadOnly = true;
            this.txtCategoryName.Size = new System.Drawing.Size(153, 22);
            this.txtCategoryName.TabIndex = 34;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(143, 83);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(153, 22);
            this.txtProductName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Alınan Adet Sayisi";
            // 
            // nuTakenPieces
            // 
            this.nuTakenPieces.Location = new System.Drawing.Point(143, 252);
            this.nuTakenPieces.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuTakenPieces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuTakenPieces.Name = "nuTakenPieces";
            this.nuTakenPieces.Size = new System.Drawing.Size(154, 20);
            this.nuTakenPieces.TabIndex = 37;
            this.nuTakenPieces.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UrunKabulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(481, 416);
            this.Controls.Add(this.nuTakenPieces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMultiAdd);
            this.Controls.Add(this.richExplanation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nuPrice);
            this.Controls.Add(this.nuPiece);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarkodNoDef);
            this.Controls.Add(this.label7);
            this.Name = "UrunKabulForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UrunKabulForm";
            this.Load += new System.EventHandler(this.UrunKabulForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuTakenPieces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMultiAdd;
        private System.Windows.Forms.RichTextBox richExplanation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nuPrice;
        private System.Windows.Forms.NumericUpDown nuPiece;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtBarkodNoDef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuTakenPieces;
    }
}