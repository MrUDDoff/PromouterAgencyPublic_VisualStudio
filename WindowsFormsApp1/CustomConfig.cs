using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class CustomConfig
    {
        public void checkVersion(int versionProgramm)
        {
            DB db = new DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM configProgramm WHERE version = @VP", db.getConnection());
            command.Parameters.Add("@VP", SqlDbType.Int).Value = versionProgramm;
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ваша версия программы устарела!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(1);
            }
        }
        public void checkdbregisteron(int registeron)
        {
            DB db = new DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM configProgramm WHERE registeron = 1", db.getConnection());
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return;
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
