namespace Razvlekator
{
    partial class Admin
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
            this.buttonAdminAttractions = new System.Windows.Forms.Button();
            this.buttonAdminSalaries = new System.Windows.Forms.Button();
            this.button_adminExit = new System.Windows.Forms.Button();
            this.button_adminSettings = new System.Windows.Forms.Button();
            this.button_stat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdminAttractions
            // 
            this.buttonAdminAttractions.Location = new System.Drawing.Point(54, 62);
            this.buttonAdminAttractions.Name = "buttonAdminAttractions";
            this.buttonAdminAttractions.Size = new System.Drawing.Size(130, 90);
            this.buttonAdminAttractions.TabIndex = 0;
            this.buttonAdminAttractions.Text = "Аттракционы";
            this.buttonAdminAttractions.UseVisualStyleBackColor = true;
            this.buttonAdminAttractions.Click += new System.EventHandler(this.buttonAdminAttractions_Click);
            // 
            // buttonAdminSalaries
            // 
            this.buttonAdminSalaries.Location = new System.Drawing.Point(190, 62);
            this.buttonAdminSalaries.Name = "buttonAdminSalaries";
            this.buttonAdminSalaries.Size = new System.Drawing.Size(130, 90);
            this.buttonAdminSalaries.TabIndex = 1;
            this.buttonAdminSalaries.Text = "Скидки";
            this.buttonAdminSalaries.UseVisualStyleBackColor = true;
            this.buttonAdminSalaries.Click += new System.EventHandler(this.buttonAdminSalaries_Click);
            // 
            // button_adminExit
            // 
            this.button_adminExit.Location = new System.Drawing.Point(285, 263);
            this.button_adminExit.Name = "button_adminExit";
            this.button_adminExit.Size = new System.Drawing.Size(80, 38);
            this.button_adminExit.TabIndex = 2;
            this.button_adminExit.Text = "Выход";
            this.button_adminExit.UseVisualStyleBackColor = true;
            this.button_adminExit.Click += new System.EventHandler(this.button_adminExit_Click);
            // 
            // button_adminSettings
            // 
            this.button_adminSettings.Location = new System.Drawing.Point(88, 195);
            this.button_adminSettings.Name = "button_adminSettings";
            this.button_adminSettings.Size = new System.Drawing.Size(96, 52);
            this.button_adminSettings.TabIndex = 3;
            this.button_adminSettings.Text = "Настройки";
            this.button_adminSettings.UseVisualStyleBackColor = true;
            this.button_adminSettings.Click += new System.EventHandler(this.button_adminSettings_Click);
            // 
            // button_stat
            // 
            this.button_stat.Location = new System.Drawing.Point(190, 195);
            this.button_stat.Name = "button_stat";
            this.button_stat.Size = new System.Drawing.Size(96, 52);
            this.button_stat.TabIndex = 4;
            this.button_stat.Text = "Статистика";
            this.button_stat.UseVisualStyleBackColor = true;
            this.button_stat.Click += new System.EventHandler(this.button_stat_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 313);
            this.Controls.Add(this.button_stat);
            this.Controls.Add(this.button_adminSettings);
            this.Controls.Add(this.button_adminExit);
            this.Controls.Add(this.buttonAdminSalaries);
            this.Controls.Add(this.buttonAdminAttractions);
            this.Name = "Admin";
            this.Text = "Администратор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdminAttractions;
        private System.Windows.Forms.Button buttonAdminSalaries;
        private System.Windows.Forms.Button button_adminExit;
        private System.Windows.Forms.Button button_adminSettings;
        private System.Windows.Forms.Button button_stat;
    }
}