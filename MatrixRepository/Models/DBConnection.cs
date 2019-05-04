using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixRepository.Models
{
    public class DBConnection
    {
        public string StoredProcedure { get; set; }
        public string ConnectionString { get; set; } = "Data Source=matrixgraphapidbserver.database.windows.net;Initial Catalog=SaaramshaTech_db;User ID=SaaramshaUser;Password=Chaitra@12;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
