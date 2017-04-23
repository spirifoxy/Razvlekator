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

namespace Razvlekator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //if (comboBoxRole.SelectedItem.ToString() == "Администратор")
            //{
            //    this.Hide();
            //    new Admin(this).Show();
            //    //Потом при закрытии админской формы эта форма логина так и остается висеть Hide
            //}
            this.Hide();
            switch (comboBoxRole.SelectedItem.ToString())
            {
                case "Администратор":
                    new Admin(this).Show();
                    //Потом при закрытии админской формы эта форма логина так и остается висеть Hide
                    break;
                case "Кассир":
                    new Cashier(this).Show();
                    break;
                default:
                    break;
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string[] lines = File.ReadAllLines(currentDirectory + @"\" + "config.txt");
            Config.ApplySettings(lines[0], lines[1], lines[2], lines[3]);
        }
    }
}

