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
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonAdminAttractions_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminAttractions().Show();
        }

        private void buttonAdminSalaries_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminSales().Show();
        }
    }
}