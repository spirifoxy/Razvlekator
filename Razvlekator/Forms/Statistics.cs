using System;
using System.Linq;
using System.Windows.Forms;

namespace Razvlekator.Forms
{
    public partial class Statistics : Form
    {
        Admin adminform;
        public Statistics()
        {
            InitializeComponent();
        }

        public Statistics(Admin _form)
        {
            InitializeComponent();
            adminform = _form;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            adminform.Show();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            using (var db = new Model())
            {
                #region Заполнение аттракционов
                comboBoxAttraction.Items.Clear();
                var attractions = db.attraction;

                foreach (var item in attractions)
                    comboBoxAttraction.Items.Add(item.name);

                #endregion
            }
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxAttraction.Text != "") &&
                        (dateTimePicker1.Value <= dateTimePicker2.Value))
                {
                    using (var db = new Model())
                    {
                        var allTickets = db.Ticket.ToList().FindAll
                            (x => x.session.place.cart.attraction.name == comboBoxAttraction.Text &&
                             x.session.date.DayOfYear >= dateTimePicker1.Value.DayOfYear &&
                            x.session.date.DayOfYear <= dateTimePicker2.Value.DayOfYear);

                        var countOfTickets = allTickets.Count;

                        float moneyForTickets = 0;
                        foreach (var x in allTickets)
                        {
                            if (x.type == true)
                            {
                                moneyForTickets += x.session.place.cart.attraction.ticketpricekid;
                            }
                            else
                            {
                                moneyForTickets += x.session.place.cart.attraction.ticketpriceadult;
                            }
                        }

                        textBoxCount.Text = countOfTickets.ToString();
                        textBoxMoney.Text = moneyForTickets.ToString();                        
                    }
                }
                else
                    MessageBox.Show("Пожалуйста, выберите аттракцион и выберите дату корректно",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.Entity.Core.ProviderIncompatibleException)
            {
                MessageBox.Show("Отсутствует соединение с базой данных", "Отсутствует соединение",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Question);
            }
        }
    }
}
