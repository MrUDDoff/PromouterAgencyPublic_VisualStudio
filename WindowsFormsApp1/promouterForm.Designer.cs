namespace WindowsFormsApp1
{
    partial class promouterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(promouterForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.dataLabel = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.activeStockPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataMYSTOCKGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.allFilterBtn = new System.Windows.Forms.Button();
            this.comboBoxTypeStock = new System.Windows.Forms.ComboBox();
            this.comboBoxPlace = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataSTOCKGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.registerstockbutton = new System.Windows.Forms.Button();
            this.finePage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataFINEGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.submitappeal = new System.Windows.Forms.Button();
            this.appeallistbox = new System.Windows.Forms.ListBox();
            this.akciitexnikumDataSet = new WindowsFormsApp1.akciitexnikumDataSet();
            this.akciitexnikumDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.mainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.activeStockPage.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMYSTOCKGridView)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.stockPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSTOCKGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.finePage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFINEGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akciitexnikumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akciitexnikumDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Controls.Add(this.activeStockPage);
            this.tabControl1.Controls.Add(this.stockPage);
            this.tabControl1.Controls.Add(this.finePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.dataLabel);
            this.mainPage.Controls.Add(this.idField);
            this.mainPage.Controls.Add(this.label2);
            this.mainPage.Controls.Add(this.label1);
            this.mainPage.Controls.Add(this.pictureBox1);
            this.mainPage.Font = new System.Drawing.Font("Leelawadee", 11.75F, System.Drawing.FontStyle.Bold);
            this.mainPage.Location = new System.Drawing.Point(4, 24);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(792, 422);
            this.mainPage.TabIndex = 2;
            this.mainPage.Text = "Главная";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(8, 8);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(113, 19);
            this.dataLabel.TabIndex = 4;
            this.dataLabel.Text = "Дата: 06.05.22";
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(92, 72);
            this.idField.Name = "idField";
            this.idField.ReadOnly = true;
            this.idField.Size = new System.Drawing.Size(152, 26);
            this.idField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер пользователя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главная страница ПРОМОУТЕРА";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // activeStockPage
            // 
            this.activeStockPage.Controls.Add(this.tableLayoutPanel5);
            this.activeStockPage.Location = new System.Drawing.Point(4, 24);
            this.activeStockPage.Name = "activeStockPage";
            this.activeStockPage.Size = new System.Drawing.Size(792, 422);
            this.activeStockPage.TabIndex = 3;
            this.activeStockPage.Text = "Мои акции";
            this.activeStockPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.dataMYSTOCKGridView, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.00948F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.99052F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(792, 422);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // dataMYSTOCKGridView
            // 
            this.dataMYSTOCKGridView.AllowUserToAddRows = false;
            this.dataMYSTOCKGridView.AllowUserToDeleteRows = false;
            this.dataMYSTOCKGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMYSTOCKGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMYSTOCKGridView.Location = new System.Drawing.Point(3, 79);
            this.dataMYSTOCKGridView.Name = "dataMYSTOCKGridView";
            this.dataMYSTOCKGridView.ReadOnly = true;
            this.dataMYSTOCKGridView.Size = new System.Drawing.Size(786, 340);
            this.dataMYSTOCKGridView.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.allFilterBtn, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.comboBoxTypeStock, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.comboBoxPlace, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.comboBoxStatus, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(786, 70);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // allFilterBtn
            // 
            this.allFilterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allFilterBtn.Location = new System.Drawing.Point(396, 38);
            this.allFilterBtn.Name = "allFilterBtn";
            this.allFilterBtn.Size = new System.Drawing.Size(387, 29);
            this.allFilterBtn.TabIndex = 3;
            this.allFilterBtn.Text = "Применить все фильтры";
            this.allFilterBtn.UseVisualStyleBackColor = true;
            this.allFilterBtn.Click += new System.EventHandler(this.allFilterBtn_Click);
            // 
            // comboBoxTypeStock
            // 
            this.comboBoxTypeStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTypeStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeStock.FormattingEnabled = true;
            this.comboBoxTypeStock.Location = new System.Drawing.Point(3, 3);
            this.comboBoxTypeStock.Name = "comboBoxTypeStock";
            this.comboBoxTypeStock.Size = new System.Drawing.Size(387, 23);
            this.comboBoxTypeStock.TabIndex = 4;
            this.comboBoxTypeStock.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeStock_SelectedIndexChanged);
            // 
            // comboBoxPlace
            // 
            this.comboBoxPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlace.FormattingEnabled = true;
            this.comboBoxPlace.Location = new System.Drawing.Point(3, 38);
            this.comboBoxPlace.Name = "comboBoxPlace";
            this.comboBoxPlace.Size = new System.Drawing.Size(387, 23);
            this.comboBoxPlace.TabIndex = 5;
            this.comboBoxPlace.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlace_SelectedIndexChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(396, 3);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(387, 23);
            this.comboBoxStatus.TabIndex = 6;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.tableLayoutPanel2);
            this.stockPage.Font = new System.Drawing.Font("Leelawadee", 11.75F, System.Drawing.FontStyle.Bold);
            this.stockPage.Location = new System.Drawing.Point(4, 24);
            this.stockPage.Name = "stockPage";
            this.stockPage.Padding = new System.Windows.Forms.Padding(3);
            this.stockPage.Size = new System.Drawing.Size(792, 422);
            this.stockPage.TabIndex = 0;
            this.stockPage.Text = "Доступные акции";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataSTOCKGridView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Leelawadee", 11.75F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 416);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataSTOCKGridView
            // 
            this.dataSTOCKGridView.AllowUserToAddRows = false;
            this.dataSTOCKGridView.AllowUserToDeleteRows = false;
            this.dataSTOCKGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSTOCKGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSTOCKGridView.Location = new System.Drawing.Point(3, 3);
            this.dataSTOCKGridView.Name = "dataSTOCKGridView";
            this.dataSTOCKGridView.ReadOnly = true;
            this.dataSTOCKGridView.Size = new System.Drawing.Size(780, 368);
            this.dataSTOCKGridView.TabIndex = 0;
            this.dataSTOCKGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSTOCKGridView_CellEnter);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.registerstockbutton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 377);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(780, 36);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // registerstockbutton
            // 
            this.registerstockbutton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.registerstockbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerstockbutton.Location = new System.Drawing.Point(3, 3);
            this.registerstockbutton.Name = "registerstockbutton";
            this.registerstockbutton.Size = new System.Drawing.Size(774, 30);
            this.registerstockbutton.TabIndex = 0;
            this.registerstockbutton.Text = "Записаться на акцию";
            this.registerstockbutton.UseVisualStyleBackColor = true;
            this.registerstockbutton.Click += new System.EventHandler(this.registerstockbutton_Click);
            // 
            // finePage
            // 
            this.finePage.Controls.Add(this.tableLayoutPanel1);
            this.finePage.Font = new System.Drawing.Font("Leelawadee", 11.75F, System.Drawing.FontStyle.Bold);
            this.finePage.Location = new System.Drawing.Point(4, 24);
            this.finePage.Name = "finePage";
            this.finePage.Padding = new System.Windows.Forms.Padding(3);
            this.finePage.Size = new System.Drawing.Size(792, 422);
            this.finePage.TabIndex = 1;
            this.finePage.Text = "Штрафы";
            this.finePage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataFINEGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.74039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.25961F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataFINEGridView
            // 
            this.dataFINEGridView.AllowUserToAddRows = false;
            this.dataFINEGridView.AllowUserToDeleteRows = false;
            this.dataFINEGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFINEGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFINEGridView.Location = new System.Drawing.Point(3, 3);
            this.dataFINEGridView.Name = "dataFINEGridView";
            this.dataFINEGridView.ReadOnly = true;
            this.dataFINEGridView.Size = new System.Drawing.Size(780, 359);
            this.dataFINEGridView.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.submitappeal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.appeallistbox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 368);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(780, 45);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // submitappeal
            // 
            this.submitappeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitappeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitappeal.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitappeal.Location = new System.Drawing.Point(393, 3);
            this.submitappeal.Name = "submitappeal";
            this.submitappeal.Size = new System.Drawing.Size(384, 39);
            this.submitappeal.TabIndex = 1;
            this.submitappeal.Text = "Подать апелляцию";
            this.submitappeal.UseVisualStyleBackColor = true;
            this.submitappeal.Click += new System.EventHandler(this.submitappeal_Click);
            // 
            // appeallistbox
            // 
            this.appeallistbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appeallistbox.FormattingEnabled = true;
            this.appeallistbox.ItemHeight = 19;
            this.appeallistbox.Location = new System.Drawing.Point(3, 3);
            this.appeallistbox.Name = "appeallistbox";
            this.appeallistbox.Size = new System.Drawing.Size(384, 39);
            this.appeallistbox.TabIndex = 0;
            // 
            // akciitexnikumDataSet
            // 
            this.akciitexnikumDataSet.DataSetName = "akciitexnikumDataSet";
            this.akciitexnikumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // akciitexnikumDataSetBindingSource
            // 
            this.akciitexnikumDataSetBindingSource.DataSource = this.akciitexnikumDataSet;
            this.akciitexnikumDataSetBindingSource.Position = 0;
            // 
            // promouterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "promouterForm";
            this.Text = "Форма промоутера";
            this.Activated += new System.EventHandler(this.promouterForm_Activated);
            this.Load += new System.EventHandler(this.promouterForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.activeStockPage.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMYSTOCKGridView)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.stockPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSTOCKGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.finePage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFINEGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.akciitexnikumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akciitexnikumDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.TabPage finePage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataFINEGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataSTOCKGridView;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button submitappeal;
        private System.Windows.Forms.ListBox appeallistbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabPage activeStockPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dataMYSTOCKGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button allFilterBtn;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Button registerstockbutton;
        private System.Windows.Forms.ComboBox comboBoxTypeStock;
        private System.Windows.Forms.ComboBox comboBoxPlace;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.BindingSource akciitexnikumDataSetBindingSource;
        private akciitexnikumDataSet akciitexnikumDataSet;
    }
}