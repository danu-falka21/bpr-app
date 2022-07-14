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
                cnn.Execute("update nasabah set nama= @nama, no_hp=@no_hp, jenis_usaha=@jenis_usaha, alamat=@alamat where  rekening= @rekening", nasabah);
            }

        }
        public static void DeleteNasabah(NasabahModel nasabah)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from nasabah where rekening= @rekening", nasabah);
            }

        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
