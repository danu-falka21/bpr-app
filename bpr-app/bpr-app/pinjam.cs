using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bpr_app
{
    public partial class pinjam : UserControl
    {
        List<PinjamanModel> people = new List<PinjamanModel>();
        List<NasabahModel> nasabah = new List<NasabahModel>();
        List<AngsuranModel> angsur = new List<AngsuranModel>();

        public pinjam()
        {
            InitializeComponent();
            LoadPeopleList();
        }
        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadPinjam();
            nasabah = SqliteDataAccess.LoadNasabah();


            WireUpPeopleList();
        }
       

        private void WireUpPeopleList()
        {
            pinjamListBox.DataSource = null;
            pinjamListBox.DataSource = people.Select(o => new
            {
                Nama = o.nama,
                Rekening = o.rekening,
                Telepon = o.no_hp,
                Usaha = o.jenis_usaha,
                Alamat = o.alamat,
                Total_Pinjaman = o.total_pinjaman,
                Bunga = o.bunga,
                Jangka_Waktu = o.jangka_waktu,
                Tanggal = o.tanggal,
                Status = o.status,
                id_pinjaman = o.id,
                iduser = o.id_user,
            }).ToList();

            pinjamListBox.Columns["id_pinjaman"].Visible = false;
            pinjamListBox.Columns["iduser"].Visible =false;


        }

        private void pinjam_Load(object sender, EventArgs e)
        {
            namaBox.DataSource = nasabah.Select(o => new
            {
                reknama = o.rekname,
                
                idUser = o.id,

            }).ToList();
            namaBox.DisplayMember = "reknama";
            namaBox.ValueMember = "idUser";
            namaBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            namaBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void pinjamanBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void waktuBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void bungaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void pinjamListBox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pinjamListBox.CurrentRow.Selected = true;
                idBox.Text = pinjamListBox.Rows[e.RowIndex].Cells["id_pinjaman"].FormattedValue.ToString();
                namaBox.SelectedValue = Convert.ToInt32(pinjamListBox.Rows[e.RowIndex].Cells["iduser"].FormattedValue);
                pinjamanBox.Text = pinjamListBox.Rows[e.RowIndex].Cells["Total_Pinjaman"].FormattedValue.ToString();
                waktuBox.Text = pinjamListBox.Rows[e.RowIndex].Cells["Jangka_Waktu"].FormattedValue.ToString();
                bungaBox.Text = pinjamListBox.Rows[e.RowIndex].Cells["Bunga"].FormattedValue.ToString();
                tanggalBox.Text = pinjamListBox.Rows[e.RowIndex].Cells["Tanggal"].FormattedValue.ToString();
                statusBox.Text = pinjamListBox.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();



            }
            else
            {
                Console.WriteLine("cannot select");
                return;
            }
        }

        private void pinjamListBox_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            pinjamListBox.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            PinjamanModel p = new PinjamanModel();

            p.id_user = Convert.ToInt32(namaBox.SelectedValue.ToString());
            p.total_pinjaman = Convert.ToInt32(pinjamanBox.Text);
            p.jangka_waktu = Convert.ToInt32(waktuBox.Text);
            p.bunga = Convert.ToInt32(bungaBox.Text);
            p.tanggal = tanggalBox.Text;
            p.status = statusBox.Text;

           
                SqliteDataAccess.SavePinjam(p);

                namaBox.Text = "";
                pinjamanBox.Text = "";
                waktuBox.Text = "";
                bungaBox.Text = "";
                tanggalBox.Text = "";
                statusBox.Text = "";

                LoadPeopleList();
           
        }


        private void ubahBtn_Click(object sender, EventArgs e)
        {
            PinjamanModel p = new PinjamanModel();

            p.id = Convert.ToInt32(idBox.Text);
            p.id_user = Convert.ToInt32(namaBox.SelectedValue.ToString());
            p.total_pinjaman = Convert.ToInt32(pinjamanBox.Text);
            p.jangka_waktu = Convert.ToInt32(waktuBox.Text);
            p.bunga = Convert.ToInt32(bungaBox.Text);
            p.tanggal = tanggalBox.Text;
            p.status = statusBox.Text;


            SqliteDataAccess.UpdatePinjam(p);

            idBox.Text = "";
            namaBox.Text = "";
            pinjamanBox.Text = "";
            waktuBox.Text = "";
            bungaBox.Text = "";
            tanggalBox.Text = "";
            statusBox.Text = "";

            LoadPeopleList();
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("akan menghapus data", "info message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            PinjamanModel p = new PinjamanModel();


            p.id = Convert.ToInt32(idBox.Text);

            try
            {
                SqliteDataAccess.DeletePinjam(p);

                idBox.Text = "";
                namaBox.Text = "";
                pinjamanBox.Text = "";
                waktuBox.Text = "";
                bungaBox.Text = "";
                tanggalBox.Text = "";
                statusBox.Text = "";

                LoadPeopleList();
            }
            catch
            {
                MessageBox.Show("cannot Delete data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            

            Angsuran frm = new Angsuran(Convert.ToInt32(idBox.Text));
            frm.ShowDialog();

        }
    }
}
