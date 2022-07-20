namespace bpr_app
{
    partial class home
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
            this.label1 = new System.Windows.Forms.Label();
            this.DanaPinjamListBox = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DanaPinjamListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            // 
            // DanaPinjamListBox
            // 
            this.DanaPinjamListBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanaPinjamListBox.Location = new System.Drawing.Point(27, 75);
            this.DanaPinjamListBox.Name = "DanaPinjamListBox";
            this.DanaPinjamListBox.Size = new System.Drawing.Size(1074, 280);
            this.DanaPinjamListBox.TabIndex = 2;
            this.DanaPinjamListBox.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DanaPinjamListBox_CellPainting);
            this.DanaPinjamListBox.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DanaPinjamListBox_ColumnWidthChanged);
            this.DanaPinjamListBox.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DanaPinjamListBox_Scroll);
            this.DanaPinjamListBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DanaPinjamListBox_Paint);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DanaPinjamListBox);
            this.Controls.Add(this.label1);
            this.Name = "home";
            this.Size = new System.Drawing.Size(1132, 682);
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanaPinjamListBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DanaPinjamListBox;
    }
}
