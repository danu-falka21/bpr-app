using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bpr_app
{
    public partial class nasabah : UserControl
    {
        List<NasabahModel> people = new List<NasabahModel>();

        public nasabah()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            people  = SqliteDataAccess.LoadNasabah();
            Console.WriteLine(people);

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            nasabahListBox.DataSource = null;
            nasabahListBox.DataSource = people;


        }


        private void tambahBtn_Click(object sender, EventArgs e)
        {

            NasabahModel p = new NasabahModel();

            p.nama = namaBox.Text;
            p.rekening = rekeningBox.Text;
            p.no_hp = teleponBox.Text;
            p.jenis_usaha = usahaBox.Text;
            p.alamat = alamatBox.Text;

            try
            {
                SqliteDataAccess.SaveNasabah(p);

                namaBox.Text = "";
                rekeningBox.Text = "";
                teleponBox.Text = "";
                usahaBox.Text = "";
                alamatBox.Text = "";

                LoadPeopleList();
            }
            catch
            {
                MessageBox.Show("cannot insert data","Error message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            
        }

        private void ubahBtn_Click(object sender, EventArgs e)
        {
            NasabahModel p = new NasabahModel();

            p.nama = namaBox.Text;
            p.rekening = rekeningBox.Text;
            p.no_hp = teleponBox.Text;
            p.jenis_usaha = usahaBox.Text;
            p.alamat = alamatBox.Text;

            try
            {
                SqliteDataAccess.UpdateNasabah(p);

                namaBox.Text = "";
                rekeningBox.Text = "";
                teleponBox.Text = "";
                usahaBox.Text = "";
                alamatBox.Text = "";

                LoadPeopleList();
            }
            catch
            {
                MessageBox.Show("cannot update data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("akan menghapus data", "info message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            NasabahModel p = new NasabahModel();

           
            p.rekening = rekeningBox.Text;

            try
            {
                SqliteDataAccess.DeleteNasabah(p);

                LoadPeopleList();
            }
            catch
            {
                MessageBox.Show("cannot Delete data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            

        }

   


        private void nasabahListBox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                nasabahListBox.CurrentRow.Selected = true;
                namaBox.Text = nasabahListBox.Rows[e.RowIndex].Cells["Nama"].FormattedValue.ToString();
                rekeningBox.Text = nasabahListBox.Rows[e.RowIndex].Cells["rekening"].FormattedValue.ToString();
                teleponBox.Text = nasabahListBox.Rows[e.RowIndex].Cells["no_hp"].FormattedValue.ToString();
                usahaBox.Text = nasabahListBox.Rows[e.RowIndex].Cells["jenis_usaha"].FormattedValue.ToString();
                alamatBox.Text = nasabahListBox.Rows[e.RowIndex].Cells["alamat"].FormattedValue.ToString();

            }
            else
            {
                Console.WriteLine("cannot select");
                return;
            }
        }

        private void nasabahListBox_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            nasabahListBox.Rows[e.RowIndex].HeaderCell.Value =(e.RowIndex+1).ToString() ;
        }
    }
}
