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
    public partial class editplacesForm : Form
    {
        public editplacesForm()
        {
            InitializeComponent();
        }

        private void editplacesForm_Load(object sender, EventArgs e)
        {
            managerForm managerform = (managerForm)this.Owner;
            DB db = new DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand findstockcommand = new SqlCommand("SELECT * FROM Проведение JOIN Место ON проведение.idМесто = место.idМесто WHERE idАкции = @SID", db.getConnection());
            findstockcommand.Parameters.Add("@SID", SqlDbType.Int).Value = managerform.clickedstockid;
            adapter.SelectCommand = findstockcommand;

            DataTable findstocktable = new DataTable();
            adapter.Fill(findstocktable);

            if (findstocktable.Rows.Count > 0)
            {
                foreach (DataRow row in findstocktable.Rows)
                {
                    listBoxplacesforstock.Items.Add(row.Field<String>("наименование"));
                }
            }
        }
        private void editplacesForm_Activated(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable placetable = new DataTable();

            SqlCommand placecommand = new SqlCommand("SELECT * FROM Место", db.getConnection());
            adapter.SelectCommand = placecommand;
            adapter.Fill(placetable);

            comboBoxplaces.DisplayMember = "наименование";
            comboBoxplaces.ValueMember = "idМесто";
            comboBoxplaces.DataSource = placetable;

            comboBoxplaces.DisplayMember = "наименование";
            comboBoxToAddPlaces.ValueMember = "наименование";
            comboBoxToAddPlaces.DataSource = placetable;
        }

        private void buttonAddPlace_Click(object sender, EventArgs e)
        {
            string selectedplace = comboBoxToAddPlaces.SelectedValue.ToString();
            if (listBoxplacesforstock.Items.Contains(selectedplace)) { MessageBox.Show("Такое место уже добавлено!"); } else { listBoxplacesforstock.Items.Add(selectedplace); }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable checkplacetable = new DataTable();
            DataTable newplacetable = new DataTable();

            SqlCommand checkplacecommand = new SqlCommand("SELECT * FROM Место WHERE наименование = @PN", db.getConnection());
            checkplacecommand.Parameters.Add("@PN", SqlDbType.NVarChar).Value = textBoxforaddplace.Text;
            adapter.SelectCommand = checkplacecommand;
            adapter.Fill(checkplacetable);

            if (checkplacetable.Rows.Count <= 0)
            {
                DialogResult suredadd = MessageBox.Show("Такого места ещё нет, создать новое?", "Место", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (suredadd == DialogResult.Yes)
                {
                    SqlCommand newplacecommand = new SqlCommand("INSERT Место(наименование)VALUES(@PN)", db.getConnection());
                    newplacecommand.Parameters.Add("@PN", SqlDbType.NVarChar).Value = textBoxforaddplace.Text;
                    adapter.SelectCommand = newplacecommand;
                    adapter.Fill(newplacetable);

                    MessageBox.Show("Новое место зарегистрировано!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            { MessageBox.Show("Такое наименование уже существует.", "Место", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (comboBoxplaces.Text != "")
            {
                DB db = new DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable checkplacetable = new DataTable();
                DataTable deleteplacetable = new DataTable();

                SqlCommand checkplacecommand = new SqlCommand("SELECT * FROM Место WHERE наименование = @PN", db.getConnection());
                checkplacecommand.Parameters.Add("@PN", SqlDbType.NVarChar).Value = comboBoxplaces.Text;
                adapter.SelectCommand = checkplacecommand;
                adapter.Fill(checkplacetable);

                if (checkplacetable.Rows.Count > 0)
                {
                    DialogResult suredadd = MessageBox.Show("Вы точно хотите удалить " + comboBoxplaces.Text + "?", "Место", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (suredadd == DialogResult.Yes)
                    {
                        SqlCommand deleteplacecommand = new SqlCommand("DELETE FROM Место WHERE наименование = @CBPT", db.getConnection());
                        deleteplacecommand.Parameters.Add("@CBPT", SqlDbType.NVarChar).Value = comboBoxplaces.Text;
                        adapter.SelectCommand = deleteplacecommand;
                        adapter.Fill(deleteplacetable);

                        listBoxplacesforstock.Items.Remove(comboBoxplaces.Text);

                        MessageBox.Show("Место удалено!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Такого места не существует.", "Место", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else { MessageBox.Show("Такого места не существует.", "Место", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Сначала выберите место"); }
        }

        private void listBoxplacesforstock_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxplacesforstock.Items.Count > 0)
            {
                DialogResult suredadd = MessageBox.Show("Вы точно хотите удалить " + listBoxplacesforstock.SelectedItem + "?", "Место", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (suredadd == DialogResult.Yes) { listBoxplacesforstock.Items.Remove(listBoxplacesforstock.SelectedItem); }
            }
        }

        private void buttonAddPlacesToStock_Click(object sender, EventArgs e)
        {
            managerForm managerform = (managerForm)this.Owner;

            DB db = new DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand deletestockcommand = new SqlCommand("DELETE FROM Проведение WHERE idАкции = @IDS", db.getConnection());
            deletestockcommand.Parameters.Add("@IDS", SqlDbType.Int).Value = managerform.clickedstockid;
            adapter.SelectCommand = deletestockcommand;
            DataTable deletestocktable = new DataTable();
            adapter.Fill(deletestocktable);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (object item in listBoxplacesforstock.Items)
            {
                sb.Append(item.ToString());

                SqlCommand command = new SqlCommand("SELECT * FROM Место WHERE наименование = @PN", db.getConnection());
                command.Parameters.Add("@PN", SqlDbType.NVarChar).Value = sb.ToString();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);

                int idPlace = table.Rows[0].Field<int>("idМесто");

                sb.Clear();
                table.Clear();

                SqlCommand newcommand = new SqlCommand("INSERT INTO Проведение(idМесто,idАкции)VALUES(@PN,@IS)", db.getConnection());
                newcommand.Parameters.Add("@PN", SqlDbType.Int).Value = idPlace;
                newcommand.Parameters.Add("@IS", SqlDbType.Int).Value = managerform.clickedstockid;
                adapter.SelectCommand = newcommand;
                DataTable atable = new DataTable();
                adapter.Fill(atable);
            }

            this.Close();
        }
    }
}
