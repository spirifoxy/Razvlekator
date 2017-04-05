namespace Razvlekator
{
    partial class AdminAttractions
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAttractionsAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_pk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alkjsf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_growth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CartsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_status = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 55);
            this.button2.TabIndex = 24;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_AdminAttractionsBack);
            // 
            // buttonAttractionsAdd
            // 
            this.buttonAttractionsAdd.Location = new System.Drawing.Point(894, 406);
            this.buttonAttractionsAdd.Name = "buttonAttractionsAdd";
            this.buttonAttractionsAdd.Size = new System.Drawing.Size(122, 55);
            this.buttonAttractionsAdd.TabIndex = 27;
            this.buttonAttractionsAdd.Text = "Добавить";
            this.buttonAttractionsAdd.UseVisualStyleBackColor = true;
            this.buttonAttractionsAdd.Click += new System.EventHandler(this.buttonAttractionsAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_pk,
            this.Column1,
            this.Column2,
            this.Column3,
            this.alkjsf,
            this.Column4,
            this.Column_growth,
            this.Column6,
            this.Column_CartsCount,
            this.buttonColumn});
            this.dataGridView1.Location = new System.Drawing.Point(14, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 389);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // Column_pk
            // 
            this.Column_pk.HeaderText = "ключ";
            this.Column_pk.Name = "Column_pk";
            this.Column_pk.ReadOnly = true;
            this.Column_pk.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Аттракцион";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена д.";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена в.";
            this.Column3.Name = "Column3";
            // 
            // alkjsf
            // 
            this.alkjsf.HeaderText = "Продолжительность";
            this.alkjsf.Name = "alkjsf";
            this.alkjsf.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Возраст с";
            this.Column4.Name = "Column4";
            // 
            // Column_growth
            // 
            this.Column_growth.HeaderText = "Рост с";
            this.Column_growth.Name = "Column_growth";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Вес до";
            this.Column6.Name = "Column6";
            // 
            // Column_CartsCount
            // 
            this.Column_CartsCount.HeaderText = "Кол-во телег";
            this.Column_CartsCount.Name = "Column_CartsCount";
            // 
            // buttonColumn
            // 
            this.buttonColumn.HeaderText = "Сеансы";
            this.buttonColumn.Name = "buttonColumn";
            this.buttonColumn.Text = "11";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(764, 406);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(124, 55);
            this.button_save.TabIndex = 29;
            this.button_save.Text = "Сохранить изменения";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_status
            // 
            this.textBox_status.Enabled = false;
            this.textBox_status.ForeColor = System.Drawing.Color.Red;
            this.textBox_status.Location = new System.Drawing.Point(390, 424);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(206, 20);
            this.textBox_status.TabIndex = 32;
            // 
            // AdminAttractions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 473);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAttractionsAdd);
            this.Controls.Add(this.button2);
            this.Name = "AdminAttractions";
            this.Text = "Аттракционы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminAttractions_FormClosed);
            this.Load += new System.EventHandler(this.AdminAttractions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAttractionsAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_pk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn alkjsf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_growth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CartsCount;
        private System.Windows.Forms.DataGridViewButtonColumn buttonColumn;
        private System.Windows.Forms.TextBox textBox_status;
    }
}