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
                    textBoxCostAdult.Text != ""
                    )
                {
                    var newAttraction = new attraction
                    {
                        name = comboBoxAttractionName.Text,
                        duration = Convert.ToInt32(textBoxDuration.Text),
                        ticketpricekid = Convert.ToInt32(textBoxCostChild.Text),     //todouble ??
                        ticketpriceadult = Convert.ToInt32(textBoxCostAdult.Text)
                    };

                    if (textBoxOldFrom.Text != "") newAttraction.agerestrictionfrom = Convert.ToInt32(textBoxOldFrom.Text);
                    if (textBoxOldTo.Text != "") newAttraction.agerestrictionto = Convert.ToInt32(textBoxOldTo.Text);
                    if (textBoxWeightFrom.Text != "") newAttraction.weightrestrictionfrom = Convert.ToInt32(textBoxWeightFrom.Text);
                    if (textBoxWeightTo.Text != "") newAttraction.weightrestrictionto = Convert.ToInt32(textBoxWeightTo.Text);

                    //Не работает. А должно.

                    //var newAttraction2 = new attraction
                    //{
                    //    name = "imya",
                    //    duration = 100,
                    //    ticketpricekid = 200,     //todouble ??
                    //    ticketpriceadult = 300,
                    //    agerestrictionfrom = 10,
                    //    agerestrictionto = 85,
                    //    weightrestrictionfrom = 20,
                    //    weightrestrictionto = 150,
                    //    cartcount = 1,
                    //    starttime = 11,
                    //    endtime = 12,
                    //    growthrestrictionfrom = 20,
                    //    growthrestrictionto = 220,
                    //    pk_attraction = 50

                    //};


                    //db.attraction.Add(newAttraction2);
                    //db.SaveChanges();



                    //TODO
                    //После добавления в интерфейс (на форму) ограничений по росту, количества телег,
                    //времени начала и конца, сделать их добавление в запись таблицы
                    
                }

                ///DEBUG
                //var newAttraction2 = new attraction
                //{
                //    name = "imya",
                //    duration = 100,
                //    ticketpricekid = 200,     //todouble ??
                //    ticketpriceadult = 300,
                //    agerestrictionfrom = 10,
                //    agerestrictionto = 85,
                //    weightrestrictionfrom = 20,
                //    weightrestrictionto = 150,
                //    cartcount = 1,
                //    starttime = 11,
                //    endtime = 12,
                //    growthrestrictionfrom = 20,
                //    growthrestrictionto = 220,
                //    pk_attraction = 50

                //};


                //db.attraction.Add(newAttraction2);
                //db.SaveChanges();
                ///DEBUG_END
            }

            this.Close();
        }

        private void buttonAddAttractionCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
