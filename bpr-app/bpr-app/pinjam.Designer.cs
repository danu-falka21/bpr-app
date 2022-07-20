namespace bpr_app
{
    partial class pinjam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pinjamListBox = new System.Windows.Forms.DataGridView();
            this.bungaBox = new System.Windows.Forms.TextBox();
            this.waktuBox = new System.Windows.Forms.TextBox();
            this.pinjamanBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.ubahBtn = new System.Windows.Forms.Button();
            this.tambahBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tanggalBox = new System.Windows.Forms.DateTimePicker();
            this.namaBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pinjamListBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pinjamListBox
            // 
            this.pinjamListBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pinjamListBox.Location = new System.Drawing.Point(14, 281);
            this.pinjamListBox.Name = "pinjamListBox";
            this.pinjamListBox.Size = new System.Drawing.Size(1080, 386);
            this.pinjamListBox.TabIndex = 0;
            this.pinjamListBox.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pinjamListBox_CellDoubleClick);
            this.pinjamListBox.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.pinjamListBox_CellFormatting);
            // 
            // bungaBox
            // 
            this.bungaBox.Location = new System.Drawing.Point(117, 192);
            this.bungaBox.Name = "bungaBox";
            this.bungaBox.Size = new System.Drawing.Size(283, 20);
            this.bungaBox.TabIndex = 33;
            this.bungaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bungaBox_KeyPress);
            // 
            // waktuBox
            // 
            this.waktuBox.Location = new System.Drawing.Point(117, 157);
            this.waktuBox.Name = "waktuBox";
            this.waktuBox.Size = new System.Drawing.Size(283, 20);
            this.waktuBox.TabIndex = 32;
            this.waktuBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.waktuBox_KeyPress);
            // 
            // pinjamanBox
            // 
            this.pinjamanBox.Location = new System.Drawing.Point(117, 121);
            this.pinjamanBox.Name = "pinjamanBox";
            this.pinjamanBox.Size = new System.Drawing.Size(283, 20);
            this.pinjamanBox.TabIndex = 31;
            this.pinjamanBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pinjamanBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tanggal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Bunga :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Jangka Waktu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total Pinjaman :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nama :";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(510, 89);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(87, 37);
            this.showBtn.TabIndex = 24;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.Location = new System.Drawing.Point(417, 140);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(87, 37);
            this.hapusBtn.TabIndex = 23;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = true;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // ubahBtn
            // 
            this.ubahBtn.Location = new System.Drawing.Point(603, 89);
            this.ubahBtn.Name = "ubahBtn";
            this.ubahBtn.Size = new System.Drawing.Size(87, 37);
            this.ubahBtn.TabIndex = 22;
            this.ubahBtn.Text = "Ubah";
            this.ubahBtn.UseVisualStyleBackColor = true;
            this.ubahBtn.Click += new System.EventHandler(this.ubahBtn_Click);
            // 
            // tambahBtn
            // 
            this.tambahBtn.Location = new System.Drawing.Point(417, 89);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(87, 37);
            this.tambahBtn.TabIndex = 21;
            this.tambahBtn.Text = "Tambah";
            this.tambahBtn.UseVisualStyleBackColor = true;
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tabungan Rencana";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(462, 51);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(283, 20);
            this.statusBox.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Status :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1019, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(708, 211);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(294, 20);
            this.textBox7.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tanggalBox);
            this.panel1.Controls.Add(this.namaBox);
            this.panel1.Controls.Add(this.pinjamListBox);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.statusBox);
            this.panel1.Controls.Add(this.tambahBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ubahBtn);
            this.panel1.Controls.Add(this.hapusBtn);
            this.panel1.Controls.Add(this.bungaBox);
            this.panel1.Controls.Add(this.showBtn);
            this.panel1.Controls.Add(this.waktuBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pinjamanBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 682);
            this.panel1.TabIndex = 39;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(117, 55);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(50, 20);
            this.idBox.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "ID :";
            // 
            // tanggalBox
            // 
            this.tanggalBox.Location = new System.Drawing.Point(117, 229);
            this.tanggalBox.Name = "tanggalBox";
            this.tanggalBox.Size = new System.Drawing.Size(283, 20);
            this.tanggalBox.TabIndex = 40;
            // 
            // namaBox
            // 
            this.namaBox.FormattingEnabled = true;
            this.namaBox.Location = new System.Drawing.Point(117, 85);
            this.namaBox.Name = "namaBox";
            this.namaBox.Size = new System.Drawing.Size(283, 21);
            this.namaBox.TabIndex = 39;
            this.namaBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pinjam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "pinjam";
            this.Size = new System.Drawing.Size(1132, 682);
            this.Load += new System.EventHandler(this.pinjam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pinjamListBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pinjamListBox;
        private System.Windows.Forms.TextBox bungaBox;
        private System.Windows.Forms.TextBox waktuBox;
        private System.Windows.Forms.TextBox pinjamanBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.Button ubahBtn;
        private System.Windows.Forms.Button tambahBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox namaBox;
        private System.Windows.Forms.DateTimePicker tanggalBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idBox;
    }
}
