using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bpr_app
{
    public class SqliteDataAccess
    {
        public static List<NasabahModel> LoadNasabah()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<NasabahModel>("select * from nasabah", new DynamicParameters());
                return output.ToList();
            }

        }
        public static void SaveNasabah(NasabahModel nasabah)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into nasabah (nama, rekening, no_hp, jenis_usaha, alamat) values (@nama, @rekening, @no_hp, @jenis_usaha, @alamat)",nasabah);
            }

        }
        public static void UpdateNasabah(NasabahModel nasabah)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update nasabah set nama= @nama, no_hp=@no_hp, jenis_usaha=@jenis_usaha, alamat=@alamat where  id= @id", nasabah);
            }

        }
        public static void DeleteNasabah(NasabahModel nasabah)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from nasabah where id= @id", nasabah);
            }

        }

        public static List<DanaPinjamModel> LoadDanaPinjam()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<DanaPinjamModel>("SELECT nasabah.nama, nasabah.rekening, nasabah.no_hp, nasabah.jenis_usaha, nasabah.alamat, pinjaman.total_pinjaman, pinjaman.bunga, pinjaman.jangka_waktu, pinjaman.status, Sum(angsuran.cicilan_pokok) AS cicilan_pokok, Sum(angsuran.cicilan_bunga) AS cicilan_bunga FROM nasabah INNER JOIN pinjaman ON pinjaman.id_user = nasabah.id INNER JOIN angsuran ON angsuran.id_pinjaman = pinjaman.id GROUP BY nasabah.nama, nasabah.rekening, nasabah.no_hp, nasabah.jenis_usaha, nasabah.alamat, pinjaman.total_pinjaman, pinjaman.bunga, pinjaman.jangka_waktu, pinjaman.status", new DynamicParameters());
                return output.ToList();
            }

        }
        public static List<PinjamanModel> LoadPinjam()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PinjamanModel>("SELECT pinjaman.id,pinjaman.id_user, nasabah.nama, nasabah.rekening, nasabah.no_hp, nasabah.jenis_usaha, nasabah.alamat, pinjaman.total_pinjaman, pinjaman.bunga, pinjaman.jangka_waktu, pinjaman.tanggal, pinjaman.status FROM nasabah INNER JOIN pinjaman ON pinjaman.id_user = nasabah.id", new DynamicParameters());
                return output.ToList();
            }

        }
        public static void SavePinjam(PinjamanModel nasabah)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into pinjaman (id_user, total_pinjaman, bunga, jangka_waktu, tanggal, status) values (@id_user, @total_pinjaman, @bunga, @jangka_waktu, @tanggal, @status)", nasabah);
            }

        }
        public static void UpdatePinjam(PinjamanModel nasabah)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update pinjaman set id_user= @id_user, total_pinjaman= @total_pinjaman, bunga=@bunga, jangka_waktu=@jangka_waktu, tanggal= @tanggal, status= @status where  id= @id", nasabah);
            }

        }
        public static void DeletePinjam(PinjamanModel nasabah)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from pinjaman where id= @id", nasabah);
            }

        }
        public static List<AngsuranModel> LoadAngsur(int num)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@id_pinjaman", num);
                var output = cnn.Query<AngsuranModel>("SELECT angsuran.id, angsuran.id_pinjaman, angsuran.tanggal, angsuran.keterangan, angsuran.cicilan_pokok, angsuran.cicilan_bunga, pinjaman.id_user, pinjaman.total_pinjaman, pinjaman.bunga, pinjaman.jangka_waktu, nasabah.nama, nasabah.rekening, nasabah.alamat FROM angsuran INNER JOIN pinjaman ON angsuran.id_pinjaman = pinjaman.id INNER JOIN nasabah ON pinjaman.id_user = nasabah.id WHERE angsuran.id_pinjaman = @id_pinjaman", p);
                return output.ToList();
            }

        }
        public static List<PinjamanModel> LoadPinjam2(int num)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@id", num);
                var output = cnn.Query<PinjamanModel>("SELECT pinjaman.id, pinjaman.id_user, nasabah.nama, nasabah.rekening, nasabah.no_hp, nasabah.jenis_usaha, nasabah.alamat, pinjaman.total_pinjaman, pinjaman.bunga, pinjaman.jangka_waktu, pinjaman.tanggal, pinjaman.status FROM nasabah INNER JOIN pinjaman ON pinjaman.id = @id", p);
                return output.ToList();
            }

        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
