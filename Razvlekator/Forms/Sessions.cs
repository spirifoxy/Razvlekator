using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Razvlekator
{
    public partial class Sessions : Form
    {
        AdminAttractions adminForm;
        int pk_attraction;
        List<int> rowsToRemove;
        public Sessions()
        {
            InitializeComponent();
            rowsToRemove = new List<int>();
        }
        public Sessions(AdminAttractions _adminForm, int _pk_attraction)
        {
            InitializeComponent();
            adminForm = _adminForm;
            pk_attraction = _pk_attraction;
            rowsToRemove = new List<int>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sessions_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model())
                {
                    var attractions = db.attraction;
                    attraction attr = null;
                    foreach (var a in db.attraction)
                        if (a.pk_attraction == pk_attraction) attr = a;
                    textBox_duration.Text = attr.duration.ToString();
                    textBox_startTime.Text = attr.starttime.ToString();
                    textBox_endTime.Text = attr.endtime.ToString();

                    dataGridView1.Rows.Clear();

                    
                    var sessions = db.GetAllSessionsFromAttr(attr);

                    int oneplaceforout = -1;
                    if (sessions.Count() > 0)
                        oneplaceforout = sessions.First().pk_place;

                    foreach (var ses in sessions)
                        if (ses.pk_place == oneplaceforout)
                            dataGridView1.Rows.Add();

                    int j = 0;
                    foreach (session d in sessions)
                    {
                        if (d.pk_place == oneplaceforout)
                        {
                            dataGridView1[0, j].Value = d.time.ToString("hh':'mm");
                            TimeSpan temp = d.time;
                            TimeSpan temp2 = new TimeSpan(0, attr.duration, 0);
                            temp += temp2;
                            dataGridView1[1, j].Value = (temp.ToString("hh':'mm"));
                            dataGridView1[2, j].Value = (d.pk_session);

                            j++;
                        }
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

        private void button_generateSessions_Click(object sender, EventArgs e)
        {
            if (textBox_timeBetween.Value != 0)
            {
                dataGridView1.Rows.Clear();
                //min
                int timeOfWork = 60 * (Convert.ToInt32(textBox_endTime.Text) - Convert.ToInt32(textBox_startTime.Text));
                int countOfSeanses = timeOfWork / (Convert.ToInt32(textBox_duration.Text) +
                    Convert.ToInt32(textBox_timeBetween.Text));

                DateTime time = new DateTime(2017, 1, 1, Convert.ToInt32(textBox_startTime.Text), 0, 0);

                for (int i = 0; i < countOfSeanses; i++)
                {
                    dataGridView1.Rows.Add();
                    time = time.AddMinutes(Convert.ToInt32(textBox_duration.Text));
                    time = time.AddMinutes(Convert.ToInt32(Convert.ToInt32(textBox_timeBetween.Text)));
                }

                time = new DateTime(2017, 1, 1, Convert.ToInt32(textBox_startTime.Text), 0, 0);

                for (int i = 0; i < countOfSeanses; i++)
                {
                    dataGridView1[0, i].Value = String.Format("{0:hh}:{0:mm}", time);
                    time = time.AddMinutes(Convert.ToInt32(textBox_duration.Text));
                    dataGridView1[1, i].Value = String.Format("{0:hh}:{0:mm}", time);
                    time = time.AddMinutes(Convert.ToInt32(Convert.ToInt32(textBox_timeBetween.Text)));
                }
            }
        }

        private void button_saveSessions_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    using (var db = new Model())//DBEntities.DiscountContext())
                    {
                        for (int i = 0; i < rowsToRemove.Count(); i++)
                        {
                            session ses = null;

                            foreach (session a in db.session)
                            {
                                if (a.pk_session == rowsToRemove[i])
                                {
                                    ses = a;
                                    break;
                                }
                            }
                            if (ses == null)
                                continue;
                            db.session.Remove(ses);
                            db.SaveChanges();
                        }

                        for (DateTime mydate = new DateTime
                            (dateTimePicker1.Value.Year,
                            dateTimePicker1.Value.Month,
                            dateTimePicker1.Value.Day);

                            mydate.Day <= dateTimePicker2.Value.Day;

                            mydate = mydate.AddDays(1))

                        {
                            session newSession = null;
                            for (int i = 0; i < (dataGridView1.Rows.Count-1); i++)
                            {
                                TimeSpan mytime = new TimeSpan
                                    (Convert.ToInt32(dataGridView1[0, i].Value.ToString().Split(':')[0]),
                                    Convert.ToInt32(dataGridView1[0, i].Value.ToString().Split(':')[1]),
                                    0);

                                attraction attr = null;
                                foreach (var a in db.attraction)
                                    if (a.pk_attraction == pk_attraction) attr = a;
                                
                                var allPlaces = db.GetAllPlacesFromAttr(attr);

                                foreach (var place in allPlaces)
                                {
                                    newSession = new session
                                    {
                                        date = mydate,
                                        time = mytime,
                                        pk_place = place.pk_place
                                    };

                                    db.session.Add(newSession);
                                }
                            }
                        }
                        db.SaveChanges();

                        this.Close();
                    }
                }
                catch (System.Data.Entity.Core.ProviderIncompatibleException)
                {
                    MessageBox.Show("Отсутствует соединение с базой данных", "Отсутствует соединение",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Упс",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                }
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            rowsToRemove.Add((int)dataGridView1.Rows[e.Row.Index].Cells[2].Value);
        }
    }
}
