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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxAttraction = new System.Windows.Forms.ComboBox();
            this.textBoxPriceAdult = new System.Windows.Forms.TextBox();
            this.textBoxPriceKid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddAttraction_button = new System.Windows.Forms.Button();
            this.attractions_dataGridView = new System.Windows.Forms.DataGridView();
            this.AttractionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeInCartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearAttractions_button = new System.Windows.Forms.Button();
            this.CheckOut_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxDiscountValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalPrice_label = new System.Windows.Forms.Label();
            this.textBoxGrowthRestriction = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAgeRestriction = new System.Windows.Forms.TextBox();
            this.textBoxWeightRestriction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.attractions_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.comboBoxAttraction.TabIndex = 0;
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
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Взрослый:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Детский:";
            // 
            // AddAttraction_button
            // 
            this.AddAttraction_button.Location = new System.Drawing.Point(661, 189);
            this.AddAttraction_button.Name = "AddAttraction_button";
            this.AddAttraction_button.Size = new System.Drawing.Size(95, 50);
            this.AddAttraction_button.TabIndex = 2;
            this.AddAttraction_button.Text = "Добавить";
            this.AddAttraction_button.UseVisualStyleBackColor = true;
            this.AddAttraction_button.Click += new System.EventHandler(this.AddAttraction_button_Click);
            // 
            // attractions_dataGridView
            // 
            this.attractions_dataGridView.AllowUserToAddRows = false;
            this.attractions_dataGridView.AllowUserToDeleteRows = false;
            this.attractions_dataGridView.AllowUserToResizeRows = false;
            this.attractions_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attractions_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttractionColumn,
            this.CountColumn,
            this.TypeColumn,
            this.DateColumn,
            this.TimeColumn,
            this.PriceColumn,
            this.placeInCartColumn});
            this.attractions_dataGridView.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attractions_dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.attractions_dataGridView.Location = new System.Drawing.Point(9, 19);
            this.attractions_dataGridView.MultiSelect = false;
            this.attractions_dataGridView.Name = "attractions_dataGridView";
            this.attractions_dataGridView.RowHeadersVisible = false;
            this.attractions_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attractions_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attractions_dataGridView.Size = new System.Drawing.Size(620, 201);
            this.attractions_dataGridView.TabIndex = 3;
            this.attractions_dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.attractions_dataGridView_CellBeginEdit);
            this.attractions_dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.attractions_dataGridView_CellEndEdit);
            this.attractions_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.attractions_dataGridView_CellValueChanged);
            this.attractions_dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.attractions_dataGridView_MouseClick);
            // 
            // AttractionColumn
            // 
            this.AttractionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.AttractionColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.AttractionColumn.HeaderText = "Аттракцион";
            this.AttractionColumn.MinimumWidth = 100;
            this.AttractionColumn.Name = "AttractionColumn";
            this.AttractionColumn.ReadOnly = true;
            // 
            // CountColumn
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.CountColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.CountColumn.HeaderText = "Количество";
            this.CountColumn.MaxInputLength = 2;
            this.CountColumn.MinimumWidth = 20;
            this.CountColumn.Name = "CountColumn";
            this.CountColumn.Width = 80;
            // 
            // TypeColumn
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.TypeColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.TypeColumn.HeaderText = "Тип";
            this.TypeColumn.MinimumWidth = 100;
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DateColumn
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.DateColumn.HeaderText = "Дата";
            this.DateColumn.MinimumWidth = 100;
            this.DateColumn.Name = "DateColumn";
            // 
            // TimeColumn
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.TimeColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.TimeColumn.HeaderText = "Время";
            this.TimeColumn.MinimumWidth = 100;
            this.TimeColumn.Name = "TimeColumn";
            // 
            // PriceColumn
            // 
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.PriceColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.MinimumWidth = 80;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 80;
            // 
            // placeInCartColumn
            // 
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.placeInCartColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.placeInCartColumn.HeaderText = "Место";
            this.placeInCartColumn.MinimumWidth = 50;
            this.placeInCartColumn.Name = "placeInCartColumn";
            this.placeInCartColumn.Width = 50;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // ClearAttractions_button
            // 
            this.ClearAttractions_button.Location = new System.Drawing.Point(661, 243);
            this.ClearAttractions_button.Name = "ClearAttractions_button";
            this.ClearAttractions_button.Size = new System.Drawing.Size(95, 50);
            this.ClearAttractions_button.TabIndex = 9;
            this.ClearAttractions_button.Text = "Очистить";
            this.ClearAttractions_button.UseVisualStyleBackColor = true;
            this.ClearAttractions_button.Click += new System.EventHandler(this.ClearAttractions_button_Click);
            // 
            // CheckOut_button
            // 
            this.CheckOut_button.Location = new System.Drawing.Point(661, 299);
            this.CheckOut_button.Name = "CheckOut_button";
            this.CheckOut_button.Size = new System.Drawing.Size(95, 50);
            this.CheckOut_button.TabIndex = 10;
            this.CheckOut_button.Text = "Оформить";
            this.CheckOut_button.UseVisualStyleBackColor = true;
            this.CheckOut_button.Click += new System.EventHandler(this.CheckOut_button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(538, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 65);
            this.button4.TabIndex = 11;
            this.button4.Text = "Возврат";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Продолжительность:";
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
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Наименование:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.attractions_dataGridView);
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
            this.comboBoxDiscount.TabIndex = 1;
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
            // TotalPrice_label
            // 
            this.TotalPrice_label.AutoSize = true;
            this.TotalPrice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.TotalPrice_label.Location = new System.Drawing.Point(661, 381);
            this.TotalPrice_label.Name = "TotalPrice_label";
            this.TotalPrice_label.Size = new System.Drawing.Size(20, 22);
            this.TotalPrice_label.TabIndex = 27;
            this.TotalPrice_label.Text = "0";
            // 
            // textBoxGrowthRestriction
            // 
            this.textBoxGrowthRestriction.Enabled = false;
            this.textBoxGrowthRestriction.Location = new System.Drawing.Point(187, 32);
            this.textBoxGrowthRestriction.Name = "textBoxGrowthRestriction";
            this.textBoxGrowthRestriction.Size = new System.Drawing.Size(110, 20);
            this.textBoxGrowthRestriction.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Максимальный рост";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Минимальный возраст";
            // 
            // textBoxAgeRestriction
            // 
            this.textBoxAgeRestriction.Enabled = false;
            this.textBoxAgeRestriction.Location = new System.Drawing.Point(364, 32);
            this.textBoxAgeRestriction.Name = "textBoxAgeRestriction";
            this.textBoxAgeRestriction.Size = new System.Drawing.Size(110, 20);
            this.textBoxAgeRestriction.TabIndex = 23;
            // 
            // textBoxWeightRestriction
            // 
            this.textBoxWeightRestriction.Enabled = false;
            this.textBoxWeightRestriction.Location = new System.Drawing.Point(9, 32);
            this.textBoxWeightRestriction.Name = "textBoxWeightRestriction";
            this.textBoxWeightRestriction.Size = new System.Drawing.Size(110, 20);
            this.textBoxWeightRestriction.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Максимальный вес";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxWeightRestriction);
            this.groupBox2.Controls.Add(this.textBoxGrowthRestriction);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxAgeRestriction);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(26, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 65);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ограничения";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(723, 368);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(32, 32);
            this.buttonPrint.TabIndex = 31;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Visible = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 426);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TotalPrice_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddAttraction_button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CheckOut_button);
            this.Controls.Add(this.ClearAttractions_button);
            this.Name = "Cashier";
            this.Text = "Развлекатор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cashier_FormClosed);
            this.Load += new System.EventHandler(this.Cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attractions_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxAttraction;
        private System.Windows.Forms.TextBox textBoxPriceAdult;
        private System.Windows.Forms.TextBox textBoxPriceKid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddAttraction_button;
        private System.Windows.Forms.Button ClearAttractions_button;
        private System.Windows.Forms.Button CheckOut_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalPrice_label;
        private System.Windows.Forms.TextBox textBoxDiscountValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxGrowthRestriction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAgeRestriction;
        private System.Windows.Forms.TextBox textBoxWeightRestriction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView attractions_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeInCartColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Button buttonPrint;
    }
}