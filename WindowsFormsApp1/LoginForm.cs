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
        public LoginForm(int registeron)
        {
            InitializeComponent();

            if (registeron == 0)
            {
                registerbutton.Visible = false;
            }
        }

        public int idUser = 0;
        //В техникуме public statue string idUser;

        public void loginButton_Click(object sender, EventArgs e)
        {
            //loginField.Text = passField.Text = "test";

            if (loginField.Text != "" && passField.Text != "")
            {
                DB db = new DB();

                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand("SELECT * FROM Пользователи WHERE логин = @UL and пароль = @UP", db.getConnection());
                command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = loginField.Text;
                command.Parameters.Add("@UP", SqlDbType.NVarChar).Value = passField.Text;
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    idUser = table.Rows[0].Field<int>("idПользователя");

                    if (table.Rows[0].Field<int>("idРоль") == 1)
                    {
                        this.Hide();
                        adminForm adminform = new adminForm();
                        adminform.Show();
                    }
                    if (table.Rows[0].Field<int>("idРоль") == 2)
                    {
                        this.Hide();
                        managerForm managerform = new managerForm();
                        managerform.Show();
                    }
                    if (table.Rows[0].Field<int>("idРоль") == 3)
                    {
                        this.Hide();
                        supervaisorForm supervaisorform = new supervaisorForm();
                        supervaisorform.Owner = this;
                        supervaisorform.Show();
                    }
                    if (table.Rows[0].Field<int>("idРоль") == 4)
                    {
                        this.Hide();
                        promouterForm promouterform = new promouterForm();
                        promouterform.Owner = this;
                        promouterform.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует!");
                }
            }
            else
            {
                MessageBox.Show("Ваши поля пусты!");
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

        private void registerbutton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
