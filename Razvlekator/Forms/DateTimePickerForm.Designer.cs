namespace Razvlekator.Forms
{
    partial class DateTimePickerForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("10:15");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("10:10");
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.Date_groupBox = new System.Windows.Forms.GroupBox();
            this.Time_groupBox = new System.Windows.Forms.GroupBox();
            this.Sessions_listView = new System.Windows.Forms.ListView();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Date_groupBox.SuspendLayout();
            this.Time_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(9, 27);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(118, 20);
            this.datePicker.TabIndex = 0;
            this.datePicker.Value = new System.DateTime(2017, 4, 9, 3, 24, 13, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // Date_groupBox
            // 
            this.Date_groupBox.Controls.Add(this.datePicker);
            this.Date_groupBox.Location = new System.Drawing.Point(12, 12);
            this.Date_groupBox.Name = "Date_groupBox";
            this.Date_groupBox.Size = new System.Drawing.Size(385, 70);
            this.Date_groupBox.TabIndex = 35;
            this.Date_groupBox.TabStop = false;
            this.Date_groupBox.Text = "Дата";
            // 
            // Time_groupBox
            // 
            this.Time_groupBox.Controls.Add(this.Sessions_listView);
            this.Time_groupBox.Location = new System.Drawing.Point(12, 88);
            this.Time_groupBox.Name = "Time_groupBox";
            this.Time_groupBox.Size = new System.Drawing.Size(385, 250);
            this.Time_groupBox.TabIndex = 36;
            this.Time_groupBox.TabStop = false;
            this.Time_groupBox.Text = "Время";
            // 
            // Sessions_listView
            // 
            this.Sessions_listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.Sessions_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.Sessions_listView.LabelWrap = false;
            this.Sessions_listView.Location = new System.Drawing.Point(9, 19);
            this.Sessions_listView.MultiSelect = false;
            this.Sessions_listView.Name = "Sessions_listView";
            this.Sessions_listView.Size = new System.Drawing.Size(370, 225);
            this.Sessions_listView.TabIndex = 1;
            this.Sessions_listView.TileSize = new System.Drawing.Size(40, 50);
            this.Sessions_listView.UseCompatibleStateImageBehavior = false;
            // 
            // Confirm_button
            // 
            this.Confirm_button.Location = new System.Drawing.Point(127, 342);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(132, 29);
            this.Confirm_button.TabIndex = 37;
            this.Confirm_button.Text = "Выбрать";
            this.Confirm_button.UseVisualStyleBackColor = true;
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Location = new System.Drawing.Point(265, 342);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(132, 29);
            this.Cancel_button.TabIndex = 38;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // DateTimePickerForm
            // 
            this.AcceptButton = this.Confirm_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(409, 415);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Confirm_button);
            this.Controls.Add(this.Time_groupBox);
            this.Controls.Add(this.Date_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DateTimePickerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Выбор времени и даты";
            this.Load += new System.EventHandler(this.DateTimePickerForm_Load);
            this.Date_groupBox.ResumeLayout(false);
            this.Time_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.GroupBox Date_groupBox;
        private System.Windows.Forms.GroupBox Time_groupBox;
        private System.Windows.Forms.ListView Sessions_listView;
        private System.Windows.Forms.Button Confirm_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}