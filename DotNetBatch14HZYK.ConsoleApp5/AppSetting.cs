using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch14HZYK.ConsoleApp5
{
    internal class AppSettings
    {

        public static SqlConnectionStringBuilder SqlConnectionStringBuilder { get; } = new SqlConnectionStringBuilder()
        {
            DataSource = "LAPTOP-MMRAUNPQ",
            InitialCatalog = "TextDb",
            UserID = "sa",
            Password = "Hlay1082001",
            TrustServerCertificate = true
        };

    }
}
