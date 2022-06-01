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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(comboBoxRoles.SelectedValue);
            if (firstField.Text != "" && nameField.Text != "" && lastField.Text != "" && telephoneField.Text != "" && telephoneField.Text.Length >= 11 && System.Text.RegularExpressions.Regex.IsMatch(telephoneField.Text, "[ ^ 0-9]") && loginField.Text != "" && passField.Text != "")
            {
                DB db = new DB();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand telephonecommand = new SqlCommand("SELECT * FROM Пользователи WHERE телефон = @UT", db.getConnection());
                telephonecommand.Parameters.Add("@UT", SqlDbType.NVarChar).Value = telephoneField.Text;
                adapter.SelectCommand = telephonecommand;
                DataTable telephonetable = new DataTable();
                adapter.Fill(telephonetable);

                if (telephonetable.Rows.Count <= 0)
                {

                    SqlCommand command = new SqlCommand("INSERT Пользователи(Фамилия, Имя, Отчество, Телефон, Логин, Пароль, idРоль)VALUES(@UF, @UN, @ULN, @UT, @UL, @UP, @IR)", db.getConnection());
                    command.Parameters.Add("@UF", SqlDbType.NVarChar).Value = firstField.Text;
                    command.Parameters.Add("@UN", SqlDbType.NVarChar).Value = nameField.Text;
                    command.Parameters.Add("@ULN", SqlDbType.NVarChar).Value = lastField.Text;
                    command.Parameters.Add("@UT", SqlDbType.NVarChar).Value = telephoneField.Text;
                    command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = loginField.Text;
                    command.Parameters.Add("@UP", SqlDbType.NVarChar).Value = passField.Text;
                    command.Parameters.Add("@IR", SqlDbType.Int).Value = comboBoxRoles.SelectedValue;
                    adapter.SelectCommand = command;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    MessageBox.Show("Регистрация успешна!");

                    this.Close();
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Роли", db.getConnection());
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            comboBoxRoles.DisplayMember = "Название";
            comboBoxRoles.ValueMember = "idРоль";
            comboBoxRoles.DataSource = table;
        }
    }
}
