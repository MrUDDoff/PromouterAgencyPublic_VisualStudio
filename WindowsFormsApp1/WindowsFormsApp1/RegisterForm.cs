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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void фамилияField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstField.Text != "" && nameField.Text != "" && lastField.Text != "" && telephoneField.Text != "" && telephoneField.Text.Length >= 11 && System.Text.RegularExpressions.Regex.IsMatch(telephoneField.Text, "[ ^ 0-9]") && telephoneField.Text != "" && passField.Text != "")
            {
                DB db = new DB();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand telephonecommand = new SqlCommand("select * from Пользователи where телефон = @UT", db.getConnection());
                telephonecommand.Parameters.Add("@UT", SqlDbType.VarChar).Value = telephoneField.Text;
                adapter.SelectCommand = telephonecommand;
                DataTable telephonetable = new DataTable();
                adapter.Fill(telephonetable);

                if (telephonetable.Rows.Count <= 0)
                {

                    SqlCommand command = new SqlCommand("insert Пользователи(Фамилия, Имя, Отчество, Телефон, Логин, Пароль, idРоль)values(@UF, @UN, @ULN, @UT, @UL, @UP, 3)", db.getConnection());
                    command.Parameters.Add("@UF", SqlDbType.VarChar).Value = firstField.Text;
                    command.Parameters.Add("@UN", SqlDbType.VarChar).Value = nameField.Text;
                    command.Parameters.Add("@ULN", SqlDbType.VarChar).Value = lastField.Text;
                    command.Parameters.Add("@UT", SqlDbType.VarChar).Value = telephoneField.Text;
                    command.Parameters.Add("@UL", SqlDbType.VarChar).Value = loginField.Text;
                    command.Parameters.Add("@UP", SqlDbType.VarChar).Value = passField.Text;
                    adapter.SelectCommand = command;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    MessageBox.Show("Регистрация успешна!");

                    this.Close();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Этот телефон уже зарегистрирован!");
                }
            }
            else
            {
                MessageBox.Show("Возникла ошибка! \n\nВаши поля пусты! \nЛибо номер телефона указан не полностью или содержит не только цифры!");
            }
        }
    }
}
