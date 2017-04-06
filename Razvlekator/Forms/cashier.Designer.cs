namespace Razvlekator
{
    partial class Cashier
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
            this.comboBoxAttraction = new System.Windows.Forms.ComboBox();
            this.textBoxPriceAdult = new System.Windows.Forms.TextBox();
            this.textBoxPriceKid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Attraction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тип = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBoxDiscountValue = new System.Windows.Forms.ComboBox();
            this.textBoxDiscountValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxGrowthRestriction = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAgeRestriction = new System.Windows.Forms.TextBox();
            this.textBoxWeightRestriction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewAttractions = new System.Windows.Forms.DataGridView();
            this.Column_pk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alkjsf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_growth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CartsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttractions)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAttraction
            // 
            this.comboBoxAttraction.FormattingEnabled = true;
            this.comboBoxAttraction.Items.AddRange(new object[] {
            "Паровозики",
            "Лодочки",
            "Американские горки",
            "Машинки",
            "Карусель \"Лошадки\"",
            "Карусель \"Дракончики\""});
            this.comboBoxAttraction.Location = new System.Drawing.Point(127, 27);
            this.comboBoxAttraction.Name = "comboBoxAttraction";
            this.comboBoxAttraction.Size = new System.Drawing.Size(110, 21);
            this.comboBoxAttraction.TabIndex = 4;
            this.comboBoxAttraction.SelectedIndexChanged += new System.EventHandler(this.comboBoxAttraction_SelectedIndexChanged);
            // 
            // textBoxPriceAdult
            // 
            this.textBoxPriceAdult.Enabled = false;
            this.textBoxPriceAdult.Location = new System.Drawing.Point(108, 58);
            this.textBoxPriceAdult.Name = "textBoxPriceAdult";
            this.textBoxPriceAdult.Size = new System.Drawing.Size(110, 20);
            this.textBoxPriceAdult.TabIndex = 12;
            // 
            // textBoxPriceKid
            // 
            this.textBoxPriceKid.Enabled = false;
            this.textBoxPriceKid.Location = new System.Drawing.Point(108, 28);
            this.textBoxPriceKid.Name = "textBoxPriceKid";
            this.textBoxPriceKid.Size = new System.Drawing.Size(110, 20);
            this.textBoxPriceKid.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "взрослый:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "детский:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attraction,
            this.Column1,
            this.Тип,
            this.Date,
            this.Time,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(607, 201);
            this.dataGridView1.TabIndex = 8;
            // 
            // Attraction
            // 
            this.Attraction.HeaderText = "Аттракцион";
            this.Attraction.Name = "Attraction";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Количество";
            this.Column1.Name = "Column1";
            // 
            // Тип
            // 
            this.Тип.HeaderText = "Тип";
            this.Тип.Name = "Тип";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена";
            this.Column2.Name = "Column2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(661, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 48);
            this.button3.TabIndex = 10;
            this.button3.Text = "Оформить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(538, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 61);
            this.button4.TabIndex = 11;
            this.button4.Text = "Возврат";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "продолжительность:";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Enabled = false;
            this.textBoxDuration.Location = new System.Drawing.Point(127, 58);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(110, 20);
            this.textBoxDuration.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPriceAdult);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxPriceKid);
            this.groupBox1.Location = new System.Drawing.Point(282, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 94);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цена";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxDuration);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.comboBoxAttraction);
            this.groupBox4.Location = new System.Drawing.Point(26, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 94);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Аттракцион";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "наименование:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(26, 183);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(629, 226);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Корзина";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxDiscountValue);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.comboBoxDiscount);
            this.groupBox6.Location = new System.Drawing.Point(538, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(219, 94);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Скидка";
            // 
            // comboBoxDiscountValue
            // 
            this.comboBoxDiscountValue.FormattingEnabled = true;
            this.comboBoxDiscountValue.Location = new System.Drawing.Point(598, 2);
            this.comboBoxDiscountValue.Name = "comboBoxDiscountValue";
            this.comboBoxDiscountValue.Size = new System.Drawing.Size(142, 21);
            this.comboBoxDiscountValue.TabIndex = 29;
            this.comboBoxDiscountValue.Text = "скрытое поле-значения скидок";
            this.comboBoxDiscountValue.Visible = false;
            // 
            // textBoxDiscountValue
            // 
            this.textBoxDiscountValue.Enabled = false;
            this.textBoxDiscountValue.Location = new System.Drawing.Point(127, 62);
            this.textBoxDiscountValue.Name = "textBoxDiscountValue";
            this.textBoxDiscountValue.Size = new System.Drawing.Size(75, 20);
            this.textBoxDiscountValue.TabIndex = 13;
            this.textBoxDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Размер скидки:";
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Items.AddRange(new object[] {
            "Паровозики",
            "Лодочки",
            "Американские горки",
            "Машинки",
            "Карусель \"Лошадки\"",
            "Карусель \"Дракончики\""});
            this.comboBoxDiscount.Location = new System.Drawing.Point(6, 27);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(196, 21);
            this.comboBoxDiscount.TabIndex = 27;
            this.comboBoxDiscount.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscount_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Итого:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(661, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "300 руб.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxGrowthRestriction);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxAgeRestriction);
            this.panel1.Controls.Add(this.textBoxWeightRestriction);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(26, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 61);
            this.panel1.TabIndex = 28;
            // 
            // textBoxGrowthRestriction
            // 
            this.textBoxGrowthRestriction.Enabled = false;
            this.textBoxGrowthRestriction.Location = new System.Drawing.Point(196, 26);
            this.textBoxGrowthRestriction.Name = "textBoxGrowthRestriction";
            this.textBoxGrowthRestriction.Size = new System.Drawing.Size(110, 20);
            this.textBoxGrowthRestriction.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Максимальный рост";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Минимальный возраст";
            // 
            // textBoxAgeRestriction
            // 
            this.textBoxAgeRestriction.Enabled = false;
            this.textBoxAgeRestriction.Location = new System.Drawing.Point(354, 26);
            this.textBoxAgeRestriction.Name = "textBoxAgeRestriction";
            this.textBoxAgeRestriction.Size = new System.Drawing.Size(110, 20);
            this.textBoxAgeRestriction.TabIndex = 23;
            // 
            // textBoxWeightRestriction
            // 
            this.textBoxWeightRestriction.Enabled = false;
            this.textBoxWeightRestriction.Location = new System.Drawing.Point(36, 26);
            this.textBoxWeightRestriction.Name = "textBoxWeightRestriction";
            this.textBoxWeightRestriction.Size = new System.Drawing.Size(110, 20);
            this.textBoxWeightRestriction.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Максимальный вес";
            // 
            // dataGridViewAttractions
            // 
            this.dataGridViewAttractions.AllowUserToAddRows = false;
            this.dataGridViewAttractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttractions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_pk,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.Column3,
            this.alkjsf,
            this.Column4,
            this.Column_growth,
            this.Column6,
            this.Column_CartsCount,
            this.buttonColumn});
            this.dataGridViewAttractions.Enabled = false;
            this.dataGridViewAttractions.Location = new System.Drawing.Point(153, -23);
            this.dataGridViewAttractions.Name = "dataGridViewAttractions";
            this.dataGridViewAttractions.Size = new System.Drawing.Size(288, 46);
            this.dataGridViewAttractions.TabIndex = 29;
            this.dataGridViewAttractions.Visible = false;
            // 
            // Column_pk
            // 
            this.Column_pk.HeaderText = "ключ";
            this.Column_pk.Name = "Column_pk";
            this.Column_pk.ReadOnly = true;
            this.Column_pk.Visible = false;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Аттракцион";
            this.dataGridViewComboBoxColumn1.Items.AddRange(new object[] {
            "Паровозики",
            "Лодочки",
            "Американские горки",
            "Машинки",
            "Карусель \"Лошадки\"",
            "Карусель \"Дракончики\""});
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Цена д.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 426);
            this.Controls.Add(this.comboBoxDiscountValue);
            this.Controls.Add(this.dataGridViewAttractions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Cashier";
            this.Text = "Развлекатор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cashier_FormClosed);
            this.Load += new System.EventHandler(this.Cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttractions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxAttraction;
        private System.Windows.Forms.TextBox textBoxPriceAdult;
        private System.Windows.Forms.TextBox textBoxPriceKid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attraction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDiscountValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxGrowthRestriction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAgeRestriction;
        private System.Windows.Forms.TextBox textBoxWeightRestriction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDiscountValue;
        private System.Windows.Forms.DataGridView dataGridViewAttractions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_pk;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn alkjsf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_growth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CartsCount;
        private System.Windows.Forms.DataGridViewButtonColumn buttonColumn;
    }
}