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
    public partial class Login: Form
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
            if (comboBoxRole.SelectedItem.ToString() == "Кассир" && textBoxPassword.Text == "1")
            {
            }
            else if (comboBoxRole.SelectedItem.ToString() == "Администратор" && textBoxPassword.Text == "1")
            {
                this.Hide();
                new Admin().Show();
                //Потом при закрытии админской формы эта форма логина так и остается висеть Hide
            }
            else
            {
                //DEBUG

                using (var db = new Model())//DBEntities.DiscountContext())
                {
                    
                    var d1 = new discount { name = "ololo3", value = 123 };
                    var d2 = new discount { name = "ololo4", value = 321 };
                    
                    db.discount.Add(d1);
                    db.discount.Add(d2);
                    db.SaveChanges();
                    Console.WriteLine("IT'S ALIVE");

                    // получаем объекты из бд и выводим на консоль
                    var discounts = db.discount;
                    foreach (discount d in discounts)
                    {
                        Console.WriteLine("{0}.{1} - {2}", d.pk_discount, d.name, d.value);
                    }
                }

                //DEBUG


                //MessageBox.Show("Неправильный пароль");
            }
        }
    }
}
