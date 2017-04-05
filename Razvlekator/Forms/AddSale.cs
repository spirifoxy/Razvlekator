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
    public partial class AddSale: Form
    {
        private AdminSales parentForm;
        public AddSale()
        {
            InitializeComponent();
        }

        public AddSale(AdminSales _parentForm)
        {
            parentForm = _parentForm;
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_sale_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model())//DBEntities.DiscountContext())
                {
                    if (textBox_name_sale.Text != "" &&
                        textBox_value_sale.Text != ""
                        )
                    {
                        var newDiscount = new discount
                        {
                            name = textBox_name_sale.Text,
                            value = Convert.ToInt32(textBox_value_sale.Text)
                        };

                       
                        db.discount.Add(newDiscount);

                        db.SaveChanges();

                        this.Close();
                        parentForm.AdminSales_Load(sender, e);
                    }
                    else label_warning.Visible = true;
                }
            }
            catch (System.Data.Entity.Core.ProviderIncompatibleException)
            {
                MessageBox.Show("Отсутствует соединение с базой данных", "Отсутствует соединение",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Question);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Упс",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Question);
            }
        }
    }
}
