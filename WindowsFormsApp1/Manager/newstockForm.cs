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

namespace WindowsFormsApp1.Manager
{
    public partial class newstockForm : Form
    {
        public newstockForm()
        {
            InitializeComponent();
        }

        private void newstockForm_Activated(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable typestocktable = new DataTable();
            DataTable placetable = new DataTable();

            SqlCommand typestockcommand = new SqlCommand("SELECT * FROM ВидАкции", db.getConnection());
            adapter.SelectCommand = typestockcommand;
            adapter.Fill(typestocktable);
            typeField.DisplayMember = "наименованиеВида";
            typeField.ValueMember = "idВид";
            typeField.DataSource = typestocktable;
        }

        private void newstockButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable createstocktable = new DataTable();
            DataTable checknewstocktable = new DataTable();

            SqlCommand checknewstockcommand = new SqlCommand("SELECT * FROM Акции WHERE наименование = @NF AND idВид = @TF", db.getConnection());
            checknewstockcommand.Parameters.Add("@NF", SqlDbType.NVarChar).Value = nameField.Text;
            checknewstockcommand.Parameters.Add("@TF", SqlDbType.Int).Value = typeField.SelectedValue;
            adapter.SelectCommand = checknewstockcommand;          
            adapter.Fill(checknewstocktable);

            if (checknewstocktable.Rows.Count <= 0)
            {
                if (nameField.Text != "")
                {
                    SqlCommand command = new SqlCommand("INSERT Акции(наименование, limit, датаНач, датаКон, idВид, оплата)VALUES(@NF,@LF,@SD,@ED,@TF,@PF)", db.getConnection());
                    command.Parameters.Add("@NF", SqlDbType.NVarChar).Value = nameField.Text;
                    command.Parameters.Add("@LF", SqlDbType.Int).Value = limitField.Value;
                    command.Parameters.Add("@SD", SqlDbType.DateTime).Value = startDate.Value;
                    command.Parameters.Add("@ED", SqlDbType.DateTime).Value = endDate.Value;
                    command.Parameters.Add("@TF", SqlDbType.Int).Value = typeField.SelectedValue;
                    command.Parameters.Add("@PF", SqlDbType.Int).Value = paymentField.Value;
                    adapter.SelectCommand = command;
                    adapter.Fill(createstocktable);
                    this.Close();

                    DialogResult suredadd = MessageBox.Show("Вы хотите добавить места проведения для этой акции?\n\nЭто можно сделать позже.", "Места проведения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (suredadd == DialogResult.Yes)
                    {
                        placesForm placesform = new placesForm();
                        placesform.Owner = this;
                        placesform.ShowDialog();
                    }
                }
                else { MessageBox.Show("Название акции не может быть пустым!"); }
            }
            else { MessageBox.Show("Такая акция уже существует!"); }
        }
    }
}
