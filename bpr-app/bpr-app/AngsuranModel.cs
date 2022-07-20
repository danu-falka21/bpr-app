using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bpr_app
{
    public class AngsuranModel
    {
        public int id { get; set; }
        public int id_pinjaman { get; set; }
        public string nama { get; set; }
        public string rekening { get; set; }
        public string alamat { get; set; }
        public int total_pinjaman { get; set; }
        public int bunga { get; set; }
        public int jangka_waktu { get; set; }
        public string tanggal { get; set; }
        public string keterangan { get; set; }
        public int cicilan_pokok { get; set; }
        public int cicilan_bunga { get; set; }

        public int saldo
        {
            get
            {
              
              return       total_pinjaman - cicilan_pokok;
               
            }
        }
    }
}
