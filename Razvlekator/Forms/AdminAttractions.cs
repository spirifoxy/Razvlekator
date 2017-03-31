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
        List<int> rowsToRemove;      //костыль. плохо.
        List<int> changedRows;      //костыль. плохо.
        public AdminAttractions()
        {
            InitializeComponent();
            rowsToRemove = new List<int>();
            changedRows = new List<int>();
        }

        private void buttonAttractionsAdd_Click(object sender, EventArgs e)
        {
            new AddAttraction(this).Show();
        }

        public void AdminAttractions_Load(object sender, EventArgs e) //public. ploho.
        {
            using (var db = new Model())
            {
                dataGridView1.Rows.Clear();
                var attractions = db.attraction;

                while (dataGridView1.Rows.Count < attractions.Count())
                    dataGridView1.Rows.Add();

                int j = 0;
                foreach (attraction d in attractions)
                {
                    dataGridView1[0, j].Value = d.pk_attraction;
                    dataGridView1[1, j].Value = d.name;
                    dataGridView1[2, j].Value = d.ticketpriceadult;
                    dataGridView1[3, j].Value = d.ticketpricekid;
                    dataGridView1[4, j].Value = d.duration;
                    dataGridView1[5, j].Value = d.agerestriction;
                    dataGridView1[6, j].Value = d.growthrestriction;
                    dataGridView1[7, j].Value = d.weightrestriction;
                    dataGridView1[8, j].Value = d.cartcount;
                    j++;    //костыль

                }
            }

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            rowsToRemove.Add((int) dataGridView1.Rows[e.Row.Index].Cells[0].Value);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            changedRows.Add(e.RowIndex);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //
            //адд и апдейт пилить тут.
            //
            using (var db = new Model())
            {
                
                for (int i = 0; i < rowsToRemove.Count(); i++)
                {
                    //attraction deletedAttraction = new attraction
                    //{
                    //    pk_attraction = removedRows[i],
                    //};


                    /*attraction attr = db.attraction
                        .Where(a => a.pk_attraction == rowsToRemove[i])
                        .FirstOrDefault();
                        */
                    attraction attr = null;

                    foreach (attraction a in db.attraction)
                    {
                        if (a.pk_attraction == rowsToRemove[i]) {
                            attr = a;
                        }
                    }
                    if (attr == null)
                        continue;
                    db.attraction.Remove(attr);
                    db.SaveChanges();
                    /*attraction deletedAttraction = new attraction
                    {
                        pk_attraction = removedRows[i],
                        name = 
                        duration =
                        ticketprice
                        ticketprice
                        starttime =
                        endtime = 
                        cartcount =
                    };

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
                    */

                    //db.attraction.Attach(deletedAttraction);
                    //db.attraction.Remove(deletedAttraction);
                    //db.SaveChanges();
                }
            }
        }
    }
}
