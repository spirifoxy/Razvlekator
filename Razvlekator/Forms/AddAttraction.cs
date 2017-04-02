﻿using System;
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
    public partial class AddAttraction : Form
    {
        private AdminAttractions parentForm;
        public AddAttraction()
        {
            InitializeComponent();
        }

        public AddAttraction(AdminAttractions _parentForm)
        {
            InitializeComponent();
            parentForm = _parentForm;
        }

        private void buttonAddAttrationSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model())//DBEntities.DiscountContext())
                {
                    #region Создание Аттракциона
                    if (textBoxDuration.Text != "" &&
                        textBoxCostChild.Text != "" &&
                        textBoxCostAdult.Text != "" &&
                        numericUpDown_clockS.Text != "" &&
                        numericUpDown_clockDo.Text != "" &&
                        numericUpDown_countCarts.Text != ""
                        )
                    {
                        var newAttraction = new attraction
                        {
                            name = comboBoxAttractionName.Text,
                            duration = Convert.ToInt32(textBoxDuration.Text),
                            ticketpricekid = Convert.ToSingle(textBoxCostChild.Text),     
                            ticketpriceadult = Convert.ToInt32(textBoxCostAdult.Text),
                            starttime = Convert.ToInt32(numericUpDown_clockS.Text),
                            endtime = Convert.ToInt32(numericUpDown_clockDo.Text),
                            cartcount = Convert.ToInt32(numericUpDown_countCarts.Text)
                        };

                        if (textBoxOldFrom.Text != "") newAttraction.agerestriction = Convert.ToInt32(textBoxOldFrom.Text);
                        if (textBoxWeightFrom.Text != "") newAttraction.weightrestriction = Convert.ToInt32(textBoxWeightFrom.Text);
                        if (textBoxOldFrom.Text != "") newAttraction.agerestriction = Convert.ToInt32(textBoxOldFrom.Text);

                        db.attraction.Add(newAttraction);
                    #endregion
                    #region Создание тележек и мест в них

                        for (int i = 0; i < Convert.ToInt32(numericUpDown_countCarts.Value); i++)
                        {
                            var newCart = new cart()
                            {
                                attraction = newAttraction,
                                placecount = (int)numericUpDown_countPlaces.Value
                            };
                            for (int j = 0; j < Convert.ToInt32(numericUpDown_countPlaces.Value); i++)
                            {
                                var newPlace = new place()
                                {
                                    Number = j + 1,
                                    cart = newCart
                                };
                                db.place.Add(newPlace);
                            }
                            db.cart.Add(newCart);
                        }

                    #endregion

                        db.SaveChanges();

                        this.Close();
                        parentForm.AdminAttractions_Load(sender, e);


                    }
                    else label_warning.Visible = true;
                }
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


        private void buttonAddAttractionCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}