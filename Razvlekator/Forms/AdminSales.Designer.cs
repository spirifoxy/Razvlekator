namespace Razvlekator
{
    partial class AdminSales
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button_sales_back = new System.Windows.Forms.Button();
            this.button_add_sales = new System.Windows.Forms.Button();
            this.Column_pk_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_status = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_pk_discount,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView3.Location = new System.Drawing.Point(12, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(268, 178);
            this.dataGridView3.TabIndex = 26;
            this.dataGridView3.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellEndEdit);
            this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
            // 
            // button_sales_back
            // 
            this.button_sales_back.Location = new System.Drawing.Point(15, 226);
            this.button_sales_back.Name = "button_sales_back";
            this.button_sales_back.Size = new System.Drawing.Size(80, 37);
            this.button_sales_back.TabIndex = 44;
            this.button_sales_back.Text = "Назад";
            this.button_sales_back.UseVisualStyleBackColor = true;
            this.button_sales_back.Click += new System.EventHandler(this.button_sales_back_Click);
            // 
            // button_add_sales
            // 
            this.button_add_sales.Location = new System.Drawing.Point(200, 226);
            this.button_add_sales.Name = "button_add_sales";
            this.button_add_sales.Size = new System.Drawing.Size(80, 37);
            this.button_add_sales.TabIndex = 43;
            this.button_add_sales.Text = "Добавить";
            this.button_add_sales.UseVisualStyleBackColor = true;
            this.button_add_sales.Click += new System.EventHandler(this.button_add_sales_Click);
            // 
            // Column_pk_discount
            // 
            this.Column_pk_discount.HeaderText = "pk_discount";
            this.Column_pk_discount.Name = "Column_pk_discount";
            this.Column_pk_discount.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование соц. группы";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Процент скидки";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(109, 226);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(80, 37);
            this.button_save.TabIndex = 45;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_status
            // 
            this.textBox_status.ForeColor = System.Drawing.Color.Red;
            this.textBox_status.Location = new System.Drawing.Point(15, 283);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(265, 20);
            this.textBox_status.TabIndex = 46;
            this.textBox_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdminSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 341);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_sales_back);
            this.Controls.Add(this.button_add_sales);
            this.Controls.Add(this.dataGridView3);
            this.Name = "AdminSales";
            this.Text = "Скидки";
            this.Load += new System.EventHandler(this.AdminSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button_sales_back;
        private System.Windows.Forms.Button button_add_sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_pk_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_status;
    }
}