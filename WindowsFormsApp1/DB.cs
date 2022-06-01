using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DB
    {
        SqlConnection connection = new SqlConnection("workstation id=akciitexnikum.mssql.somee.com;packet size=4096;user id=MrUDDoff;pwd=******;data source=akciitexnikum.mssql.somee.com;persist security info=False;initial catalog=akciitexnikum");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
