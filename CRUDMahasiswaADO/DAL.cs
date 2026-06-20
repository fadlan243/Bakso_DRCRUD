using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{

    internal class DAL
    {
        static string connectionString = "Data Source=FADLANNASRIZAL\\FADLAN;Initial Catalog=DBAkademikADO;Integrated Security=True";

        public string GetConnectionString()
        {
            string connectionString = "Data Source=.;Initial Catalog=DBAkademikADO;Integrated Security=True;TrustServerCertificate=True";
            return connectionString;
        }

        
    }
}
