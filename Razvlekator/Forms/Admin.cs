﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Razvlekator
{
    public partial class Admin : Form
    {
        Login loginForm;
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(Login _loginForm)
        {
            InitializeComponent();
            loginForm = _loginForm;
        }

        private void buttonAdminAttractions_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminAttractions(this).Show();
        }

        private void buttonAdminSalaries_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminSales(this).Show();
        }

        private void button_adminExit_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }
    }
}