namespace WindowsFormsApp1
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.telephoneField = new System.Windows.Forms.TextBox();
            this.lastField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.akciitexnikumDataSet = new WindowsFormsApp1.akciitexnikumDataSet();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akciitexnikumDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(89, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(99, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Логин";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(43)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(34, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(55, 388);
            this.passField.MaxLength = 30;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(184, 20);
            this.passField.TabIndex = 6;
            // 
            // loginField
            // 
            this.loginField.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.loginField.Location = new System.Drawing.Point(55, 331);
            this.loginField.MaxLength = 30;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(184, 20);
            this.loginField.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 66);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(285, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(109, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(79, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Фамилия";
            // 
            // firstField
            // 
            this.firstField.Location = new System.Drawing.Point(56, 103);
            this.firstField.MaxLength = 30;
            this.firstField.Name = "firstField";
            this.firstField.Size = new System.Drawing.Size(184, 20);
            this.firstField.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(78, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Телефон";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(78, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "Отчество";
            // 
            // telephoneField
            // 
            this.telephoneField.Location = new System.Drawing.Point(56, 274);
            this.telephoneField.MaxLength = 11;
            this.telephoneField.Name = "telephoneField";
            this.telephoneField.Size = new System.Drawing.Size(184, 20);
            this.telephoneField.TabIndex = 4;
            // 
            // lastField
            // 
            this.lastField.Location = new System.Drawing.Point(56, 217);
            this.lastField.MaxLength = 30;
            this.lastField.Name = "lastField";
            this.lastField.Size = new System.Drawing.Size(184, 20);
            this.lastField.TabIndex = 3;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(56, 160);
            this.nameField.MaxLength = 30;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(184, 20);
            this.nameField.TabIndex = 2;
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.DisplayMember = "idРоль";
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(55, 432);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(185, 21);
            this.comboBoxRoles.TabIndex = 20;
            this.comboBoxRoles.ValueMember = "idРоль";
            // 
            // akciitexnikumDataSet
            // 
            this.akciitexnikumDataSet.DataSetName = "akciitexnikumDataSet";
            this.akciitexnikumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 542);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.telephoneField);
            this.Controls.Add(this.lastField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.firstField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akciitexnikumDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox telephoneField;
        private System.Windows.Forms.TextBox lastField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private akciitexnikumDataSet akciitexnikumDataSet;
    }
}