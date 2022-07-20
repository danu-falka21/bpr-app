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
    public partial class Angsuran : Form
    {

        List<AngsuranModel> angsur = new List<AngsuranModel>();
        List<PinjamanModel> pinjam = new List<PinjamanModel>();

        public Angsuran(int value)
        {
            InitializeComponent();
            LoadPeopleList(value);

           

        }
        private void LoadPeopleList(int value)
        {
            angsur = SqliteDataAccess.LoadAngsur(value);
            pinjam = SqliteDataAccess.LoadPinjam2(value);
            namaBox.Text = pinjam[0].nama;
            rekeningBox.Text = pinjam[0].rekening;
            alamatBox.Text = pinjam[0].alamat.ToString();
            bungaBox.Text = pinjam[0].bunga.ToString();
            waktuBox.Text = pinjam[0].jangka_waktu.ToString();
            totalBox.Text = pinjam[0].total_pinjaman.ToString();


            WireUpPeopleList();
        }


        private void WireUpPeopleList()
        {
            angsuranListBox.DataSource = null;
            angsuranListBox.DataSource = angsur.Select(o => new
            {
                Tanggal = o.tanggal,
                Keterangan = o.keterangan,
                Pokok = o.cicilan_pokok,
                Bunga = o.cicilan_bunga,
                Saldo = o.saldo,

                id = o.id,

            }).ToList(); ;


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
