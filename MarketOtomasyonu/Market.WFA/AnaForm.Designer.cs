namespace Market.WFA
{
    partial class AnaForm
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
            this.btnAdds = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdds
            // 
            this.btnAdds.BackColor = System.Drawing.Color.Purple;
            this.btnAdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdds.Location = new System.Drawing.Point(30, 10);
            this.btnAdds.Name = "btnAdds";
            this.btnAdds.Size = new System.Drawing.Size(227, 100);
            this.btnAdds.TabIndex = 0;
            this.btnAdds.Text = "Kategori Kayıt\r\nÜrün Kayıt\r\nÇoklu Ürün Kayıt\r\nÜrün Kabul";
            this.btnAdds.UseVisualStyleBackColor = false;
            this.btnAdds.Click += new System.EventHandler(this.btnAdds_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 101);
            this.button2.TabIndex = 1;
            this.button2.Text = "Satış İşlemleri";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(30, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 101);
            this.button3.TabIndex = 2;
            this.button3.Text = "Rapor";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 402);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdds);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdds;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}