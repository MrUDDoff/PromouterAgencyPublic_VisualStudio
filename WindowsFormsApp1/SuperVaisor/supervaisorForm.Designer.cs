namespace WindowsFormsApp1
{
    partial class supervaisorForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.showpromoutersbutton = new System.Windows.Forms.Button();
            this.showstocksbutton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.showfinemenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.84383F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.9068F));
            this.tableLayoutPanel2.Controls.Add(this.showpromoutersbutton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.showstocksbutton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.showfinemenu, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 84);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // showpromoutersbutton
            // 
            this.showpromoutersbutton.Location = new System.Drawing.Point(3, 3);
            this.showpromoutersbutton.Name = "showpromoutersbutton";
            this.showpromoutersbutton.Size = new System.Drawing.Size(258, 78);
            this.showpromoutersbutton.TabIndex = 0;
            this.showpromoutersbutton.Text = "Показать промоутеров";
            this.showpromoutersbutton.UseVisualStyleBackColor = true;
            this.showpromoutersbutton.Click += new System.EventHandler(this.showpromoutersbutton_Click);
            // 
            // showstocksbutton
            // 
            this.showstocksbutton.Location = new System.Drawing.Point(267, 3);
            this.showstocksbutton.Name = "showstocksbutton";
            this.showstocksbutton.Size = new System.Drawing.Size(357, 78);
            this.showstocksbutton.TabIndex = 1;
            this.showstocksbutton.Text = "Список акций";
            this.showstocksbutton.UseVisualStyleBackColor = true;
            this.showstocksbutton.Click += new System.EventHandler(this.showstocksbutton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 93);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(794, 354);
            this.dataGridView.TabIndex = 1;
            // 
            // showfinemenu
            // 
            this.showfinemenu.Location = new System.Drawing.Point(630, 3);
            this.showfinemenu.Name = "showfinemenu";
            this.showfinemenu.Size = new System.Drawing.Size(161, 78);
            this.showfinemenu.TabIndex = 2;
            this.showfinemenu.Text = "Штрафы";
            this.showfinemenu.UseVisualStyleBackColor = true;
            this.showfinemenu.Click += new System.EventHandler(this.showfinemenu_Click);
            // 
            // supervaisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "supervaisorForm";
            this.Text = "Форма супервайзера";
            this.Activated += new System.EventHandler(this.supervaisorForm_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button showpromoutersbutton;
        private System.Windows.Forms.Button showstocksbutton;
        private System.Windows.Forms.Button showfinemenu;
    }
}