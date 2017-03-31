namespace Razvlekator
{
    partial class AddSale
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add_sale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name_sale = new System.Windows.Forms.TextBox();
            this.textBox_value_sale = new System.Windows.Forms.TextBox();
            this.label_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 137);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(98, 57);
            this.button_cancel.TabIndex = 42;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Размер скидки";
            // 
            // button_add_sale
            // 
            this.button_add_sale.Location = new System.Drawing.Point(116, 137);
            this.button_add_sale.Name = "button_add_sale";
            this.button_add_sale.Size = new System.Drawing.Size(98, 57);
            this.button_add_sale.TabIndex = 41;
            this.button_add_sale.Text = "Добавить";
            this.button_add_sale.UseVisualStyleBackColor = true;
            this.button_add_sale.Click += new System.EventHandler(this.button_add_sale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Наименование социальной группы";
            // 
            // textBox_name_sale
            // 
            this.textBox_name_sale.Location = new System.Drawing.Point(10, 25);
            this.textBox_name_sale.Name = "textBox_name_sale";
            this.textBox_name_sale.Size = new System.Drawing.Size(204, 20);
            this.textBox_name_sale.TabIndex = 49;
            // 
            // textBox_value_sale
            // 
            this.textBox_value_sale.Location = new System.Drawing.Point(10, 78);
            this.textBox_value_sale.Name = "textBox_value_sale";
            this.textBox_value_sale.Size = new System.Drawing.Size(204, 20);
            this.textBox_value_sale.TabIndex = 50;
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(28, 200);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(176, 13);
            this.label_warning.TabIndex = 51;
            this.label_warning.Text = "Пожалуйста, заполните все поля";
            this.label_warning.Visible = false;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 222);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.textBox_value_sale);
            this.Controls.Add(this.textBox_name_sale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_add_sale);
            this.Name = "AddSale";
            this.Text = "Добавить скидку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add_sale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name_sale;
        private System.Windows.Forms.TextBox textBox_value_sale;
        private System.Windows.Forms.Label label_warning;
    }
}