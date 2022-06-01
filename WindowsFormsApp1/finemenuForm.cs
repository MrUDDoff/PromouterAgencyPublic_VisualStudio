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
    public partial class finemenuForm : Form
    {
        public finemenuForm()
        {
            InitializeComponent();
        }

        private void finemenuForm_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            DateTime thisDay = DateTime.Now;

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable activestocktable = new DataTable();
            SqlCommand activestockcommand = new SqlCommand("SELECT Акции.idАкции AS 'Номер акции', Акции.наименование AS Название, quantity AS 'Кол-во промоутеров', limit AS 'Максимальное кол-во промоутеров', датаНач AS 'Дата начала', датаКон AS 'Дата конца', ВидАкции.наименованиеВида AS 'Тип акции', Оплата FROM Акции JOIN ВидАкции ON Акции.idВид = ВидАкции.idВид WHERE датаКон >= @DT ORDER BY датаНач, Акции.idВид", db.getConnection());
            activestockcommand.Parameters.Add("@DT", SqlDbType.DateTime).Value = thisDay;
            adapter.SelectCommand = activestockcommand;
            adapter.Fill(activestocktable);

            dataGridView1.DataSource = activestocktable;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"`Дата начала` <= #" + thisDay.ToString("yyyy/MM/dd") + "#";

            comboBoxstocklist.DisplayMember = "Название";
            comboBoxstocklist.ValueMember = "Номер акции";
            comboBoxstocklist.DataSource = activestocktable;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;

            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;
        }

        private void finemenuForm_Activated(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand allnullfinescommand = new SqlCommand("SELECT idШтраф AS 'Номер штрафа', Акции.idАкции as 'Номер акции', Акции.наименование as 'Название акции', Акции.датаНач AS 'Дата начала акции', Акции.датаКон AS 'Дата конца акции', датаШтрафа AS 'Дата штрафа', сумма  AS Сумма, информация AS 'Информация о штрафе', апелляция AS 'Статус апелляции' FROM Штраф JOIN Акции ON Акции.idАкции = Штраф.idАкции WHERE апелляция IS NULL ORDER BY датаШтрафа, апелляция", db.getConnection());
            adapter.SelectCommand = allnullfinescommand;
            DataTable allnullfinestable = new DataTable();
            adapter.Fill(allnullfinestable);
            dataGridView2.DataSource = allnullfinestable;

            SqlCommand allfinescommand = new SqlCommand("SELECT idШтраф AS 'Номер штрафа', Акции.idАкции as 'Номер акции', Акции.наименование as 'Название акции', Акции.датаНач AS 'Дата начала акции', Акции.датаКон AS 'Дата конца акции', датаШтрафа AS 'Дата штрафа', сумма  AS Сумма, информация AS 'Информация о штрафе', апелляция AS 'Статус апелляции' FROM Штраф JOIN Акции ON Акции.idАкции = Штраф.idАкции ORDER BY датаШтрафа, апелляция", db.getConnection());
            adapter.SelectCommand = allfinescommand;
            DataTable allfinestable = new DataTable();
            adapter.Fill(allfinestable);
            dataGridView3.DataSource = allfinestable;
        }

        private void comboBoxstocklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable registredpromtable = new DataTable();
            SqlCommand registredpromcommand = new SqlCommand("SELECT * FROM Регистрация JOIN Акции ON Регистрация.idАкции = Акции.idАкции JOIN Пользователи ON Регистрация.idПользователя = Пользователи.idПользователя WHERE Регистрация.idАкции = @IDS", db.getConnection());
            registredpromcommand.Parameters.Add("@IDS", SqlDbType.Int).Value = comboBoxstocklist.SelectedValue;
            adapter.SelectCommand = registredpromcommand;
            adapter.Fill(registredpromtable);

            comboBoxpromouterlist.DisplayMember = "Фамилия";
            comboBoxpromouterlist.ValueMember = "idПользователя";
            comboBoxpromouterlist.DataSource = registredpromtable;

            comboBoxpromouterlist.Enabled = true;
        }

        private void comboBoxpromouterlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxinfofine.Enabled = true;
        }

        private void addfineBtn_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable registerfinetable = new DataTable();

            if (textBoxinfofine.ToString() != "")
            {
                SqlCommand registerfineommand = new SqlCommand("INSERT INTO Штраф(idАкции, idПользователя, сумма, датаШтрафа, информация)VALUES(@IDS, @IDU, @SUM, @DT, @INFOF)", db.getConnection());
                registerfineommand.Parameters.Add("@IDS", SqlDbType.Int).Value = comboBoxstocklist.SelectedValue;
                registerfineommand.Parameters.Add("@IDU", SqlDbType.Int).Value = comboBoxpromouterlist.SelectedValue;
                registerfineommand.Parameters.Add("@SUM", SqlDbType.Int).Value = numericUpDownSUM.Value;
                registerfineommand.Parameters.Add("@DT", SqlDbType.DateTime).Value = thisDay;
                registerfineommand.Parameters.Add("@INFOF", SqlDbType.NVarChar).Value = textBoxinfofine.Text;
                adapter.SelectCommand = registerfineommand;
                adapter.Fill(registerfinetable);

                MessageBox.Show("Штраф выдан, пользователю - " + comboBoxpromouterlist.SelectedValue + " в размере - " + numericUpDownSUM.Value + " руб.");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataGridView2.CurrentRow;
            int clickstockid = Convert.ToInt32(currentRow.Cells[0].Value);

            DateTime thisDay = DateTime.Today;

            if (textBoxeditinfofine.ToString() != "")
            {
                DB db = new DB();
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable registereditfinetable = new DataTable();
                SqlCommand registereditfinecommand = new SqlCommand("UPDATE Штраф SET сумма = @SUM, датаШтрафа = @DF, информация = @INFOF WHERE idШтраф = @IDF", db.getConnection());
                registereditfinecommand.Parameters.Add("@IDF", SqlDbType.Int).Value = clickstockid;
                registereditfinecommand.Parameters.Add("@SUM", SqlDbType.Int).Value = numericUpDowneditSUM.Value;
                registereditfinecommand.Parameters.Add("@DF", SqlDbType.DateTime).Value = thisDay;
                registereditfinecommand.Parameters.Add("@INFOF", SqlDbType.NVarChar).Value = textBoxeditinfofine.Text;
                adapter.SelectCommand = registereditfinecommand;
                adapter.Fill(registereditfinetable);

                MessageBox.Show("Штраф номер " + clickstockid + " обновлён!");
            }
            else { MessageBox.Show("Поле информации пустое!"); }
        }
    }
}
