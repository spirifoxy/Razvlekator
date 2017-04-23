using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Razvlekator.Forms
{
    public partial class Settings : Form
    {
        Admin adminForm;
        public Settings()
        {
            InitializeComponent();
        }
        public Settings(Admin _adminForm)
        {
            InitializeComponent();
            adminForm = _adminForm;
        }


        private void button_saveSettings_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string[] lines = { textBox_server.Text, textBox_db.Text, textBox_user.Text, textBox_pass.Text };
            File.WriteAllLines(currentDirectory + @"\" + "config.txt", lines);
            
            Config.ApplySettings(lines[0], lines[1], lines[2], lines[3]);

            this.Close();
            adminForm.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string[] lines = File.ReadAllLines(currentDirectory + @"\" + "config.txt");
            textBox_server.Text = lines[0];
            textBox_db.Text = lines[1];
            textBox_user.Text = lines[2];
            textBox_pass.Text = lines[3];
        }
    }
}
