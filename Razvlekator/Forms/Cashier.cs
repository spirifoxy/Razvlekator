using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Razvlekator.Forms;

namespace Razvlekator
{
    public partial class Cashier : Form
    {
        private attraction selectedAttraction;
        private List<attraction> attractionList;


        private int rowIndexEditing = 0;
        private int colummnIndexEditing = 0;

        private bool isTicketTimeIntesects = false;

        public Cashier()
        {
            InitializeComponent();
            attractionList = new List<attraction>();
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
                    #region Заполнение скидок
                    comboBoxDiscount.Items.Clear();
                    var discounts = db.discount;

                    foreach (var item in discounts)
                    {
                        if (item.isActive != 1)
                            continue;
                        comboBoxDiscount.Items.Add(item.name);
                    }
                    #endregion

                    #region Заполнение аттракционов
                    comboBoxAttraction.Items.Clear();
                    attractions_dataGridView.Rows.Clear();
                    var attractions = db.attraction;

                    foreach (var item in attractions)
                        comboBoxAttraction.Items.Add(item.name);

                    #endregion
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
            using (var db = new Model())
            {
                var selectedDiscountString = comboBoxDiscount.SelectedItem.ToString();
                var selectedDiscount = db.discount.First(x => x.name == selectedDiscountString);

                textBoxDiscountValue.Text = selectedDiscount.value.ToString();
            }
        }

        private void comboBoxAttraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Model())
            {
                var selectedAttractionString = comboBoxAttraction.SelectedItem.ToString();
                selectedAttraction = db.attraction.First(x => x.name == selectedAttractionString);

                textBoxDuration.Text = selectedAttraction.duration.ToString();
                textBoxPriceKid.Text = selectedAttraction.ticketpricekid.ToString();
                textBoxPriceAdult.Text = selectedAttraction.ticketpriceadult.ToString();
                textBoxWeightRestriction.Text = selectedAttraction.weightrestriction.ToString();
                textBoxGrowthRestriction.Text = selectedAttraction.growthrestriction.ToString();
                textBoxAgeRestriction.Text = selectedAttraction.agerestrictions.ToString();
            }
        }

        private void AddAttraction_button_Click(object sender, EventArgs e)
        {
            attractions_dataGridView.Rows.Add();
            attractionList.Add(selectedAttraction);
            attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[0].Value = selectedAttraction.name;
            attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[1].Value = 1;
            ((DataGridViewComboBoxCell)attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[2]).Items.AddRange("Взрослый", "Детский");
            attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[3].Value = null;
            attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[4].Value = null;
            attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[5].Value = null;
        }

        private void attractions_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SetRowsColorDefault();
            // Защита от инициализации. Иначе при инициализации он сюда зайдет с e.RowIndex = -1 и все сломает.
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Если изменена ячейка в столбце Количество или Тип билета, то пересчитать цену билета
                if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
                {
                    if (attractions_dataGridView.Rows[e.RowIndex].Cells[1].Value == null)
                    {
                        attractions_dataGridView.Rows[e.RowIndex].Cells[1].ErrorText = "Обязательное поле";
                    }
                    else
                    {
                        attractions_dataGridView.Rows[e.RowIndex].Cells[1].ErrorText = null;
                    }
                    if (((DataGridViewComboBoxCell)attractions_dataGridView.Rows[e.RowIndex].Cells[2]).Value == null)
                    {
                        attractions_dataGridView.Rows[e.RowIndex].Cells[2].ErrorText = "Обязательное поле";
                    }
                    else
                    {
                        attractions_dataGridView.Rows[e.RowIndex].Cells[2].ErrorText = null;
                    }

                    if (attractions_dataGridView.Rows[e.RowIndex].Cells[1].Value != null && ((DataGridViewComboBoxCell)attractions_dataGridView.Rows[e.RowIndex].Cells[2]).Value != null)
                    {
                        var currentAttraction = attractionList.Find(x => x.name == attractions_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                        // Цена = Кол-во * ( 1 - Скидка% / 100) * ЦенаБилетаТипа

                        /* double h1 = Convert.ToDouble(textBoxDiscountValue.Text);
                         double h2 = h1 / 100;
                         double h3 = 1 - h2;*/

                        double coefOfSale = 1;

                        if (textBoxDiscountValue.Text != "") coefOfSale = (1 - Convert.ToDouble(textBoxDiscountValue.Text) / 100);

                        if (attractions_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() == "Взрослый")
                            attractions_dataGridView.Rows[e.RowIndex].Cells[5].Value = Convert.ToDouble(attractions_dataGridView.Rows[e.RowIndex].Cells[1].Value) * coefOfSale * Convert.ToDouble(currentAttraction.ticketpriceadult);
                        else
                            attractions_dataGridView.Rows[e.RowIndex].Cells[5].Value = Convert.ToDouble(attractions_dataGridView.Rows[e.RowIndex].Cells[1].Value) * coefOfSale * Convert.ToDouble(currentAttraction.ticketpricekid);

                        // Изменение общей цены
                        float totalPrice = 0;
                        foreach (var row in attractions_dataGridView.Rows)
                        {
                            totalPrice = totalPrice + Convert.ToSingle((row as DataGridViewRow).Cells[5].Value);
                        }
                        TotalPrice_label.Text = totalPrice.ToString();
                    }
                    
                }
                if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
                {
                    CheckRowsIntersetion();
                }
            }
        }

        private void SetRowsColorDefault()
        {
            foreach (DataGridViewRow row in attractions_dataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = DefaultBackColor;
            }
        }

        private void CheckRowsIntersetion()
        {
            if (attractions_dataGridView.RowCount > 1)
                for (int i = 0; i < attractions_dataGridView.RowCount; i++)
                {
                    var currentRow = attractions_dataGridView.Rows[i];
                    foreach (DataGridViewRow rowComp in attractions_dataGridView.Rows)
                    {
                        if (rowComp != currentRow)
                        if (rowComp.Cells[3].Value != null)  // Костыль, ибо пробегает 2 раза, после сохранения. Дату заполнил, а время нет.
                            if (currentRow.Cells[3].Value != null) // Тоже самое
                                if (currentRow.Cells[3].Value.ToString() == rowComp.Cells[3].Value.ToString())
                                {
                                    if (rowComp.Cells[4].Value != null)  // Костыль, ибо пробегает 2 раза, после сохранения. Дату заполнил, а время нет.
                                        if (currentRow.Cells[4].Value != null) // Тоже самое
                                            if (currentRow.Cells[4].Value.ToString() == rowComp.Cells[4].Value.ToString())
                                            {
                                                currentRow.DefaultCellStyle.BackColor = Color.Red;
                                                rowComp.DefaultCellStyle.BackColor = Color.Red;
                                            }
                                }
                    }
                }
        }

        private void attractions_dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Защита от инициализации. Иначе при инициализации он сюда зайдет с e.RowIndex = -1 и все сломает.
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                rowIndexEditing = e.RowIndex;
                colummnIndexEditing = e.ColumnIndex;
                var datepickerform = new DateTimePickerForm(e.RowIndex);
                var placepickerform = new PlacePickerForm(e.RowIndex);
                datepickerform.Owner = this;
                placepickerform.Owner = this;
                // Редактирование даты
                if (e.ColumnIndex == 3)
                {
                    #region Вычисление позиции для DatePicker_panel
                    Point pCell = attractions_dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                    Point pDgv = attractions_dataGridView.Location;
                    int xShift = pCell.X + pDgv.X;
                    int yShift = pCell.Y + pDgv.Y + attractions_dataGridView.CurrentRow.Height;
                    #endregion
                    datepickerform.Location = new Point(xShift, yShift);
                    datepickerform.ShowDialog();
                    e.Cancel = true;
                }
                // Редактирование времени
                if (e.ColumnIndex == 4)
                {
                    #region Вычисление позиции для timePicker_panel
                    Point pCell = attractions_dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                    Point pDgv = attractions_dataGridView.Location;
                    int xShift = pCell.X + pDgv.X;
                    int yShift = pCell.Y + pDgv.Y + attractions_dataGridView.CurrentRow.Height;
                    #endregion
                    datepickerform.Location = new Point(xShift, yShift);
                    datepickerform.ShowDialog();
                    e.Cancel = true;
                }
                // Редактирование места в телеге
                if (e.ColumnIndex == 6)
                {
                    #region Вычисление позиции для placePicker
                    Point pCell = attractions_dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                    Point pDgv = attractions_dataGridView.Location;
                    int xShift = pCell.X + pDgv.X;
                    int yShift = pCell.Y + pDgv.Y + attractions_dataGridView.CurrentRow.Height;
                    #endregion
                    placepickerform.Location = new Point(xShift, yShift);
                    placepickerform.ShowDialog();
                    e.Cancel = true;
                }
            }
        }

        private void ClearAttractions_button_Click(object sender, EventArgs e)
        {
            attractionList.Clear();
            attractions_dataGridView.Rows.Clear();
            rowIndexEditing = 0;
            colummnIndexEditing = 0;
            TotalPrice_label.Text = "0";
            SharedClass.ReservedPlaces.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ReturnTicket().Show();


        }

        private async void CheckOut_button_Click(object sender, EventArgs e)
        {
            if (isTicketTimeIntesects == false)
            {
                using (var db = new Model())
                {
                    // Создаем заказ
                    orders newOrder = new orders();
                    newOrder.date = DateTime.Now.Date;
                    db.orders.Add(newOrder);
                    // Сейчас нужно сохранить, чтобы наш newOrder получил pk_order
                    db.SaveChanges();

                    foreach (DataGridViewRow item in attractions_dataGridView.Rows)
                    {
                        for (int i = 0; i < Convert.ToInt32(item.Cells[1].Value.ToString()); i++)
                        {
                            ticket newTicket = new ticket();

                            if (comboBoxDiscount.SelectedText != "")
                            {
                                newTicket.discount = db.discount.First(x => x.name == comboBoxDiscount.SelectedText);
                                newTicket.pk_discount = newTicket.discount.pk_discount;
                            }
                            else
                            {
                                newTicket.discount = null;
                                newTicket.pk_discount = null;
                            }

                            newTicket.order = newOrder;
                            newTicket.pk_order = newOrder.pk_order;
                            newTicket.pk_session = db.session.First(x => x.time.ToString("hh':'mm") == item.Cells[4].Value.ToString()
                                                    && x.date.ToString("dd.MM.y") == item.Cells[3].Value.ToString()
                                                    && (x.place.Number.ToString() == GetThisPlace(item.Cells[6].Value.ToString(), i))
                                                    && (x.place.pk_cart.ToString() == GetThisCart(item.Cells[6].Value.ToString(), i))).pk_session;
                            newTicket.type = (item.Cells[2].Value.ToString() == "Взрослый") ? true : false;
                            db.Ticket.Add(newTicket);
                        }
                    }

                    await db.SaveChangesAsync();
                    Task.Delay(3000);
                    MessageBox.Show("Заказ оформлен", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Пересекаются время аттракционов","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private string GetThisPlace(string input, int number)
        {
            string[] cartsAndPlaces = input.Split(',');
            string place = cartsAndPlaces[number].Split('-')[1];
            return place.Split(' ')[1];
            
        }

        private string GetThisCart(string input, int number)
        {
            string[] cartsAndPlaces = input.Split(',');
            string cart = cartsAndPlaces[number].Split('-')[0];
            return cart.Split(' ')[1];
        }

        private void attractions_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SetRowsColorDefault();
            CheckRowsIntersetion();
        }
    }
}
