using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace Razvlekator.Forms
{
    public partial class PlacePickerForm : Form
    {
        private int rowIndex;
        private Model db;
        Cashier owner;
        IEnumerable<IGrouping<cart, place>> currentSessions;
        DateTime date;
        DateTime time;

        public PlacePickerForm(int _rowIndex)
        {
            InitializeComponent();
            rowIndex = _rowIndex;
            db = new Model();

        }

        private void PlacePickerForm_Load(object sender, EventArgs e)
        {
            owner = this.Owner as Cashier;
            carts_ListView.Items.Clear();
            places_ListView.Items.Clear();
            if (owner != null)
            {
                date = DateTime.Parse(owner.attractions_dataGridView.Rows[rowIndex].Cells[3].Value.ToString());
                time = DateTime.Parse(owner.attractions_dataGridView.Rows[rowIndex].Cells[4].Value.ToString());
                if (int.Parse(owner.attractions_dataGridView.Rows[rowIndex].Cells[1].Value.ToString()) >= 2)
                    places_ListView.MultiSelect = true;
                if (date != null && time != null)
                {
                    currentSessions = db.session.ToList().FindAll(x => x.date == date && x.time.ToString("hh':'mm") == time.ToString("hh:mm")).GroupBy(x => x.place.cart, x => x.place);
                    foreach(var pair in currentSessions)
                    {
                        carts_ListView.Items.Add("Телега " + pair.Key.pk_cart);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поля даты и времени","Предупреждение",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void places_ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            SelectedListViewItemCollection selectedPlaces;
            // Если количество 2 и более.
            if (places_ListView.MultiSelect == true)
            {
                selectedPlaces = places_ListView.SelectedItems;

            }
        }

        private void carts_ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var listPlaces = currentSessions.Where(x => "Телега " + x.Key.pk_cart == carts_ListView.SelectedItems[0].Text);
            foreach(var place in listPlaces.First())
            {
                places_ListView.Items.Add("Место " + place.Number);
            }
        }
    }
}
