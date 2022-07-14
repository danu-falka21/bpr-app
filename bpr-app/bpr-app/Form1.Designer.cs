namespace bpr_app
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnasabah = new System.Windows.Forms.Button();
            this.btnrekening = new System.Windows.Forms.Button();
            this.btnpinjam = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rekening1 = new bpr_app.rekening();
            this.pinjam1 = new bpr_app.pinjam();
            this.nasabah1 = new bpr_app.nasabah();
            this.home1 = new bpr_app.home();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.btnnasabah);
            this.panel1.Controls.Add(this.btnrekening);
            this.panel1.Controls.Add(this.btnpinjam);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 682);
            this.panel1.TabIndex = 0;
            // 
            // btnnasabah
            // 
            this.btnnasabah.Location = new System.Drawing.Point(3, 235);
            this.btnnasabah.Name = "btnnasabah";
            this.btnnasabah.Size = new System.Drawing.Size(167, 46);
            this.btnnasabah.TabIndex = 3;
            this.btnnasabah.Text = "Nasabah";
            this.btnnasabah.UseVisualStyleBackColor = true;
            this.btnnasabah.Click += new System.EventHandler(this.btnnasabah_Click);
            // 
            // btnrekening
            // 
            this.btnrekening.Location = new System.Drawing.Point(3, 183);
            this.btnrekening.Name = "btnrekening";
            this.btnrekening.Size = new System.Drawing.Size(167, 46);
            this.btnrekening.TabIndex = 2;
            this.btnrekening.Text = "Rekening";
            this.btnrekening.UseVisualStyleBackColor = true;
            this.btnrekening.Click += new System.EventHandler(this.btnrekening_Click);
            // 
            // btnpinjam
            // 
            this.btnpinjam.Location = new System.Drawing.Point(3, 131);
            this.btnpinjam.Name = "btnpinjam";
            this.btnpinjam.Size = new System.Drawing.Size(167, 46);
            this.btnpinjam.TabIndex = 1;
            this.btnpinjam.Text = "Pinjaman";
            this.btnpinjam.UseVisualStyleBackColor = true;
            this.btnpinjam.Click += new System.EventHandler(this.btnpinjam_Click);
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(3, 79);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(167, 46);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.rekening1);
            this.panel2.Controls.Add(this.pinjam1);
            this.panel2.Controls.Add(this.nasabah1);
            this.panel2.Controls.Add(this.home1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(176, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 682);
            this.panel2.TabIndex = 1;
            // 
            // rekening1
            // 
            this.rekening1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rekening1.Location = new System.Drawing.Point(0, 0);
            this.rekening1.Name = "rekening1";
            this.rekening1.Size = new System.Drawing.Size(1132, 682);
            this.rekening1.TabIndex = 3;
            // 
            // pinjam1
            // 
            this.pinjam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pinjam1.Location = new System.Drawing.Point(0, 0);
            this.pinjam1.Name = "pinjam1";
            this.pinjam1.Size = new System.Drawing.Size(1132, 682);
            this.pinjam1.TabIndex = 2;
            // 
            // nasabah1
            // 
            this.nasabah1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nasabah1.Location = new System.Drawing.Point(0, 0);
            this.nasabah1.Name = "nasabah1";
            this.nasabah1.Size = new System.Drawing.Size(1132, 682);
            this.nasabah1.TabIndex = 1;
            // 
            // home1
            // 
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1132, 682);
            this.home1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnrekening;
        private System.Windows.Forms.Button btnpinjam;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnnasabah;
        private home home1;
        private rekening rekening1;
        private pinjam pinjam1;
        private nasabah nasabah1;
    }
}

