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
    public partial class supervaisorForm : Form
    {
        public supervaisorForm()
        {
            InitializeComponent();
        }
        public void supervaisorForm_Activated(object sender, EventArgs e)
        {

        }

        private void showstocksbutton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable stocklisttable = new DataTable();

            SqlCommand stocklistcommand = new SqlCommand("SELECT Акции.idАкции AS 'Номер акции', Акции.наименование AS Название, quantity AS 'Кол-во промоутеров', limit AS 'Максимальное кол-во промоутеров', датаНач AS 'Дата начала', датаКон AS 'Дата конца', ВидАкции.наименованиеВида AS 'Тип акции', Оплата FROM Акции JOIN ВидАкции ON Акции.idВид = ВидАкции.idВид ORDER BY датаНач, Акции.idВид", db.getConnection());
            adapter.SelectCommand = stocklistcommand;
            adapter.Fill(stocklisttable);

            dataGridView.DataSource = stocklisttable;
        }

        private void showpromoutersbutton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable firstnametable = new DataTable();

            SqlCommand firstnamecommand = new SqlCommand("SELECT idПользователя, Фамилия, Имя, Отчество, Телефон FROM Пользователи WHERE idРоль = 4", db.getConnection());
            adapter.SelectCommand = firstnamecommand;
            adapter.Fill(firstnametable);

            dataGridView.DataSource = firstnametable;
        }

        private void showfinemenu_Click(object sender, EventArgs e)
        {
            finemenuForm finesmenuform = new finemenuForm();
            finesmenuform.Owner = this;
            finesmenuform.ShowDialog();
        }
    }
}
