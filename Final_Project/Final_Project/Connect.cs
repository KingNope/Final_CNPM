using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Final_Project
{
    class Connect
    {
        private SqlConnection sqlConnection;
        public Connect()
        {
           sqlConnection = new SqlConnection(@"Data Source=LAPTOP-HA348VVB\SQLEXPRESS;Initial Catalog=db_project;Integrated Security=True");
        }
        
        public SqlConnection sqlconnection
        {
            get { return sqlConnection; }
        }
    }
}
