using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Crypto.Engines;

namespace desktop_cshap.models
{
    internal class SensionUser
    {
       
        public int idpetugas { get; set; }
        public string username { get; set; }
        public string namapetugas { get; set; }
        public string level { get; set; }
        public string IsLoggedIn { get; set; }


        public static void SetSession(int idpetugas, string username, string nama, string level,string IsLoggeredIn)
        {

        }

        public static void ClearSession()
        {
           
        }



    }
}
