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
        private Model db;
        private attraction selectedAttraction;
        private List<attraction> attractionList;


        private int rowIndexEditing = 0;
        private int colummnIndexEditing = 0;

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
                db = new Model();
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
            catch (System.Data.Entity.Core.ProviderIncompatibleException)
            {
                MessageBox.Show("Отсутствует соединение с базой данных", "Отсутствует соединение",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Question);
            }
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDiscountString = comboBoxDiscount.SelectedItem.ToString();
            var selectedDiscount = db.discount.First(x => x.name == selectedDiscountString);

            textBoxDiscountValue.Text = selectedDiscount.value.ToString();
        }

        private void comboBoxAttraction_SelectedIndexChanged(object sender, EventArgs e)
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

        private void AddAttraction_button_Click(object sender, EventArgs e)
        {
            attractions_dataGridView.Rows.Add();
            attractionList.Add(selectedAttraction);
            attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[0].Value = selectedAttraction.name;
            attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[1].Value = 1;
            ((DataGridViewComboBoxCell)attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[2]).Items.AddRange("Взрослый","Детский");
            attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[3].Value = null;
            attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[4].Value = null;
            attractions_dataGridView.Rows[attractions_dataGridView.Rows.Count - 1].Cells[5].Value = null;
        }

        private void attractions_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Защита от инициализации. Иначе при инициализации он сюда зайдет с e.RowIndex = -1 и все сломает.
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0) {
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
                        if (textBoxDiscountValue.Text != "")
                        if (attractions_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() == "Взрослый")
                            attractions_dataGridView.Rows[e.RowIndex].Cells[5].Value = Convert.ToInt32(attractions_dataGridView.Rows[e.RowIndex].Cells[1].Value) * (1 - Convert.ToInt32(textBoxDiscountValue.Text) / 100) * Convert.ToSingle(currentAttraction.ticketpriceadult);
                        else
                            attractions_dataGridView.Rows[e.RowIndex].Cells[5].Value = Convert.ToInt32(attractions_dataGridView.Rows[e.RowIndex].Cells[1].Value) * (1 - Convert.ToInt32(textBoxDiscountValue.Text) / 100) * Convert.ToSingle(currentAttraction.ticketpricekid);

                        // Изменение общей цены
                        float totalPrice = 0;
                        foreach (var row in attractions_dataGridView.Rows)
                        {
                            totalPrice = totalPrice + Convert.ToSingle((row as DataGridViewRow).Cells[5].Value);
                        }
                        TotalPrice_label.Text = totalPrice.ToString();
                    }
                }
            }
        }

        private void attractions_dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Защита от инициализации. Иначе при инициализации он сюда зайдет с e.RowIndex = -1 и все сломает.
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                rowIndexEditing = e.RowIndex;
                colummnIndexEditing = e.ColumnIndex;
                // Редактирование даты
                if (e.ColumnIndex == 3)
                {
                    DatePicker_panel.Visible = true;
                    #region Вычисление позиции для DatePicker_panel
                    Point pCell = attractions_dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                    Point pDgv = attractions_dataGridView.Location;
                    int xShift = pCell.X + pDgv.X;
                    int yShift = pCell.Y + pDgv.Y + attractions_dataGridView.CurrentRow.Height;
                    #endregion
                    DatePicker_panel.Location = new Point( xShift, yShift);
                    e.Cancel = true;
                }
                // Редактирование времени
                if (e.ColumnIndex == 4)
                {
                    TimePicker_panel.Visible = true;
                    #region Вычисление позиции для timePicker_panel
                    Point pCell = attractions_dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                    Point pDgv = attractions_dataGridView.Location;
                    int xShift = pCell.X + pDgv.X;
                    int yShift = pCell.Y + pDgv.Y + attractions_dataGridView.CurrentRow.Height;
                    #endregion
                    TimePicker_panel.Location = new Point(xShift, yShift);
                    e.Cancel = true;
                }
            }
        }

        private void OKDatePicker_button_Click(object sender, EventArgs e)
        {
            if (colummnIndexEditing != 0)
            {
                attractions_dataGridView.Rows[rowIndexEditing].Cells[colummnIndexEditing].Value = datePicker.Value.ToString("d.M.y");
                DatePicker_panel.Visible = false;
            }
        }

        private void CancelDatePicker_button_Click(object sender, EventArgs e)
        {
            DatePicker_panel.Visible = false;
        }

        private void OKTimePicker_button_Click(object sender, EventArgs e)
        {
            if (colummnIndexEditing != 0)
            {
                attractions_dataGridView.Rows[rowIndexEditing].Cells[colummnIndexEditing].Value = timePicker.Value.ToShortTimeString();
                TimePicker_panel.Visible = false;
            }
        }

        private void CancelTimePicker_button_Click(object sender, EventArgs e)
        {
            TimePicker_panel.Visible = false;
        }

        private void ClearAttractions_button_Click(object sender, EventArgs e)
        {
            attractionList.Clear();
            attractions_dataGridView.Rows.Clear();
            rowIndexEditing = 0;
            colummnIndexEditing = 0;
            TotalPrice_label.Text = "0";
        }
    }
}
