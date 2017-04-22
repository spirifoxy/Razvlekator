using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Razvlekator.Forms
{
    public partial class DateTimePickerForm : Form
    {
        Model db;
        DbSet<session> sessions;
        int rowIndex;

        public DateTimePickerForm(int _rowIndex)
        {
            InitializeComponent();
            rowIndex = _rowIndex;
            db = new Model();
        }

        private void DateTimePickerForm_Load(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
        }

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            Cashier owner = this.Owner as Cashier;
            if (owner != null)
            {
                owner.attractions_dataGridView.Rows[rowIndex].Cells[3].Value = datePicker.Value.ToString("dd.MM.y");
                if (Sessions_listView.SelectedItems.Count != 0)
                    owner.attractions_dataGridView.Rows[rowIndex].Cells[4].Value = Sessions_listView.SelectedItems[0].Text;
                else
                    owner.attractions_dataGridView.Rows[rowIndex].Cells[4].Value = "";
                this.Close();
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            //TODO: Сделать подгрузку из базы нужных сессий для отображения в ListView
            Cashier owner = this.Owner as Cashier;
            IEnumerable<IGrouping<TimeSpan, session>> todaySessions = null;
            var currentDate = datePicker.Value.Date;
            if (owner != null)
            {
                var attName = owner.attractions_dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                todaySessions = db.session.ToList().FindAll(x => x.date.Date == currentDate && x.place.cart.attraction.name == attName).GroupBy(x => x.time);
                Sessions_listView.Items.Clear();
                
                foreach (var pair in todaySessions)
                {
                    Sessions_listView.Items.Add(pair.Key.ToString(@"hh\:mm"));
                }
            }

        }
    }
}
