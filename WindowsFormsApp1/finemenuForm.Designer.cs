
namespace WindowsFormsApp1
{
    partial class finemenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.allFinesPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.addFinePage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxstocklist = new System.Windows.Forms.ComboBox();
            this.comboBoxpromouterlist = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxinfofine = new System.Windows.Forms.TextBox();
            this.addfineBtn = new System.Windows.Forms.Button();
            this.numericUpDownSUM = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editFinePage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDowneditSUM = new System.Windows.Forms.NumericUpDown();
            this.textBoxeditinfofine = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.allFinesPage.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.addFinePage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.editFinePage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowneditSUM)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.allFinesPage);
            this.tabControl1.Controls.Add(this.addFinePage);
            this.tabControl1.Controls.Add(this.editFinePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // allFinesPage
            // 
            this.allFinesPage.Controls.Add(this.tableLayoutPanel6);
            this.allFinesPage.Location = new System.Drawing.Point(4, 22);
            this.allFinesPage.Name = "allFinesPage";
            this.allFinesPage.Size = new System.Drawing.Size(792, 424);
            this.allFinesPage.TabIndex = 2;
            this.allFinesPage.Text = "Все штрафы";
            this.allFinesPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.dataGridView3, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 424F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(792, 424);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(786, 418);
            this.dataGridView3.TabIndex = 0;
            // 
            // addFinePage
            // 
            this.addFinePage.Controls.Add(this.tableLayoutPanel1);
            this.addFinePage.Location = new System.Drawing.Point(4, 22);
            this.addFinePage.Name = "addFinePage";
            this.addFinePage.Size = new System.Drawing.Size(792, 424);
            this.addFinePage.TabIndex = 0;
            this.addFinePage.Text = "Выдать штраф";
            this.addFinePage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.962264F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.77358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0283F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 424);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxstocklist, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxpromouterlist, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 32);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBoxstocklist
            // 
            this.comboBoxstocklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxstocklist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxstocklist.FormattingEnabled = true;
            this.comboBoxstocklist.Location = new System.Drawing.Point(3, 3);
            this.comboBoxstocklist.Name = "comboBoxstocklist";
            this.comboBoxstocklist.Size = new System.Drawing.Size(387, 21);
            this.comboBoxstocklist.TabIndex = 0;
            this.comboBoxstocklist.SelectedIndexChanged += new System.EventHandler(this.comboBoxstocklist_SelectedIndexChanged);
            // 
            // comboBoxpromouterlist
            // 
            this.comboBoxpromouterlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxpromouterlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxpromouterlist.Enabled = false;
            this.comboBoxpromouterlist.FormattingEnabled = true;
            this.comboBoxpromouterlist.Location = new System.Drawing.Point(396, 3);
            this.comboBoxpromouterlist.Name = "comboBoxpromouterlist";
            this.comboBoxpromouterlist.Size = new System.Drawing.Size(387, 21);
            this.comboBoxpromouterlist.TabIndex = 1;
            this.comboBoxpromouterlist.SelectedIndexChanged += new System.EventHandler(this.comboBoxpromouterlist_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.06022F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.80916F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.17303F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxinfofine, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.addfineBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDownSUM, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 375);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 46);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // textBoxinfofine
            // 
            this.textBoxinfofine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxinfofine.Enabled = false;
            this.textBoxinfofine.Location = new System.Drawing.Point(3, 3);
            this.textBoxinfofine.Multiline = true;
            this.textBoxinfofine.Name = "textBoxinfofine";
            this.textBoxinfofine.Size = new System.Drawing.Size(395, 40);
            this.textBoxinfofine.TabIndex = 1;
            // 
            // addfineBtn
            // 
            this.addfineBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addfineBtn.Location = new System.Drawing.Point(598, 3);
            this.addfineBtn.Name = "addfineBtn";
            this.addfineBtn.Size = new System.Drawing.Size(185, 40);
            this.addfineBtn.TabIndex = 0;
            this.addfineBtn.Text = "Выдать штраф";
            this.addfineBtn.UseVisualStyleBackColor = true;
            this.addfineBtn.Click += new System.EventHandler(this.addfineBtn_Click);
            // 
            // numericUpDownSUM
            // 
            this.numericUpDownSUM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownSUM.Location = new System.Drawing.Point(404, 3);
            this.numericUpDownSUM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSUM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSUM.Name = "numericUpDownSUM";
            this.numericUpDownSUM.Size = new System.Drawing.Size(188, 20);
            this.numericUpDownSUM.TabIndex = 2;
            this.numericUpDownSUM.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(786, 328);
            this.dataGridView1.TabIndex = 2;
            // 
            // editFinePage
            // 
            this.editFinePage.Controls.Add(this.tableLayoutPanel4);
            this.editFinePage.Location = new System.Drawing.Point(4, 22);
            this.editFinePage.Name = "editFinePage";
            this.editFinePage.Size = new System.Drawing.Size(792, 424);
            this.editFinePage.TabIndex = 1;
            this.editFinePage.Text = "Редактировать штрафы";
            this.editFinePage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.editBtn, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.48113F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.79245F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.490566F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(792, 424);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(786, 331);
            this.dataGridView2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.numericUpDowneditSUM, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxeditinfofine, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 340);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(786, 44);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // numericUpDowneditSUM
            // 
            this.numericUpDowneditSUM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDowneditSUM.Location = new System.Drawing.Point(396, 3);
            this.numericUpDowneditSUM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDowneditSUM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDowneditSUM.Name = "numericUpDowneditSUM";
            this.numericUpDowneditSUM.Size = new System.Drawing.Size(387, 20);
            this.numericUpDowneditSUM.TabIndex = 3;
            this.numericUpDowneditSUM.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // textBoxeditinfofine
            // 
            this.textBoxeditinfofine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxeditinfofine.Location = new System.Drawing.Point(3, 3);
            this.textBoxeditinfofine.Multiline = true;
            this.textBoxeditinfofine.Name = "textBoxeditinfofine";
            this.textBoxeditinfofine.Size = new System.Drawing.Size(387, 38);
            this.textBoxeditinfofine.TabIndex = 2;
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBtn.Location = new System.Drawing.Point(3, 390);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(786, 31);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Применить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // finemenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "finemenuForm";
            this.Text = "finemenuForm";
            this.Activated += new System.EventHandler(this.finemenuForm_Activated);
            this.Load += new System.EventHandler(this.finemenuForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.allFinesPage.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.addFinePage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.editFinePage.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowneditSUM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addFinePage;
        private System.Windows.Forms.TabPage editFinePage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBoxstocklist;
        private System.Windows.Forms.ComboBox comboBoxpromouterlist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button addfineBtn;
        private System.Windows.Forms.TextBox textBoxinfofine;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDownSUM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.NumericUpDown numericUpDowneditSUM;
        private System.Windows.Forms.TextBox textBoxeditinfofine;
        private System.Windows.Forms.TabPage allFinesPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}