using System;
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
    public partial class AdminAttractions : Form
    {
        public AdminAttractions()
        {
            InitializeComponent();
        }

        private void buttonAttractionsAdd_Click(object sender, EventArgs e)
        {
            new AddAttraction().Show();
        }
    }
}
