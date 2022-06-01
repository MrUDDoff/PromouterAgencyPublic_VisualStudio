
namespace WindowsFormsApp1.Manager
{
    partial class editplacesForm
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
            this.listBoxplacesforstock = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxplaces = new System.Windows.Forms.ComboBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddPlacesToStock = new System.Windows.Forms.Button();
            this.textBoxforaddplace = new System.Windows.Forms.TextBox();
            this.comboBoxToAddPlaces = new System.Windows.Forms.ComboBox();
            this.buttonAddPlace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxplacesforstock
            // 
            this.listBoxplacesforstock.FormattingEnabled = true;
            this.listBoxplacesforstock.Location = new System.Drawing.Point(13, 11);
            this.listBoxplacesforstock.Name = "listBoxplacesforstock";
            this.listBoxplacesforstock.Size = new System.Drawing.Size(245, 160);
            this.listBoxplacesforstock.TabIndex = 1;
            this.listBoxplacesforstock.DoubleClick += new System.EventHandler(this.listBoxplacesforstock_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Управление местами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-123, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(583, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------------------------";
            // 
            // comboBoxplaces
            // 
            this.comboBoxplaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxplaces.FormattingEnabled = true;
            this.comboBoxplaces.Location = new System.Drawing.Point(12, 288);
            this.comboBoxplaces.Name = "comboBoxplaces";
            this.comboBoxplaces.Size = new System.Drawing.Size(194, 21);
            this.comboBoxplaces.TabIndex = 4;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(212, 312);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(21, 23);
            this.buttonPlus.TabIndex = 5;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(212, 286);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(21, 23);
            this.buttonMinus.TabIndex = 6;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-182, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(583, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------------------------";
            // 
            // buttonAddPlacesToStock
            // 
            this.buttonAddPlacesToStock.Location = new System.Drawing.Point(2, 354);
            this.buttonAddPlacesToStock.Name = "buttonAddPlacesToStock";
            this.buttonAddPlacesToStock.Size = new System.Drawing.Size(267, 26);
            this.buttonAddPlacesToStock.TabIndex = 9;
            this.buttonAddPlacesToStock.Text = "Применить";
            this.buttonAddPlacesToStock.UseVisualStyleBackColor = true;
            this.buttonAddPlacesToStock.Click += new System.EventHandler(this.buttonAddPlacesToStock_Click);
            // 
            // textBoxforaddplace
            // 
            this.textBoxforaddplace.Location = new System.Drawing.Point(12, 312);
            this.textBoxforaddplace.Name = "textBoxforaddplace";
            this.textBoxforaddplace.Size = new System.Drawing.Size(194, 20);
            this.textBoxforaddplace.TabIndex = 10;
            // 
            // comboBoxToAddPlaces
            // 
            this.comboBoxToAddPlaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToAddPlaces.FormattingEnabled = true;
            this.comboBoxToAddPlaces.Location = new System.Drawing.Point(12, 182);
            this.comboBoxToAddPlaces.Name = "comboBoxToAddPlaces";
            this.comboBoxToAddPlaces.Size = new System.Drawing.Size(246, 21);
            this.comboBoxToAddPlaces.TabIndex = 11;
            // 
            // buttonAddPlace
            // 
            this.buttonAddPlace.Location = new System.Drawing.Point(12, 209);
            this.buttonAddPlace.Name = "buttonAddPlace";
            this.buttonAddPlace.Size = new System.Drawing.Size(246, 36);
            this.buttonAddPlace.TabIndex = 12;
            this.buttonAddPlace.Text = "Добавить";
            this.buttonAddPlace.UseVisualStyleBackColor = true;
            this.buttonAddPlace.Click += new System.EventHandler(this.buttonAddPlace_Click);
            // 
            // editplacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 392);
            this.Controls.Add(this.buttonAddPlace);
            this.Controls.Add(this.comboBoxToAddPlaces);
            this.Controls.Add(this.textBoxforaddplace);
            this.Controls.Add(this.buttonAddPlacesToStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.comboBoxplaces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxplacesforstock);
            this.Name = "editplacesForm";
            this.Text = "placesForm";
            this.Activated += new System.EventHandler(this.editplacesForm_Activated);
            this.Load += new System.EventHandler(this.editplacesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxplacesforstock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxplaces;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddPlacesToStock;
        private System.Windows.Forms.TextBox textBoxforaddplace;
        private System.Windows.Forms.ComboBox comboBoxToAddPlaces;
        private System.Windows.Forms.Button buttonAddPlace;
    }
}