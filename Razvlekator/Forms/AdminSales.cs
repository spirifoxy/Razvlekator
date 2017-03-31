using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Razvlekator
{
    public partial class AdminSales : Form
    {
        Admin adminForm;

        List<int> rowsToRemove;
        List<int> changedRows;

        public AdminSales()
        {
            InitializeComponent();
            rowsToRemove = new List<int>();
            changedRows = new List<int>();
        }

        public AdminSales(Admin _adminForm)
        {
            InitializeComponent();
            rowsToRemove = new List<int>();
            changedRows = new List<int>();
            adminForm = _adminForm;
        }

        private void button_add_sales_Click(object sender, EventArgs e)
        {
            new AddSale(this).Show();
        }

        private void button_sales_back_Click(object sender, EventArgs e)
        {
            this.Close();
            adminForm.Show();
        }

        public void AdminSales_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model())
                {
                    dataGridView3.Rows.Clear();
                    var discounts = db.discount;

                    while (dataGridView3.Rows.Count < discounts.Count())
                        dataGridView3.Rows.Add();

                    int j = 0;
                    foreach (discount d in discounts)
                    {
                        dataGridView3[0, j].Value = d.pk_discount;
                        dataGridView3[1, j].Value = d.name;
                        dataGridView3[2, j].Value = d.value;
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

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model())
                {
                    for (int i = 0; i < rowsToRemove.Count(); i++)
                    {
                        discount disc = null;

                        foreach (discount a in db.discount)
                        {
                            if (a.pk_discount == rowsToRemove[i])
                            {
                                disc = a;
                                break;
                            }
                        }
                        if (disc == null)
                            continue;
                        db.discount.Remove(disc);
                        db.SaveChanges();
                    }

                    for (int i = 0; i < changedRows.Count(); i++)
                    {
                        //найдём номер измененной строки
                        int numberOfRow = -1;
                        for (int j = 0; j < dataGridView3.RowCount; j++)
                        {
                            if (Convert.ToInt32(dataGridView3[0, j].Value) == changedRows[i])
                            {
                                numberOfRow = j;
                                break;
                            }
                        }

                        if (numberOfRow == -1) throw new Exception("Не найден номер строки по первичному ключу");

                        discount disc = null;
                        foreach (var a in db.discount)
                            if (a.pk_discount == changedRows[i]) disc = a;

                        //больше часа пытался сделать, чтобы эта строчка работала вместо цикла выше, очень уж хотелось в linq
                        //если кому-то будет любопытно, и кто-то найдёт причину вылетаний - буду признателен
                        //
                        //discount disc = db.discount.FirstOrDefault(s => (int) s.pk_discount == (int) changedRows[i]);

                        if (disc != null)
                        {
                            if (dataGridView3[0, numberOfRow].Value != null) disc.pk_discount = Convert.ToInt32(dataGridView3[0, numberOfRow].Value);
                            if (dataGridView3[1, numberOfRow].Value != null) disc.name = Convert.ToString(dataGridView3[1, numberOfRow].Value);
                            if (dataGridView3[2, numberOfRow].Value != null) disc.value = Convert.ToInt32(dataGridView3[2, numberOfRow].Value);
                        }
                        else
                            throw new Exception("В БД не найден соответствующий первичный ключ");

                        db.Entry(disc).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                this.AdminSales_Load(sender, e);
                textBox_status.Text = "Все внесённые изменения сохранены";
            }
            catch (System.Data.Entity.Core.ProviderIncompatibleException)
            {
                MessageBox.Show("Отсутствует соединение с базой данных", "Отсутствует соединение",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Question);
            }
        }

        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!(changedRows.Contains((int)dataGridView3.Rows[e.RowIndex].Cells[0].Value)))
                changedRows.Add((int)dataGridView3.Rows[e.RowIndex].Cells[0].Value);
        }

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            rowsToRemove.Add((int)dataGridView3.Rows[e.Row.Index].Cells[0].Value);
        }
    }
}
