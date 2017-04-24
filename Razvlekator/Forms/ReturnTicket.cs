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
    public partial class ReturnTicket : Form
    {
        public ReturnTicket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    using (var db = new Model())
                    {
                        var numberOfTicket = Int32.Parse(textBox1.Text);
                        var refundTicket = db.Ticket.ToList().Find(x => x.pk_ticket == numberOfTicket);

                        DateTime dateOfRefund = DateTime.Today;

                        float cost = 0;
                        if (refundTicket.type == true)
                        {
                            cost = refundTicket.session.place.cart.attraction.ticketpricekid;
                        }
                        else
                        {
                            cost = refundTicket.session.place.cart.attraction.ticketpriceadult;
                        }

                        refund newrefund = new refund()
                        {
                            number = numberOfTicket,
                            money = cost,
                            date = dateOfRefund
                        };

                        db.Refund.Add(newrefund);
                        db.Ticket.Remove(refundTicket);
                        db.SaveChanges();

                        this.Close();
                        MessageBox.Show(String.Format("Верните покупателю {0} руб.", cost), "Возврат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (NullReferenceException exc)
                {
                    MessageBox.Show("Билета с таким номером не существует", "Возврат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
