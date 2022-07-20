using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bpr_app
{
    public  class DanaPinjamModel
    {
        public string nama { get; set; }
        public string rekening { get; set; }
        public string no_hp { get; set; }
        public string jenis_usaha { get; set; }
        public string alamat { get; set; }
        public int total_pinjaman { get; set; }
        public int wajib_CicilanPokok
        {
            get
            {
                return total_pinjaman + cicilan_pokok;
            }
        }
        public int wajib_CicilanBunga
        {
            get
            {
                return (total_pinjaman * bunga/100)*jangka_waktu - cicilan_bunga;
            }
        }
        public int wajib_Total
        {
            get
            {
                return wajib_CicilanPokok + wajib_CicilanBunga ;
            }
        }

        public int bunga { get; set; }
        public int jangka_waktu { get; set; }
        public string status { get; set; }
        public int cicilan_pokok { get; set; }
        public int cicilan_bunga { get; set; }
        public int Total
        {
            get
            {
                return cicilan_pokok + cicilan_bunga;
            }
        }


    }
}
