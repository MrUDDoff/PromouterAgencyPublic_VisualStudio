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
    public partial class editstockForm : Form
    {
        public editstockForm()
        {
            InitializeComponent();
        }

        private void editstockForm_Load(object sender, EventArgs e)
        {
            managerForm managerform = (managerForm)this.Owner;

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable findeditstocktable = new DataTable();
            DataTable typestocktable = new DataTable();

            SqlCommand typestockcommand = new SqlCommand("SELECT * FROM ВидАкции", db.getConnection());
            adapter.SelectCommand = typestockcommand;
            adapter.Fill(typestocktable);
            typeField.DisplayMember = "наименованиеВида";
            typeField.ValueMember = "idВид";
            typeField.DataSource = typestocktable;

            SqlCommand findeditstockcommand = new SqlCommand("SELECT * FROM Акции WHERE idАкции = @CSI", db.getConnection());
            findeditstockcommand.Parameters.Add("@CSI", SqlDbType.Int).Value = managerform.clickedstockid;
            adapter.SelectCommand = findeditstockcommand;
            adapter.Fill(findeditstocktable);

            nameField.Text = findeditstocktable.Rows[0].Field<String>("наименование");
            limitField.Value = findeditstocktable.Rows[0].Field<int>("limit");
            startDate.Value = findeditstocktable.Rows[0].Field<DateTime>("датаНач");
            endDate.Value = findeditstocktable.Rows[0].Field<DateTime>("датаКон");
            typeField.SelectedValue = findeditstocktable.Rows[0].Field<int>("idВид");
            paymentField.Value = findeditstocktable.Rows[0].Field<int>("оплата");
        }

        private void newstockButton_Click(object sender, EventArgs e)
        {
            managerForm managerform = (managerForm)this.Owner;

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable createstocktable = new DataTable();

            DialogResult suredupdate = MessageBox.Show("Вы точно хотите обновить акцию?\n\nЭто действие нельзя отменить!", "Редактирование акции", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (suredupdate == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("UPDATE Акции SET наименование = @NF, limit = @LF, датаНач = @SD, датаКон = @ED, idВид = @TF, оплата = @PF WHERE idАкции = @CSI", db.getConnection());
                command.Parameters.Add("@NF", SqlDbType.NVarChar).Value = nameField.Text;
                command.Parameters.Add("@LF", SqlDbType.Int).Value = limitField.Value;
                command.Parameters.Add("@SD", SqlDbType.DateTime).Value = startDate.Value;
                command.Parameters.Add("@ED", SqlDbType.DateTime).Value = endDate.Value;
                command.Parameters.Add("@TF", SqlDbType.Int).Value = typeField.SelectedValue;
                command.Parameters.Add("@PF", SqlDbType.Int).Value = paymentField.Value;
                command.Parameters.Add("@CSI", SqlDbType.Int).Value = managerform.clickedstockid;
                adapter.SelectCommand = command;
                adapter.Fill(createstocktable);
                this.Close();
            }
        }
    }
}
