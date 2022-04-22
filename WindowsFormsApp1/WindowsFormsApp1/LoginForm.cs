using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("select * from Пользователи where логин = @UL and пароль = @P", db.getConnection());
            command.Parameters.Add("@UL", SqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@P", SqlDbType.VarChar).Value = passField.Text;
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);

            if(table.Rows.Count>0)
            {
                if (table.Rows[0].Field<int>("idРоль") == 1)
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                if (table.Rows[0].Field<int>("idРоль") == 2)
                {
                    this.Hide();
                    Formmod formmod = new Formmod();
                    formmod.Show();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Green;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
