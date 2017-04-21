using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        List<ticket> currentTickets;
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

                //var debug = 
                //x.time.ToString("HH:mm")
                if (date != null && time != null)
                {
//                    var temp = 
                    currentSessions = db.session.ToList().FindAll(x => x.date == date && String.Format("{0}:{1:00}", x.time.Hours, x.time.Minutes) == time.ToString("HH:mm")).GroupBy(x => x.place.cart, x => x.place);
                    currentTickets = db.Ticket.ToList().FindAll(x => x.session.date == date && String.Format("{0}:{1:00}", x.session.time.Hours, x.session.time.Minutes) == time.ToString("HH:mm"));
                    foreach (var pair in currentSessions)
                    {
                        carts_ListView.Items.Add("Телега " + pair.Key.pk_cart);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поля даты и времени", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (e.IsSelected)
            {
                places_ListView.Items.Clear();
                bool isAdd = true;

                ListViewItem selectedCart;
                IEnumerable<IGrouping<cart, place>> listOfALLPlaces;
                listOfALLPlaces = currentSessions.Where(x => "Телега " + x.Key.pk_cart == carts_ListView.SelectedItems[0].Text);
                //знаю, костыль, но как ещё инициализировать я хз

                for (int i = 1; i < carts_ListView.SelectedItems.Count; i++)
                {
                    selectedCart = carts_ListView.SelectedItems[i];
                    var listPlaces = currentSessions.Where(x => "Телега " + x.Key.pk_cart == (selectedCart as ListViewItem).Text);
                    foreach (var littlePlace in listPlaces)
                        listOfALLPlaces = listOfALLPlaces.Append(littlePlace);
                }

                foreach (var onePlace in listOfALLPlaces)
                {
                    foreach (var place in onePlace)
                    {
                        isAdd = true;
                        foreach (var ticket in currentTickets)
                            if (place.session.Contains(ticket.session)) isAdd = false;
                        foreach (var item in SharedClass.ReservedPlaces)
                        {
                            if ((e.Item).Text.Split(' ')[1] == item[0].ToString())
                                if (place.Number == item[1])
                                {
                                    isAdd = false;
                                    break;
                                }
                        }
                        if (isAdd)
                            places_ListView.Items.Add("№ " + place.Number + " ," + Environment.NewLine + "(т." + place.cart.pk_cart + ")");
                    }
                }
            }
        }


        private void OK_button_Click(object sender, EventArgs e)
        {
            if (places_ListView.SelectedItems.Count == Int32.Parse(owner.attractions_dataGridView[1, rowIndex].Value.ToString()))
            {
                if (carts_ListView.SelectedItems[0] != null)
                {
                    string cart = carts_ListView.SelectedItems[0].Text;
                    if (places_ListView.SelectedItems != null)
                    {
                        var places = places_ListView.SelectedItems;
                        string placesStr = "";
                        if (owner != null)
                        {
                            foreach (var item in places)
                            {
                                placesStr += cart + "-" + (item as ListViewItem).Text + ",";
                                SharedClass.ReservedPlaces.Add(new int[] { Int32.Parse(cart.Split(' ')[1]), Int32.Parse((item as ListViewItem).Text.Split(' ')[1]) });
                            }
                            owner.attractions_dataGridView.Rows[rowIndex].Cells[6].Value = placesStr;
                        }
                    }
                }
                this.Close();
            }
            else MessageBox.Show(String.Format("Необходимое количество выбранных мест: {0}", owner.attractions_dataGridView[1, rowIndex].Value.ToString()),
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
