namespace WindowsFormsApp1
{
    partial class managerForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.allSTOCKPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.newSTOCKButton = new System.Windows.Forms.Button();
            this.removeSTOCKButton = new System.Windows.Forms.Button();
            this.editSTOCKButton = new System.Windows.Forms.Button();
            this.dataALLSTOCKGridView = new System.Windows.Forms.DataGridView();
            this.activeSTOCKPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.promoutersPage = new System.Windows.Forms.TabPage();
            this.dataPROMOUTERSGridView = new System.Windows.Forms.DataGridView();
            this.appealfinePage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.approveBtn = new System.Windows.Forms.Button();
            this.refuseBtn = new System.Windows.Forms.Button();
            this.dataGridViewFineS = new System.Windows.Forms.DataGridView();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.akciitexnikumDataSet = new WindowsFormsApp1.akciitexnikumDataSet();
            this.tabControl.SuspendLayout();
            this.stockPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.allSTOCKPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataALLSTOCKGridView)).BeginInit();
            this.activeSTOCKPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.promoutersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPROMOUTERSGridView)).BeginInit();
            this.appealfinePage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFineS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akciitexnikumDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.stockPage);
            this.tabControl.Controls.Add(this.promoutersPage);
            this.tabControl.Controls.Add(this.appealfinePage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1005, 519);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.tabControl1);
            this.stockPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.stockPage.Location = new System.Drawing.Point(4, 24);
            this.stockPage.Name = "stockPage";
            this.stockPage.Size = new System.Drawing.Size(997, 491);
            this.stockPage.TabIndex = 1;
            this.stockPage.Text = "Акции";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.allSTOCKPage);
            this.tabControl1.Controls.Add(this.activeSTOCKPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // allSTOCKPage
            // 
            this.allSTOCKPage.Controls.Add(this.tableLayoutPanel1);
            this.allSTOCKPage.Location = new System.Drawing.Point(4, 24);
            this.allSTOCKPage.Name = "allSTOCKPage";
            this.allSTOCKPage.Padding = new System.Windows.Forms.Padding(3);
            this.allSTOCKPage.Size = new System.Drawing.Size(989, 463);
            this.allSTOCKPage.TabIndex = 0;
            this.allSTOCKPage.Text = "Все акции";
            this.allSTOCKPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataALLSTOCKGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.06565F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.93436F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(983, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.newSTOCKButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.removeSTOCKButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.editSTOCKButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(977, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // newSTOCKButton
            // 
            this.newSTOCKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newSTOCKButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.newSTOCKButton.Location = new System.Drawing.Point(3, 3);
            this.newSTOCKButton.Name = "newSTOCKButton";
            this.newSTOCKButton.Size = new System.Drawing.Size(319, 34);
            this.newSTOCKButton.TabIndex = 0;
            this.newSTOCKButton.Text = "Новая акция";
            this.newSTOCKButton.UseVisualStyleBackColor = true;
            this.newSTOCKButton.Click += new System.EventHandler(this.newSTOCKButton_Click);
            // 
            // removeSTOCKButton
            // 
            this.removeSTOCKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeSTOCKButton.ForeColor = System.Drawing.Color.Red;
            this.removeSTOCKButton.Location = new System.Drawing.Point(653, 3);
            this.removeSTOCKButton.Name = "removeSTOCKButton";
            this.removeSTOCKButton.Size = new System.Drawing.Size(321, 34);
            this.removeSTOCKButton.TabIndex = 1;
            this.removeSTOCKButton.Text = "Удалить акцию";
            this.removeSTOCKButton.UseVisualStyleBackColor = true;
            this.removeSTOCKButton.Click += new System.EventHandler(this.removeSTOCKButton_Click);
            // 
            // editSTOCKButton
            // 
            this.editSTOCKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editSTOCKButton.ForeColor = System.Drawing.Color.Salmon;
            this.editSTOCKButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editSTOCKButton.Location = new System.Drawing.Point(328, 3);
            this.editSTOCKButton.Name = "editSTOCKButton";
            this.editSTOCKButton.Size = new System.Drawing.Size(319, 34);
            this.editSTOCKButton.TabIndex = 2;
            this.editSTOCKButton.Text = "Редактировать акцию";
            this.editSTOCKButton.UseVisualStyleBackColor = true;
            this.editSTOCKButton.Click += new System.EventHandler(this.editSTOCKButton_Click);
            // 
            // dataALLSTOCKGridView
            // 
            this.dataALLSTOCKGridView.AllowUserToAddRows = false;
            this.dataALLSTOCKGridView.AllowUserToDeleteRows = false;
            this.dataALLSTOCKGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataALLSTOCKGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataALLSTOCKGridView.Location = new System.Drawing.Point(3, 49);
            this.dataALLSTOCKGridView.Name = "dataALLSTOCKGridView";
            this.dataALLSTOCKGridView.ReadOnly = true;
            this.dataALLSTOCKGridView.Size = new System.Drawing.Size(977, 405);
            this.dataALLSTOCKGridView.TabIndex = 1;
            this.dataALLSTOCKGridView.Click += new System.EventHandler(this.dataALLSTOCKGridView_Click);
            // 
            // activeSTOCKPage
            // 
            this.activeSTOCKPage.Controls.Add(this.dataGridView1);
            this.activeSTOCKPage.Location = new System.Drawing.Point(4, 24);
            this.activeSTOCKPage.Name = "activeSTOCKPage";
            this.activeSTOCKPage.Padding = new System.Windows.Forms.Padding(3);
            this.activeSTOCKPage.Size = new System.Drawing.Size(989, 463);
            this.activeSTOCKPage.TabIndex = 1;
            this.activeSTOCKPage.Text = "Активные акции";
            this.activeSTOCKPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(983, 457);
            this.dataGridView1.TabIndex = 0;
            // 
            // promoutersPage
            // 
            this.promoutersPage.Controls.Add(this.dataPROMOUTERSGridView);
            this.promoutersPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.promoutersPage.Location = new System.Drawing.Point(4, 24);
            this.promoutersPage.Name = "promoutersPage";
            this.promoutersPage.Size = new System.Drawing.Size(997, 491);
            this.promoutersPage.TabIndex = 0;
            this.promoutersPage.Text = "Промоутеры";
            this.promoutersPage.UseVisualStyleBackColor = true;
            // 
            // dataPROMOUTERSGridView
            // 
            this.dataPROMOUTERSGridView.AllowUserToAddRows = false;
            this.dataPROMOUTERSGridView.AllowUserToDeleteRows = false;
            this.dataPROMOUTERSGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPROMOUTERSGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPROMOUTERSGridView.Location = new System.Drawing.Point(0, 0);
            this.dataPROMOUTERSGridView.Name = "dataPROMOUTERSGridView";
            this.dataPROMOUTERSGridView.ReadOnly = true;
            this.dataPROMOUTERSGridView.Size = new System.Drawing.Size(997, 491);
            this.dataPROMOUTERSGridView.TabIndex = 0;
            // 
            // appealfinePage
            // 
            this.appealfinePage.Controls.Add(this.tableLayoutPanel3);
            this.appealfinePage.Location = new System.Drawing.Point(4, 24);
            this.appealfinePage.Name = "appealfinePage";
            this.appealfinePage.Size = new System.Drawing.Size(997, 491);
            this.appealfinePage.TabIndex = 2;
            this.appealfinePage.Text = "Апелляции";
            this.appealfinePage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewFineS, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSort, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.12831F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.53972F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.535642F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(997, 491);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.approveBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.refuseBtn, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 456);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(991, 32);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // approveBtn
            // 
            this.approveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.approveBtn.Location = new System.Drawing.Point(3, 3);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(489, 26);
            this.approveBtn.TabIndex = 0;
            this.approveBtn.Text = "Одобрить";
            this.approveBtn.UseVisualStyleBackColor = true;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // refuseBtn
            // 
            this.refuseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refuseBtn.Location = new System.Drawing.Point(498, 3);
            this.refuseBtn.Name = "refuseBtn";
            this.refuseBtn.Size = new System.Drawing.Size(490, 26);
            this.refuseBtn.TabIndex = 1;
            this.refuseBtn.Text = "Отказать";
            this.refuseBtn.UseVisualStyleBackColor = true;
            this.refuseBtn.Click += new System.EventHandler(this.refuseBtn_Click);
            // 
            // dataGridViewFineS
            // 
            this.dataGridViewFineS.AllowUserToAddRows = false;
            this.dataGridViewFineS.AllowUserToDeleteRows = false;
            this.dataGridViewFineS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFineS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFineS.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewFineS.Name = "dataGridViewFineS";
            this.dataGridViewFineS.ReadOnly = true;
            this.dataGridViewFineS.Size = new System.Drawing.Size(991, 413);
            this.dataGridViewFineS.TabIndex = 1;
            this.dataGridViewFineS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFineS_CellClick);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Статус апелляции - Все штрафы",
            "Статус апелляции - Без статуса",
            "Статус апелляции - Рассмотрение",
            "Статус апелляции - Одобрено",
            "Статус апелляции - Отказано"});
            this.comboBoxSort.Location = new System.Drawing.Point(3, 3);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(991, 23);
            this.comboBoxSort.TabIndex = 2;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // akciitexnikumDataSet
            // 
            this.akciitexnikumDataSet.DataSetName = "akciitexnikumDataSet";
            this.akciitexnikumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 519);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "managerForm";
            this.Text = "managerForm";
            this.Activated += new System.EventHandler(this.managerForm_Activated);
            this.tabControl.ResumeLayout(false);
            this.stockPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.allSTOCKPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataALLSTOCKGridView)).EndInit();
            this.activeSTOCKPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.promoutersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPROMOUTERSGridView)).EndInit();
            this.appealfinePage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFineS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akciitexnikumDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage promoutersPage;
        private System.Windows.Forms.DataGridView dataPROMOUTERSGridView;
        private akciitexnikumDataSet akciitexnikumDataSet;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage allSTOCKPage;
        private System.Windows.Forms.TabPage activeSTOCKPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button newSTOCKButton;
        private System.Windows.Forms.Button removeSTOCKButton;
        private System.Windows.Forms.Button editSTOCKButton;
        public System.Windows.Forms.DataGridView dataALLSTOCKGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage appealfinePage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridViewFineS;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.Button refuseBtn;
    }
}