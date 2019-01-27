namespace Market.WFA.Rapor
{
    partial class Rapor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpTarihSec = new System.Windows.Forms.DateTimePicker();
            this.btnYillik = new System.Windows.Forms.Button();
            this.btnAylik = new System.Windows.Forms.Button();
            this.btnHaftalik = new System.Windows.Forms.Button();
            this.btnGunluk = new System.Windows.Forms.Button();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dtpTarihSec
            // 
            this.dtpTarihSec.Location = new System.Drawing.Point(417, 12);
            this.dtpTarihSec.Name = "dtpTarihSec";
            this.dtpTarihSec.Size = new System.Drawing.Size(200, 20);
            this.dtpTarihSec.TabIndex = 11;
            // 
            // btnYillik
            // 
            this.btnYillik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYillik.Location = new System.Drawing.Point(298, 7);
            this.btnYillik.Name = "btnYillik";
            this.btnYillik.Size = new System.Drawing.Size(99, 34);
            this.btnYillik.TabIndex = 10;
            this.btnYillik.Text = "Yıllık";
            this.btnYillik.UseVisualStyleBackColor = true;
            // 
            // btnAylik
            // 
            this.btnAylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAylik.Location = new System.Drawing.Point(193, 7);
            this.btnAylik.Name = "btnAylik";
            this.btnAylik.Size = new System.Drawing.Size(99, 34);
            this.btnAylik.TabIndex = 9;
            this.btnAylik.Text = "Aylık";
            this.btnAylik.UseVisualStyleBackColor = true;
            // 
            // btnHaftalik
            // 
            this.btnHaftalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHaftalik.Location = new System.Drawing.Point(88, 7);
            this.btnHaftalik.Name = "btnHaftalik";
            this.btnHaftalik.Size = new System.Drawing.Size(99, 34);
            this.btnHaftalik.TabIndex = 8;
            this.btnHaftalik.Text = "Haftalık";
            this.btnHaftalik.UseVisualStyleBackColor = true;
            // 
            // btnGunluk
            // 
            this.btnGunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunluk.Location = new System.Drawing.Point(-17, 7);
            this.btnGunluk.Name = "btnGunluk";
            this.btnGunluk.Size = new System.Drawing.Size(99, 34);
            this.btnGunluk.TabIndex = 7;
            this.btnGunluk.Text = "Günlük";
            this.btnGunluk.UseVisualStyleBackColor = true;
            this.btnGunluk.Click += new System.EventHandler(this.btnGunluk_Click);
            // 
            // dgvRapor
            // 
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRapor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRapor.Location = new System.Drawing.Point(-26, 50);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.Size = new System.Drawing.Size(985, 438);
            this.dgvRapor.TabIndex = 6;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(933, 494);
            this.Controls.Add(this.dtpTarihSec);
            this.Controls.Add(this.btnYillik);
            this.Controls.Add(this.btnAylik);
            this.Controls.Add(this.btnHaftalik);
            this.Controls.Add(this.btnGunluk);
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpTarihSec;
        private System.Windows.Forms.Button btnYillik;
        private System.Windows.Forms.Button btnAylik;
        private System.Windows.Forms.Button btnHaftalik;
        private System.Windows.Forms.Button btnGunluk;
        private System.Windows.Forms.DataGridView dgvRapor;
    }
}