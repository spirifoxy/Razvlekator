using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Razvlekator
{
    public partial class AdminAttractions : Form
    {
        Admin adminForm;

        List<int> rowsToRemove;
        List<int> changedRows;
        public AdminAttractions()
        {
            InitializeComponent();
            rowsToRemove = new List<int>();
            changedRows = new List<int>();
        }

        public AdminAttractions(Admin _adminFom)
        {
            InitializeComponent();
            rowsToRemove = new List<int>();
            changedRows = new List<int>();
            adminForm = _adminFom;
        }

        private void buttonAttractionsAdd_Click(object sender, EventArgs e)
        {
            new AddAttraction(this).Show();
        }

        public void AdminAttractions_Load(object sender, EventArgs e) //public. ploho.
        {
            try
            {
                using (var db = new Model())
                {
                    dataGridView1.Rows.Clear();
                    var attractions = db.attraction;

                    while (dataGridView1.Rows.Count < attractions.Count())
                        dataGridView1.Rows.Add();

                    int j = 0;
                    foreach (attraction d in attractions)
                    {
                        dataGridView1[0, j].Value = d.pk_attraction;
                        dataGridView1[1, j].Value = d.name;
                        dataGridView1[2, j].Value = d.ticketpricekid;
                        dataGridView1[3, j].Value = d.ticketpriceadult;
                        dataGridView1[4, j].Value = d.duration;
                        dataGridView1[5, j].Value = d.agerestriction;
                        dataGridView1[6, j].Value = d.growthrestriction;
                        dataGridView1[7, j].Value = d.weightrestriction;
                        dataGridView1[8, j].Value = d.cartcount;
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

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            rowsToRemove.Add((int)dataGridView1.Rows[e.Row.Index].Cells[0].Value);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!(changedRows.Contains((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value)))
                changedRows.Add((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //не работает
            textBox_status.Text = "Ожидайте...";
            textBox_status.Update();
            try
            {
                using (var db = new Model())
                {
                    for (int i = 0; i < rowsToRemove.Count(); i++)
                    {
                        attraction attr = null;

                        foreach (attraction a in db.attraction)
                        {
                            if (a.pk_attraction == rowsToRemove[i])
                            {
                                attr = a;
                                break;
                            }
                        }
                        if (attr == null)
                            continue;
                        db.attraction.Remove(attr);
                        db.SaveChanges();
                    }

                    for (int i = 0; i < changedRows.Count(); i++)
                    {
                        //найдём номер измененной строки
                        int numberOfRow = -1;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if (Convert.ToInt32(dataGridView1[0, j].Value) == changedRows[i])
                            {
                                numberOfRow = j;
                                break;
                            }
                        }

                        if (numberOfRow == -1) throw new Exception("Не найден номер строки по первичному ключу");

                        attraction attr = null;
                        foreach (var a in db.attraction)
                            if (a.pk_attraction == changedRows[i]) attr = a;

                        //больше часа пытался сделать, чтобы эта строчка работала вместо цикла выше, очень уж хотелось в linq
                        //если кому-то будет любопытно, и кто-то найдёт причину вылетаний - буду признателен
                        //
                        //attraction attr = db.attraction.FirstOrDefault(s => (int) s.pk_attraction == (int) changedRows[i]);


                        if (attr != null)
                        {
                            if (dataGridView1[0, numberOfRow].Value != null) attr.pk_attraction = Convert.ToInt32(dataGridView1[0, numberOfRow].Value);
                            if (dataGridView1[1, numberOfRow].Value != null) attr.name = Convert.ToString(dataGridView1[1, numberOfRow].Value);
                            if (dataGridView1[2, numberOfRow].Value != null) attr.ticketpricekid = Convert.ToInt32(dataGridView1[2, numberOfRow].Value);  //todouble??
                            if (dataGridView1[3, numberOfRow].Value != null) attr.ticketpriceadult = Convert.ToInt32(dataGridView1[3, numberOfRow].Value);  //todouble??
                            if (dataGridView1[4, numberOfRow].Value != null) attr.duration = Convert.ToInt32(dataGridView1[4, numberOfRow].Value);
                            if (dataGridView1[5, numberOfRow].Value != null) attr.agerestriction = Convert.ToInt32(dataGridView1[5, numberOfRow].Value);
                            if (dataGridView1[6, numberOfRow].Value != null) attr.growthrestriction = Convert.ToInt32(dataGridView1[6, numberOfRow].Value);
                            if (dataGridView1[7, numberOfRow].Value != null) attr.weightrestriction = Convert.ToInt32(dataGridView1[7, numberOfRow].Value);
                            if (dataGridView1[8, numberOfRow].Value != null) attr.cartcount = Convert.ToInt32(dataGridView1[8, numberOfRow].Value);
                        }
                        else
                            throw new Exception("В БД не найден соответствующий первичный ключ");

                        db.Entry(attr).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                this.AdminAttractions_Load(sender, e);
                textBox_status.Text = "Все внесённые изменения сохранены";
            }
            catch (System.Data.Entity.Core.ProviderIncompatibleException)
            {
                MessageBox.Show("Отсутствует соединение с базой данных", "Отсутствует соединение",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Question);
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так", "Упс",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Question);
            }
        }

        private void button_AdminAttractionsBack(object sender, EventArgs e)
        {
            this.Close();
            adminForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                new Sessions(this,Convert.ToInt32(dataGridView1[0,e.RowIndex].Value)).Show();
            }
        }
    }
}
