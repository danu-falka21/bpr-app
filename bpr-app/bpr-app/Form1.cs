using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bpr_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetActivePanel(home1);
        }
        public void SetActivePanel(UserControl control)
        {
            // disable all user control
            home1.Visible = false;
            pinjam1.Visible = false;
            rekening1.Visible = false;
            nasabah1.Visible = false;

            //enable the active control
            control.Visible = true;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            SetActivePanel(home1);
        }

        private void btnpinjam_Click(object sender, EventArgs e)
        {
            SetActivePanel(pinjam1);
        }

        private void btnrekening_Click(object sender, EventArgs e)
        {
            SetActivePanel(rekening1);
        }

        private void btnnasabah_Click(object sender, EventArgs e)
        {
            SetActivePanel(nasabah1);
        }
    }
}
