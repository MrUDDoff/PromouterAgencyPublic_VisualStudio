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
using WindowsFormsApp1.Manager;

namespace WindowsFormsApp1
{
    public partial class managerForm : Form
    {

        public managerForm()
        {
            InitializeComponent();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable firstnametable = new DataTable();

            SqlCommand firstnamecommand = new SqlCommand("SELECT idПользователя, Фамилия, Имя, Отчество, Телефон FROM Пользователи WHERE idРоль = 4", db.getConnection());
            adapter.SelectCommand = firstnamecommand;
            adapter.Fill(firstnametable);

            dataPROMOUTERSGridView.DataSource = firstnametable;

            comboBoxSort.SelectedIndex = 0;

            approveBtn.Enabled = false;
            refuseBtn.Enabled = false;
        }

        public void managerForm_Activated(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            DateTime thisDayN = DateTime.Now;

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable allstocktable = new DataTable();
            DataTable activestocktable = new DataTable();
            DataTable allfinestable = new DataTable();

            SqlCommand allstockcommand = new SqlCommand("SELECT Акции.idАкции AS 'Номер акции', Акции.наименование AS Название, quantity AS 'Кол-во промоутеров', limit AS 'Максимальное кол-во промоутеров', датаНач AS 'Дата начала', датаКон AS 'Дата конца', ВидАкции.наименованиеВида AS 'Тип акции', Оплата FROM Акции JOIN ВидАкции ON Акции.idВид = ВидАкции.idВид ORDER BY датаНач, Акции.idВид", db.getConnection());
            adapter.SelectCommand = allstockcommand;
            adapter.Fill(allstocktable);

            SqlCommand activestockcommand = new SqlCommand("SELECT Акции.idАкции AS 'Номер акции', Акции.наименование AS Название, quantity AS 'Кол-во промоутеров', limit AS 'Максимальное кол-во промоутеров', датаНач AS 'Дата начала', датаКон AS 'Дата конца', ВидАкции.наименованиеВида AS 'Тип акции', Оплата FROM Акции JOIN ВидАкции ON Акции.idВид = ВидАкции.idВид WHERE датаКон >= @DT ORDER BY датаНач, Акции.idВид", db.getConnection());
            activestockcommand.Parameters.Add("@DT", SqlDbType.DateTime).Value = thisDay;
            adapter.SelectCommand = activestockcommand;
            adapter.Fill(activestocktable);

            SqlCommand allfinescommand = new SqlCommand("SELECT idШтраф AS 'Номер штрафа', Акции.idАкции as 'Номер акции', Акции.наименование as 'Название акции', Акции.датаНач AS 'Дата начала акции', Акции.датаКон AS 'Дата конца акции', датаШтрафа AS 'Дата штрафа', сумма  AS Сумма, информация AS 'Информация о штрафе', апелляция AS 'Статус апелляции' FROM Штраф JOIN Акции ON Акции.idАкции = Штраф.idАкции ORDER BY датаШтрафа, апелляция", db.getConnection());
            adapter.SelectCommand = allfinescommand;
            adapter.Fill(allfinestable);

            dataALLSTOCKGridView.DataSource = allstocktable;
            dataGridView1.DataSource = activestocktable;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"`Дата начала` < #" + thisDay.ToString("yyyy/MM/dd") + "#";
            dataGridViewFineS.DataSource = allfinestable;

            dataALLSTOCKGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataALLSTOCKGridView.MultiSelect = false;

            dataGridViewFineS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFineS.MultiSelect = false;

            if (allstocktable.Rows.Count <= 0)
            {
                editSTOCKButton.Enabled = false;
                removeSTOCKButton.Enabled = false;
            }
            else
            {
                removeSTOCKButton.Enabled = true;
            }
        }

        private void newSTOCKButton_Click(object sender, EventArgs e)
        {
            newstockForm newstockform = new newstockForm();
            newstockform.Owner = this;
            newstockform.ShowDialog();
        }

        public void editSTOCKButton_Click(object sender, EventArgs e)
        {

            DialogResult surededit = MessageBox.Show("Если вы хотите редактировать основную информацию, то нажмите да. \nЕсли место проведение, то нажмите нет. \n\nВ противном случае нажмите отмена.", "Вы уверены?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (surededit == DialogResult.Yes)
            {
                editstockForm editstockform = new editstockForm();
                editstockform.Owner = this;
                editstockform.ShowDialog();
            }
            else if (surededit == DialogResult.No)
            {

                editplacesForm editplacesform = new editplacesForm();
                editplacesform.Owner = this;
                editplacesform.ShowDialog();
            }
        }

        private void removeSTOCKButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataALLSTOCKGridView.CurrentRow;
            int stockid = Convert.ToInt32(currentRow.Cells[0].Value);

            DialogResult suredeletion = MessageBox.Show("Вы точно хотите удалить акцию под номером " + stockid + "?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (suredeletion == DialogResult.Yes)
            {
                DB db = new DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable deletestockable = new DataTable();

                SqlCommand deletestockcommand = new SqlCommand("DELETE FROM Акции WHERE idАкции = @SI", db.getConnection());
                deletestockcommand.Parameters.Add("@SI", SqlDbType.Int).Value = stockid;
                adapter.SelectCommand = deletestockcommand;
                adapter.Fill(deletestockable);

                MessageBox.Show("Акция под номером " + stockid + " была удалена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string clickedstockid;

        public void dataALLSTOCKGridView_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataALLSTOCKGridView.CurrentRow;
            int clickstockid = Convert.ToInt32(currentRow.Cells[0].Value);

            clickedstockid = clickstockid.ToString();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSort.SelectedIndex)
            {
                case 0:

                    (dataGridViewFineS.DataSource as DataTable).DefaultView.RowFilter = "";

                    break;
                case 1:

                    (dataGridViewFineS.DataSource as DataTable).DefaultView.RowFilter = $"`Статус апелляции` IS NULL";

                    break;

                case 2:

                    (dataGridViewFineS.DataSource as DataTable).DefaultView.RowFilter = $"`Статус апелляции` = 'Рассмотрение'";

                    break;
                case 3:

                    (dataGridViewFineS.DataSource as DataTable).DefaultView.RowFilter = $"`Статус апелляции` = 'Одобрено'";

                    break;
                case 4:

                    (dataGridViewFineS.DataSource as DataTable).DefaultView.RowFilter = $"`Статус апелляции` = 'Отказано'";

                    break;
            }
        }

        private void dataGridViewFineS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridViewFineS.CurrentRow;
            string cellstring = currentRow.Cells[8].Value.ToString();

            if (cellstring == "Рассмотрение")
            {
                approveBtn.Enabled = true;
                refuseBtn.Enabled = true;
            }
            else
            {
                approveBtn.Enabled = false;
                refuseBtn.Enabled = false;
            }
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            DataGridViewRow currentRow = dataGridViewFineS.CurrentRow;
            int fineid = Convert.ToInt32(currentRow.Cells[0].Value);

            SqlCommand approveappealcommand = new SqlCommand("UPDATE Штраф SET апелляция = N'Одобрено' WHERE idШтраф = @FID", db.getConnection());
            approveappealcommand.Parameters.Add("@FID", SqlDbType.Int).Value = fineid;
            adapter.SelectCommand = approveappealcommand;
            adapter.Fill(table);

            MessageBox.Show("Апелляция одобрена!");
        }

        private void refuseBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            DataGridViewRow currentRow = dataGridViewFineS.CurrentRow;
            int fineid = Convert.ToInt32(currentRow.Cells[0].Value);

            SqlCommand refuseappealcommand = new SqlCommand("UPDATE Штраф SET апелляция = N'Отказано' WHERE idШтраф = @FID", db.getConnection());
            refuseappealcommand.Parameters.Add("@FID", SqlDbType.Int).Value = fineid;
            adapter.SelectCommand = refuseappealcommand;
            adapter.Fill(table);

            MessageBox.Show("Апелляция отклонена!");
        }
    }
}
