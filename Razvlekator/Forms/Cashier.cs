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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void Cashier_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model())
                {
                    comboBoxDiscount.Items.Clear();
                    comboBoxDiscountValue.Items.Clear();
                    var discounts = db.discount;
                    
                    foreach (discount d in discounts)
                    {
                        if (d.isActive != 1)
                            continue;
                        comboBoxDiscountValue.Items.Add(d.value);
                        comboBoxDiscount.Items.Add(d.name);
                    }
                    
                    comboBoxAttraction.Items.Clear();
                    dataGridViewAttractions.Rows.Clear();
                    var attractions = db.attraction;

                    while (dataGridViewAttractions.Rows.Count < attractions.Count())
                        dataGridViewAttractions.Rows.Add();

                    int j = 0;
                    foreach (attraction a in attractions)
                    {
                        comboBoxAttraction.Items.Add(a.name);

                        dataGridViewAttractions[0, j].Value = a.pk_attraction;
                        dataGridViewAttractions[1, j].Value = a.name;
                        dataGridViewAttractions[2, j].Value = a.ticketpricekid;
                        dataGridViewAttractions[3, j].Value = a.ticketpriceadult;
                        dataGridViewAttractions[4, j].Value = a.duration;
                        dataGridViewAttractions[5, j].Value = a.agerestrictions;
                        dataGridViewAttractions[6, j].Value = a.growthrestriction;
                        dataGridViewAttractions[7, j].Value = a.weightrestriction;
                        dataGridViewAttractions[8, j].Value = a.cartcount;
                        j++;    //костыль
                    }

                }
            }

            catch (System.Data.Entity.Core.ProviderIncompatibleException)
            {
                MessageBox.Show("Отсутствует соединение с базой данных", "Отсутствует соединение",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Question);
            }
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDiscountValue.Text = comboBoxDiscountValue.Items[comboBoxDiscount.SelectedIndex].ToString();
        }

        private void comboBoxAttraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxAttraction.SelectedIndex;
            textBoxDuration.Text = dataGridViewAttractions[4, index].Value.ToString();
            textBoxPriceKid.Text = dataGridViewAttractions[2, index].Value.ToString();
            textBoxPriceAdult.Text = dataGridViewAttractions[3, index].Value.ToString();
            textBoxWeightRestriction.Text = dataGridViewAttractions[7, index].Value.ToString();
            textBoxGrowthRestriction.Text = dataGridViewAttractions[6, index].Value.ToString();
            textBoxAgeRestriction.Text = dataGridViewAttractions[5, index].Value.ToString();
        }
    }
}
