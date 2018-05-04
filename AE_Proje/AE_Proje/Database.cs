using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace yazilim_sinama_proje
{
    public class Database : IDisposable
    {
        private static SqlConnection bagla;
        private static string bagla_string= "Server= localhost; Database= demirbas; Integrated Security=True";

        public static SqlConnection Connect()
        {
            if (bagla == null)
            {
                bagla = new SqlConnection(bagla_string);
                bagla.Open();
            }
            return bagla;
        }
        public static void Disconnect()
        {
            bagla.Close();
            bagla = null;
        }

        public void Dispose()
        {
            Disconnect();
        }
    }
}
