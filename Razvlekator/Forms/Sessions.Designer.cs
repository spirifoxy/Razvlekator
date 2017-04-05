namespace Razvlekator
{
    partial class Sessions
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_gererateSessions = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button_saveSessions = new System.Windows.Forms.Button();
            this.textBox_startTime = new System.Windows.Forms.NumericUpDown();
            this.textBox_timeBetween = new System.Windows.Forms.NumericUpDown();
            this.textBox_duration = new System.Windows.Forms.NumericUpDown();
            this.textBox_endTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_startTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_timeBetween)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_endTime)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(41, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(326, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Время начала";
            this.Column1.Name = "Column1";
            this.Column1.Width = 147;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Время конца";
            this.Column2.Name = "Column2";
            this.Column2.Width = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Время конца работы аттракциона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время начала работы аттракциона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Продолжительность сеанса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Промежуток между сеансами";
            // 
            // button_gererateSessions
            // 
            this.button_gererateSessions.Location = new System.Drawing.Point(52, 345);
            this.button_gererateSessions.Name = "button_gererateSessions";
            this.button_gererateSessions.Size = new System.Drawing.Size(98, 35);
            this.button_gererateSessions.TabIndex = 9;
            this.button_gererateSessions.Text = "Сгенерировать";
            this.button_gererateSessions.UseVisualStyleBackColor = true;
            this.button_gererateSessions.Click += new System.EventHandler(this.button_generateSessions_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 310);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(211, 310);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // button_saveSessions
            // 
            this.button_saveSessions.Location = new System.Drawing.Point(252, 345);
            this.button_saveSessions.Name = "button_saveSessions";
            this.button_saveSessions.Size = new System.Drawing.Size(98, 35);
            this.button_saveSessions.TabIndex = 12;
            this.button_saveSessions.Text = "Сохранить";
            this.button_saveSessions.UseVisualStyleBackColor = true;
            this.button_saveSessions.Click += new System.EventHandler(this.button_saveSessions_Click);
            // 
            // textBox_startTime
            // 
            this.textBox_startTime.Location = new System.Drawing.Point(247, 25);
            this.textBox_startTime.Name = "textBox_startTime";
            this.textBox_startTime.Size = new System.Drawing.Size(120, 20);
            this.textBox_startTime.TabIndex = 13;
            // 
            // textBox_timeBetween
            // 
            this.textBox_timeBetween.Location = new System.Drawing.Point(247, 112);
            this.textBox_timeBetween.Name = "textBox_timeBetween";
            this.textBox_timeBetween.Size = new System.Drawing.Size(120, 20);
            this.textBox_timeBetween.TabIndex = 14;
            // 
            // textBox_duration
            // 
            this.textBox_duration.Location = new System.Drawing.Point(247, 84);
            this.textBox_duration.Name = "textBox_duration";
            this.textBox_duration.Size = new System.Drawing.Size(120, 20);
            this.textBox_duration.TabIndex = 15;
            // 
            // textBox_endTime
            // 
            this.textBox_endTime.Location = new System.Drawing.Point(247, 55);
            this.textBox_endTime.Name = "textBox_endTime";
            this.textBox_endTime.Size = new System.Drawing.Size(120, 20);
            this.textBox_endTime.TabIndex = 16;
            // 
            // Sessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 392);
            this.Controls.Add(this.textBox_endTime);
            this.Controls.Add(this.textBox_duration);
            this.Controls.Add(this.textBox_timeBetween);
            this.Controls.Add(this.textBox_startTime);
            this.Controls.Add(this.button_saveSessions);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_gererateSessions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sessions";
            this.Text = "Сеансы";
            this.Load += new System.EventHandler(this.Sessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_startTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_timeBetween)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_endTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_gererateSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button_saveSessions;
        private System.Windows.Forms.NumericUpDown textBox_startTime;
        private System.Windows.Forms.NumericUpDown textBox_timeBetween;
        private System.Windows.Forms.NumericUpDown textBox_duration;
        private System.Windows.Forms.NumericUpDown textBox_endTime;
    }
}