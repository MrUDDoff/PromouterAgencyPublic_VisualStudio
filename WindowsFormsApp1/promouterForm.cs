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
    public partial class promouterForm : Form
    {

        public promouterForm()
        {
            InitializeComponent();
        }

        private void promouterForm_Load(object sender, EventArgs e)
        {
            LoginForm loginform = (LoginForm)this.Owner;
            int idUser = loginform.idUser;

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable typestocktable = new DataTable();
            DataTable placestocktable = new DataTable();

            //Type Data
            SqlCommand typesstockcommand = new SqlCommand("SELECT * FROM ВидАкции", db.getConnection());
            adapter.SelectCommand = typesstockcommand;
            adapter.Fill(typestocktable);
            comboBoxTypeStock.Items.Add("Все типы акций");
            foreach (DataRow row in typestocktable.Rows)
            {
                comboBoxTypeStock.Items.Add(row.Field<String>("наименованиеВида"));
            }

            //Place Data
            SqlCommand placesstockcommand = new SqlCommand("SELECT * FROM Место", db.getConnection());
            adapter.SelectCommand = placesstockcommand;
            adapter.Fill(placestocktable);
            comboBoxPlace.Items.Add("Все места проведения");
            foreach (DataRow row in placestocktable.Rows)
            {
                comboBoxPlace.Items.Add(row.Field<String>("наименование"));
            }

            //Status Data
            comboBoxStatus.Items.Add("Все акции");
            comboBoxStatus.Items.Add("Активные");
            comboBoxStatus.Items.Add("Неактивные");
        }

        public void promouterForm_Activated(object sender, EventArgs e)
        {

            // Variables and Anonunce

            LoginForm loginform = (LoginForm)this.Owner;

            int idUser = loginform.idUser;
            DateTime thisDay = DateTime.Today;

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable finetable = new DataTable();
            DataTable finenulltable = new DataTable();
            DataTable stocktable = new DataTable();
            DataTable mystocktable = new DataTable();

            //MAIN PAGE

            idField.Text = idUser.ToString();
            dataLabel.Text = "Дата: " + thisDay.ToString("D");

            //STOCK DATA

            SqlCommand stockcommand = new SqlCommand("SELECT Акции.idАкции AS 'Номер акции', Акции.наименование AS Название, датаНач AS 'Дата начала', датаКон AS 'Дата конца', ВидАкции.наименованиеВида AS 'Тип акции' FROM Акции JOIN ВидАкции ON Акции.idВид = ВидАкции.idВид WHERE датаНач >= @DT and quantity != limit ORDER BY датаНач", db.getConnection());
            stockcommand.Parameters.Add("@DT", SqlDbType.DateTime).Value = thisDay;
            stockcommand.Parameters.Add("@UI", SqlDbType.NVarChar).Value = idUser;
            adapter.SelectCommand = stockcommand;
            adapter.Fill(stocktable);

            dataSTOCKGridView.DataSource = stocktable;
            dataSTOCKGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataSTOCKGridView.MultiSelect = false;

            //FINE DATA
            SqlCommand finecommand = new SqlCommand("SELECT idШтраф AS 'Номер штрафа', Акции.idАкции as 'Номер акции', Акции.наименование as 'Название акции', датаШтрафа AS 'Дата штрафа', сумма  AS Сумма, информация AS 'Информация о штрафе', апелляция AS 'Статус апелляции' FROM Штраф JOIN Акции ON Акции.idАкции = Штраф.idАкции WHERE idПользователя = @UI", db.getConnection());
            finecommand.Parameters.Add("@UI", SqlDbType.NVarChar).Value = idUser;
            adapter.SelectCommand = finecommand;
            adapter.Fill(finetable);
            dataFINEGridView.DataSource = finetable;

            //FINE APPEAL FUNCTION
            SqlCommand finenullcommand = new SqlCommand("SELECT idШтраф FROM Штраф WHERE idПользователя = @UI and апелляция is null", db.getConnection());
            finenullcommand.Parameters.Add("@UI", SqlDbType.NVarChar).Value = idUser;
            adapter.SelectCommand = finenullcommand;
            adapter.Fill(finenulltable);
            appeallistbox.DisplayMember = "idШтраф";
            appeallistbox.ValueMember = "idШтраф";
            appeallistbox.DataSource = finenulltable;

            if (finenulltable.Rows.Count <= 0)
            {
                appeallistbox.Enabled = false;
                submitappeal.Enabled = false;
            }
            else
            {
                appeallistbox.Enabled = true;
                appeallistbox.Enabled = true;
            }

            //MYSTOCK DATA
            SqlCommand mystockcommand = new SqlCommand("SELECT Акции.idАкции AS 'Номер акции', Акции.наименование AS 'Название акции', Акции.датаНач AS 'Дата начала', Акции.датаКон AS 'Дата конца', ВидАкции.наименованиеВида AS 'Тип акции', Место.наименование AS 'Место проведения' FROM Регистрация JOIN Акции ON Регистрация.idАкции = Акции.idАкции Inner Join ВидАкции ON ВидАкции.idВид = Акции.idВид CROSS JOIN Место WHERE Регистрация.idПользователя = @UI ORDER BY Акции.датаНач", db.getConnection());
            mystockcommand.Parameters.Add("@UI", SqlDbType.Int).Value = idUser;
            adapter.SelectCommand = mystockcommand;
            adapter.Fill(mystocktable);
            dataMYSTOCKGridView.DataSource = mystocktable;

        }

        private void submitappeal_Click(object sender, EventArgs e)
        {
            LoginForm loginform = (LoginForm)this.Owner;

            int idUser = loginform.idUser;

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            object appealid = appeallistbox.SelectedValue;

            SqlCommand sumbitappealcommand = new SqlCommand("UPDATE Штраф SET апелляция = N'Рассмотрение' WHERE idШтраф = @IF and idПользователя = @UI", db.getConnection());
            sumbitappealcommand.Parameters.Add("@IF", SqlDbType.NVarChar).Value = appealid;
            sumbitappealcommand.Parameters.Add("@UI", SqlDbType.NVarChar).Value = idUser;
            adapter.SelectCommand = sumbitappealcommand;
            adapter.Fill(table);

            MessageBox.Show("Апелляция успешна отправлена на рассмотрение!");
        }
        private void dataSTOCKGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoginForm loginform = (LoginForm)this.Owner;

            int idUser = loginform.idUser;
            DataGridViewRow currentRow = dataSTOCKGridView.CurrentRow;
            int stockid = Convert.ToInt32(currentRow.Cells[0].Value);

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand stockandusercommand = new SqlCommand("SELECT * FROM Регистрация WHERE idАкции = @SI and idПользователя = @UI", db.getConnection());
            stockandusercommand.Parameters.Add("@SI", SqlDbType.NVarChar).Value = stockid;
            stockandusercommand.Parameters.Add("@UI", SqlDbType.NVarChar).Value = idUser;
            adapter.SelectCommand = stockandusercommand;
            DataTable stockanduser = new DataTable();
            adapter.Fill(stockanduser);

            if (stockanduser.Rows.Count > 0)
            { registerstockbutton.Enabled = false; }
            else
            { registerstockbutton.Enabled = true; }
        }
        private void registerstockbutton_Click(object sender, EventArgs e)
        {
            LoginForm loginform = (LoginForm)this.Owner;

            int idUser = loginform.idUser;
            DataGridViewRow currentRow = dataSTOCKGridView.CurrentRow;
            int stockid = Convert.ToInt32(currentRow.Cells[0].Value);

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand registercommand = new SqlCommand("INSERT Регистрация(idАкции, idПользователя)VALUES(@SI, @UI)", db.getConnection());
            registercommand.Parameters.Add("@SI", SqlDbType.NVarChar).Value = stockid;
            registercommand.Parameters.Add("@UI", SqlDbType.NVarChar).Value = idUser;
            adapter.SelectCommand = registercommand;
            adapter.Fill(table);

            SqlCommand stockquantitycommand = new SqlCommand("UPDATE Акции SET quantity = quantity+1 WHERE idАкции = @SI", db.getConnection());
            stockquantitycommand.Parameters.Add("@SI", SqlDbType.NVarChar).Value = stockid;
            stockquantitycommand.Parameters.Add("@UI", SqlDbType.NVarChar).Value = idUser;
            adapter.SelectCommand = stockquantitycommand;
            adapter.Fill(table);

            MessageBox.Show("Вы успешно записались на акцию!");
        }
        private void comboBoxTypeStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypeStock.SelectedIndex)
            {
                case 0:

                    (dataMYSTOCKGridView.DataSource as DataTable).DefaultView.RowFilter = "";

                    break;
                default:
                    (dataMYSTOCKGridView.DataSource as DataTable).DefaultView.RowFilter = $"`Тип акции` LIKE '%{comboBoxTypeStock.SelectedItem}%'";
                    break;
            }
        }
        private void comboBoxPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxPlace.SelectedIndex)
            {
                case 0:

                    (dataMYSTOCKGridView.DataSource as DataTable).DefaultView.RowFilter = "";

                    break;
                default:
                    (dataMYSTOCKGridView.DataSource as DataTable).DefaultView.RowFilter = $"`Место проведения` LIKE '%{comboBoxPlace.SelectedItem}%'";
                    break;
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Now;

            switch (comboBoxStatus.SelectedIndex)
            {
                case 0:

                    (dataMYSTOCKGridView.DataSource as DataTable).DefaultView.RowFilter = "";

                    break;
                case 1:

                    (dataMYSTOCKGridView.DataSource as DataTable).DefaultView.RowFilter = $"`Дата конца` > #" + thisDay.ToString("yyyy/MM/dd") + "#";

                    break;
                case 2:

                    (dataMYSTOCKGridView.DataSource as DataTable).DefaultView.RowFilter = $"`Дата конца` < #" + thisDay.ToString("yyyy/MM/dd") + "#";

                    break;
            }
        }

        private void allFilterBtn_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Now;

            if (comboBoxStatus.SelectedIndex == 0) { (dataMYSTOCKGridView.DataSource as DataTable).DefaultView.RowFilter = $"`Тип акции` LIKE '%{comboBoxTypeStock.SelectedItem}%' AND `Место проведения` LIKE '%{comboBoxPlace.SelectedItem}%'";  }
            else if (comboBoxStatus.SelectedIndex == 1) { (dataMYSTOCKGridView.DataSource as DataTable).DefaultView.RowFilter = $"`Тип акции` LIKE '%{comboBoxTypeStock.SelectedItem}%' AND `Место проведения` LIKE '%{comboBoxPlace.SelectedItem}%' AND `Дата конца` > #" + thisDay.ToString("yyyy/MM/dd") + "#";  }
            else { (dataMYSTOCKGridView.DataSource as DataTable).DefaultView.RowFilter = $"`Тип акции` LIKE '%{comboBoxTypeStock.SelectedItem}%' AND `Место проведения` LIKE '%{comboBoxPlace.SelectedItem}%' AND `Дата конца` < #" + thisDay.ToString("yyyy/MM/dd") + "#"; }
        }
    }
}
