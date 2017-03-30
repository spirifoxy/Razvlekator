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
    public partial class AddAttraction : Form
    {
        public AddAttraction()
        {
            InitializeComponent();
        }

        private void buttonAddAttrationSave_Click(object sender, EventArgs e)
        {
            using (var db = new Model())//DBEntities.DiscountContext())
            {
                if (textBoxDuration.Text != "" &&
                    textBoxCostChild.Text != "" &&
                    textBoxCostAdult.Text != "" &&
                    numericUpDown_clockS.Text != "" &&
                    numericUpDown_clockDo.Text != "" &&
                    numericUpDown_countCarts.Text != ""
                    )
                {
                    var newAttraction = new attraction
                    {
                        name = comboBoxAttractionName.Text,
                        duration = Convert.ToInt32(textBoxDuration.Text),
                        ticketpricekid = Convert.ToInt32(textBoxCostChild.Text),     //todouble ??
                        ticketpriceadult = Convert.ToInt32(textBoxCostAdult.Text),
                        starttime = Convert.ToInt32(numericUpDown_clockS.Text),
                        endtime = Convert.ToInt32(numericUpDown_clockDo.Text),
                        cartcount = Convert.ToInt32(numericUpDown_countCarts.Text)
                    };

                    if (textBoxOldFrom.Text != "") newAttraction.agerestriction = Convert.ToInt32(textBoxOldFrom.Text);
                    if (textBoxWeightFrom.Text != "") newAttraction.weightrestriction = Convert.ToInt32(textBoxWeightFrom.Text);
                    if (textBoxOldFrom.Text != "") newAttraction.agerestriction = Convert.ToInt32(textBoxOldFrom.Text);

                    db.attraction.Add(newAttraction);
                    
                    db.SaveChanges();

                    this.Close();
                }
                else label_warning.Visible = true;              
            }
        }

        private void buttonAddAttractionCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
