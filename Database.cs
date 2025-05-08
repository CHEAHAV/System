using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Systems
{
    public class Database
    {
        string str = "Data Source=MSI\\DBMS;Initial Catalog=M6Y3;Integrated Security=True";
        public SqlConnection con;

        public void SystemConnection()
        { 
            SqlDependency.Stop(str);
            SqlDependency.Start(str);
            con = new SqlConnection(str);
            con.Open();
        }
    }
}
