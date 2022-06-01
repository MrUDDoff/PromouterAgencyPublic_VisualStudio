namespace WindowsFormsApp1.Manager
{
    partial class newstockForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.limitField = new System.Windows.Forms.NumericUpDown();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.typeField = new System.Windows.Forms.ListBox();
            this.paymentField = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.newstockButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentField)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.limitField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.startDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.endDate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.typeField, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.paymentField, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.55654F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.00509F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.01018F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.01391F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.00453F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.40975F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 260);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Максимальное количество";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата начала";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Coral;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата конца";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вид акции";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Coral;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Почасовая оплата";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название акции";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameField
            // 
            this.nameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameField.Location = new System.Drawing.Point(194, 6);
            this.nameField.MaxLength = 50;
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(179, 67);
            this.nameField.TabIndex = 7;
            // 
            // limitField
            // 
            this.limitField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.limitField.Location = new System.Drawing.Point(194, 82);
            this.limitField.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.limitField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.limitField.Name = "limitField";
            this.limitField.Size = new System.Drawing.Size(179, 23);
            this.limitField.TabIndex = 8;
            this.limitField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "dd MM yy \'г\', HH:mm:ss ";
            this.startDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(194, 118);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(179, 23);
            this.startDate.TabIndex = 9;
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "dd MM yy \'г\', HH:mm:ss ";
            this.endDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(194, 154);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(179, 23);
            this.endDate.TabIndex = 10;
            // 
            // typeField
            // 
            this.typeField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeField.FormattingEnabled = true;
            this.typeField.ItemHeight = 16;
            this.typeField.Location = new System.Drawing.Point(194, 190);
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(179, 27);
            this.typeField.TabIndex = 11;
            // 
            // paymentField
            // 
            this.paymentField.DecimalPlaces = 2;
            this.paymentField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentField.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.paymentField.Location = new System.Drawing.Point(194, 226);
            this.paymentField.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.paymentField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.paymentField.Name = "paymentField";
            this.paymentField.Size = new System.Drawing.Size(179, 23);
            this.paymentField.TabIndex = 12;
            this.paymentField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.newstockButton, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.75177F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.24823F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(385, 315);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // newstockButton
            // 
            this.newstockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newstockButton.Location = new System.Drawing.Point(3, 269);
            this.newstockButton.Name = "newstockButton";
            this.newstockButton.Size = new System.Drawing.Size(379, 43);
            this.newstockButton.TabIndex = 1;
            this.newstockButton.Text = "Создать";
            this.newstockButton.UseVisualStyleBackColor = true;
            this.newstockButton.Click += new System.EventHandler(this.newstockButton_Click);
            // 
            // newstockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 315);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Font = new System.Drawing.Font("Arial", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "newstockForm";
            this.Text = "Создание новой акции";
            this.Activated += new System.EventHandler(this.newstockForm_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentField)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown limitField;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button newstockButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown paymentField;
        internal System.Windows.Forms.TextBox nameField;
        internal System.Windows.Forms.ListBox typeField;
    }
}