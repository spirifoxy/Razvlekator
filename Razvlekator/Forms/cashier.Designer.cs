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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.DatePicker_panel = new System.Windows.Forms.Panel();
            this.CancelDatePicker_button = new System.Windows.Forms.Button();
            this.OKDatePicker_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker_panel = new System.Windows.Forms.Panel();
            this.CancelTimePicker_button = new System.Windows.Forms.Button();
            this.OKTimePicker_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.attractions_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DatePicker_panel.SuspendLayout();
            this.TimePicker_panel.SuspendLayout();
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
            this.AddAttraction_button.TabIndex = 5;
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
            this.PriceColumn});
            this.attractions_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attractions_dataGridView.Location = new System.Drawing.Point(9, 19);
            this.attractions_dataGridView.MultiSelect = false;
            this.attractions_dataGridView.Name = "attractions_dataGridView";
            this.attractions_dataGridView.RowHeadersVisible = false;
            this.attractions_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attractions_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.attractions_dataGridView.Size = new System.Drawing.Size(620, 201);
            this.attractions_dataGridView.TabIndex = 8;
            this.attractions_dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.attractions_dataGridView_CellBeginEdit);
            this.attractions_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.attractions_dataGridView_CellValueChanged);
            // 
            // AttractionColumn
            // 
            this.AttractionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.AttractionColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.AttractionColumn.HeaderText = "Аттракцион";
            this.AttractionColumn.MinimumWidth = 100;
            this.AttractionColumn.Name = "AttractionColumn";
            this.AttractionColumn.ReadOnly = true;
            // 
            // CountColumn
            // 
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.CountColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.CountColumn.HeaderText = "Количество";
            this.CountColumn.MaxInputLength = 2;
            this.CountColumn.MinimumWidth = 20;
            this.CountColumn.Name = "CountColumn";
            this.CountColumn.Width = 80;
            // 
            // TypeColumn
            // 
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.TypeColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.TypeColumn.HeaderText = "Тип";
            this.TypeColumn.MinimumWidth = 100;
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DateColumn
            // 
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.DateColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.DateColumn.HeaderText = "Дата";
            this.DateColumn.MinimumWidth = 100;
            this.DateColumn.Name = "DateColumn";
            // 
            // TimeColumn
            // 
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.TimeColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.TimeColumn.HeaderText = "Время";
            this.TimeColumn.MinimumWidth = 100;
            this.TimeColumn.Name = "TimeColumn";
            // 
            // PriceColumn
            // 
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.PriceColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.MinimumWidth = 80;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 80;
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
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(538, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 65);
            this.button4.TabIndex = 11;
            this.button4.Text = "Возврат";
            this.button4.UseVisualStyleBackColor = true;
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
            // DatePicker_panel
            // 
            this.DatePicker_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatePicker_panel.Controls.Add(this.CancelDatePicker_button);
            this.DatePicker_panel.Controls.Add(this.OKDatePicker_button);
            this.DatePicker_panel.Controls.Add(this.label10);
            this.DatePicker_panel.Controls.Add(this.datePicker);
            this.DatePicker_panel.Location = new System.Drawing.Point(868, 12);
            this.DatePicker_panel.Name = "DatePicker_panel";
            this.DatePicker_panel.Size = new System.Drawing.Size(170, 82);
            this.DatePicker_panel.TabIndex = 31;
            // 
            // CancelDatePicker_button
            // 
            this.CancelDatePicker_button.Location = new System.Drawing.Point(87, 47);
            this.CancelDatePicker_button.Name = "CancelDatePicker_button";
            this.CancelDatePicker_button.Size = new System.Drawing.Size(75, 23);
            this.CancelDatePicker_button.TabIndex = 3;
            this.CancelDatePicker_button.Text = "Отмена";
            this.CancelDatePicker_button.UseVisualStyleBackColor = true;
            this.CancelDatePicker_button.Click += new System.EventHandler(this.CancelDatePicker_button_Click);
            // 
            // OKDatePicker_button
            // 
            this.OKDatePicker_button.Location = new System.Drawing.Point(6, 47);
            this.OKDatePicker_button.Name = "OKDatePicker_button";
            this.OKDatePicker_button.Size = new System.Drawing.Size(75, 23);
            this.OKDatePicker_button.TabIndex = 2;
            this.OKDatePicker_button.Text = "OK";
            this.OKDatePicker_button.UseVisualStyleBackColor = true;
            this.OKDatePicker_button.Click += new System.EventHandler(this.OKDatePicker_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Выберите дату сеанса";
            // 
            // datePicker
            // 
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(26, 19);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(118, 20);
            this.datePicker.TabIndex = 0;
            this.datePicker.Value = new System.DateTime(2017, 4, 9, 3, 24, 13, 0);
            // 
            // TimePicker_panel
            // 
            this.TimePicker_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimePicker_panel.Controls.Add(this.CancelTimePicker_button);
            this.TimePicker_panel.Controls.Add(this.OKTimePicker_button);
            this.TimePicker_panel.Controls.Add(this.label11);
            this.TimePicker_panel.Controls.Add(this.timePicker);
            this.TimePicker_panel.Location = new System.Drawing.Point(868, 112);
            this.TimePicker_panel.Name = "TimePicker_panel";
            this.TimePicker_panel.Size = new System.Drawing.Size(170, 74);
            this.TimePicker_panel.TabIndex = 32;
            // 
            // CancelTimePicker_button
            // 
            this.CancelTimePicker_button.Location = new System.Drawing.Point(87, 41);
            this.CancelTimePicker_button.Name = "CancelTimePicker_button";
            this.CancelTimePicker_button.Size = new System.Drawing.Size(75, 23);
            this.CancelTimePicker_button.TabIndex = 5;
            this.CancelTimePicker_button.Text = "Отмена";
            this.CancelTimePicker_button.UseVisualStyleBackColor = true;
            this.CancelTimePicker_button.Click += new System.EventHandler(this.CancelTimePicker_button_Click);
            // 
            // OKTimePicker_button
            // 
            this.OKTimePicker_button.Location = new System.Drawing.Point(6, 41);
            this.OKTimePicker_button.Name = "OKTimePicker_button";
            this.OKTimePicker_button.Size = new System.Drawing.Size(75, 23);
            this.OKTimePicker_button.TabIndex = 4;
            this.OKTimePicker_button.Text = "OK";
            this.OKTimePicker_button.UseVisualStyleBackColor = true;
            this.OKTimePicker_button.Click += new System.EventHandler(this.OKTimePicker_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Выберите время сеанса";
            // 
            // timePicker
            // 
            this.timePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(19, 19);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(128, 20);
            this.timePicker.TabIndex = 0;
            this.timePicker.Value = new System.DateTime(2017, 4, 9, 3, 24, 13, 0);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 426);
            this.Controls.Add(this.TimePicker_panel);
            this.Controls.Add(this.DatePicker_panel);
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
            this.DatePicker_panel.ResumeLayout(false);
            this.DatePicker_panel.PerformLayout();
            this.TimePicker_panel.ResumeLayout(false);
            this.TimePicker_panel.PerformLayout();
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
        private System.Windows.Forms.DataGridView attractions_dataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.Panel DatePicker_panel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Panel TimePicker_panel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button CancelDatePicker_button;
        private System.Windows.Forms.Button OKDatePicker_button;
        private System.Windows.Forms.Button CancelTimePicker_button;
        private System.Windows.Forms.Button OKTimePicker_button;
    }
}