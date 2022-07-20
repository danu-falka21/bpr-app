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
    public partial class home : UserControl
    {
        List<DanaPinjamModel> people = new List<DanaPinjamModel>();

        public home()
        {
            InitializeComponent();
            LoadPeopleList();
        }
        private void home_Load(object sender, EventArgs e)
        {
            DanaPinjamListBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DanaPinjamListBox.ColumnHeadersHeight = DanaPinjamListBox.ColumnHeadersHeight * 2;
            DanaPinjamListBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DanaPinjamListBox.ColumnHeadersDefaultCellStyle.Alignment =DataGridViewContentAlignment.BottomCenter ;
            DanaPinjamListBox.CellPainting += new DataGridViewCellPaintingEventHandler(DanaPinjamListBox_CellPainting);
            DanaPinjamListBox.Paint += new PaintEventHandler(DanaPinjamListBox_Paint);
            DanaPinjamListBox.Scroll += new ScrollEventHandler(DanaPinjamListBox_Scroll);
            DanaPinjamListBox.ColumnWidthChanged += new DataGridViewColumnEventHandler(DanaPinjamListBox_ColumnWidthChanged);

        }
        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadDanaPinjam();


            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            DanaPinjamListBox.DataSource = null;
            DanaPinjamListBox.DataSource = people.Select(o => new
            {
                Nama = o.nama,
                Rekening = o.rekening,
                Telepon = o.no_hp,
                Usaha = o.jenis_usaha,
                Total_Pinjaman = o.total_pinjaman,
                Cicilan_Pokok = o.wajib_CicilanPokok,
                Cicilan_Bunga = o.wajib_CicilanBunga,
                Total = o.wajib_Total,
                Cicilan_Pokok1 = o.cicilan_pokok,
                Cicilan_Bunga2 = o.cicilan_bunga,
                Total2 = o.Total,
            }).ToList(); ; ;


        }

        private void DanaPinjamListBox_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r1 = DanaPinjamListBox.GetCellDisplayRectangle(5, -1, true);
            int w2 = DanaPinjamListBox.GetCellDisplayRectangle(6,-1,true).Width;
            int w3 = DanaPinjamListBox.GetCellDisplayRectangle(7, -1, true).Width;
            r1.X += 1;
            r1.Y += 1;
            r1.Width = r1.Width + w2 + w3 - 2;
            r1.Height = r1.Height/ 2 - 2;
            e.Graphics.FillRectangle(new SolidBrush(DanaPinjamListBox.ColumnHeadersDefaultCellStyle.BackColor), r1);

            StringFormat format = new StringFormat();

            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(" Kewajiban Yang harus dibayar", DanaPinjamListBox.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(DanaPinjamListBox.ColumnHeadersDefaultCellStyle.ForeColor), r1, format);

        }

        private void DanaPinjamListBox_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtheader = DanaPinjamListBox.DisplayRectangle;
            rtheader.Height = DanaPinjamListBox.ColumnHeadersHeight / 2;
            DanaPinjamListBox.Invalidate(rtheader);
        }

        private void DanaPinjamListBox_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtheader = DanaPinjamListBox.DisplayRectangle;
            rtheader.Height = DanaPinjamListBox.ColumnHeadersHeight / 2;
            DanaPinjamListBox.Invalidate(rtheader);
        }

        private void DanaPinjamListBox_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle r2 = e.CellBounds;
                r2.Y += e.CellBounds.Height/2;
                r2.Height = e.CellBounds.Height / 2;
                e.PaintBackground(r2, true);
                e.PaintContent(r2);
                e.Handled = true;

            }
        }
    }
}
