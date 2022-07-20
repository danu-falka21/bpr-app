namespace bpr_app
{
    partial class Angsuran
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
            this.namaBox = new System.Windows.Forms.TextBox();
            this.rekeningBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.angsuranListBox = new System.Windows.Forms.DataGridView();
            this.alamatBox = new System.Windows.Forms.TextBox();
            this.waktuBox = new System.Windows.Forms.TextBox();
            this.bungaBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.angsuranListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rekening";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Pinjaman";
            // 
            // namaBox
            // 
            this.namaBox.Location = new System.Drawing.Point(127, 32);
            this.namaBox.Name = "namaBox";
            this.namaBox.ReadOnly = true;
            this.namaBox.Size = new System.Drawing.Size(120, 20);
            this.namaBox.TabIndex = 3;
            // 
            // rekeningBox
            // 
            this.rekeningBox.Location = new System.Drawing.Point(127, 62);
            this.rekeningBox.Name = "rekeningBox";
            this.rekeningBox.ReadOnly = true;
            this.rekeningBox.Size = new System.Drawing.Size(120, 20);
            this.rekeningBox.TabIndex = 4;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(127, 179);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(120, 20);
            this.totalBox.TabIndex = 5;
            // 
            // angsuranListBox
            // 
            this.angsuranListBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.angsuranListBox.Location = new System.Drawing.Point(293, 22);
            this.angsuranListBox.Name = "angsuranListBox";
            this.angsuranListBox.Size = new System.Drawing.Size(373, 444);
            this.angsuranListBox.TabIndex = 6;
            this.angsuranListBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // alamatBox
            // 
            this.alamatBox.Location = new System.Drawing.Point(127, 93);
            this.alamatBox.Name = "alamatBox";
            this.alamatBox.ReadOnly = true;
            this.alamatBox.Size = new System.Drawing.Size(120, 20);
            this.alamatBox.TabIndex = 12;
            // 
            // waktuBox
            // 
            this.waktuBox.Location = new System.Drawing.Point(127, 153);
            this.waktuBox.Name = "waktuBox";
            this.waktuBox.ReadOnly = true;
            this.waktuBox.Size = new System.Drawing.Size(120, 20);
            this.waktuBox.TabIndex = 11;
            // 
            // bungaBox
            // 
            this.bungaBox.Location = new System.Drawing.Point(127, 123);
            this.bungaBox.Name = "bungaBox";
            this.bungaBox.ReadOnly = true;
            this.bungaBox.Size = new System.Drawing.Size(120, 20);
            this.bungaBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jangka Waktu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bunga";
            // 
            // Angsuran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 534);
            this.Controls.Add(this.alamatBox);
            this.Controls.Add(this.waktuBox);
            this.Controls.Add(this.bungaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.angsuranListBox);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.rekeningBox);
            this.Controls.Add(this.namaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Angsuran";
            this.Text = "Angsuran";
            ((System.ComponentModel.ISupportInitialize)(this.angsuranListBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namaBox;
        private System.Windows.Forms.TextBox rekeningBox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.DataGridView angsuranListBox;
        private System.Windows.Forms.TextBox alamatBox;
        private System.Windows.Forms.TextBox waktuBox;
        private System.Windows.Forms.TextBox bungaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}