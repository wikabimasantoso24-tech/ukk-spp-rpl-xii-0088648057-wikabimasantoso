using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace desktop_cshap.config
{
    internal class koneksi
    {
        public static MySqlConnection GetConnection()
        {
              string konfig = "server=localhost;username=root;password=;database=db_pp_sekolah_xii";
        MySqlConnection koneksi = new MySqlConnection(konfig);
            return koneksi;
        }
      
    }
}
