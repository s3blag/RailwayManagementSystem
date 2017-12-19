using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayManagementSystem
{
    public partial class AdminForm : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        DataTable trains;
        DataTable courses;
        DataTable stations;

        public AdminForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            //Łukasz
            //sqlConnection = new SqlConnection("Data Source=DESKTOP-CDUIBQ6\\SQLEXPRESS; database=SRBK_database;Trusted_Connection=yes");
            //Seba
            sqlConnection = new SqlConnection("Data Source=DESKTOP-G92BDEO\\SQLEXPRESS; database=SRBK_database;Trusted_Connection=yes");

        }

        public AdminForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.sqlConnection = sqlConnection;
        }

        private void buttonSearchAtoB_Click_1(object sender, EventArgs e)
        {
            string cityA = textBoxCityA.Text,
                   cityB = textBoxCityB.Text;
            
            if(cityA.Any(char.IsDigit) == false && cityB.Any(char.IsDigit) == false)
                try
                {
                    using (DataTable dataTable = Courses.GetCoursesFromAtoB(sqlConnection, textBoxCityA.Text, textBoxCityB.Text))
                    {
                        if (dataTable != null)
                            dataGridViewCourses.DataSource = dataTable;
                        else
                            MessageBox.Show("Kurs o podanych danych nie istnieje!");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            else
                MessageBox.Show("Pola nie powinny zawierać cyfr");

        }

        private void buttonShowCourseVisits_Click_1(object sender, EventArgs e)
        {
            string id = textBoxCourseVisits.Text;

            if (id.All(char.IsDigit))
            {
                try
                {
                    using (DataTable dataTable = Courses.GetCourseVisits(sqlConnection, id))
                    {

                        if (dataTable != null)
                            dataGridViewCourses.DataSource = dataTable;
                        else
                            MessageBox.Show("Kurs o podanych danych nie istnieje!");
                    }
                }
                catch
                {
                    MessageBox.Show("Błąd zapytania do BD");
                }
            }
            else
                MessageBox.Show("Nie podano liczby");

        }

        private void buttonSelectAllCourses_Click(object sender, EventArgs e)
        {
            try
            {
                courses = Courses.GetAllCourses(sqlConnection);
                dataGridViewCourses.DataSource = courses;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            if (comboBoxTrains.SelectedIndex != -1)
            {
                try
                {
                    int index = Int32.Parse(trains.Rows[comboBoxTrains.SelectedIndex][0].ToString());

                    if (Courses.AddCourse(sqlConnection, index))
                        MessageBox.Show("Kurs został dodany pomyślnie!");
                    courses = Courses.GetAllCourses(sqlConnection);
                    dataGridViewCourses.DataSource = courses;

                    comboBoxCourses.Items.Clear();
                    for (int i = 0; i < courses.Rows.Count; i++)
                        comboBoxCourses.Items.Add(courses.Rows[i][0].ToString());
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
                MessageBox.Show("Nie wybrano pociągu!");
        }

        private void tabControlCourses_Click(object sender, EventArgs e)
        {
            try
            {
                trains = Trains.GetAllTrains(sqlConnection);

                comboBoxTrains.Items.Clear();
                for (int i = 0; i < trains.Rows.Count; i++)
                    comboBoxTrains.Items.Add(trains.Rows[i][1].ToString());

                courses = Courses.GetAllCourses(sqlConnection);

                comboBoxCourses.Items.Clear();
                for (int i = 0; i < courses.Rows.Count; i++)
                    comboBoxCourses.Items.Add(courses.Rows[i][0].ToString());

                comboBoxStations.Items.Clear();
                stations = Stations.GetAllStations(sqlConnection);
                for (int i = 0; i < stations.Rows.Count; i++)
                    comboBoxStations.Items.Add(stations.Rows[i][1].ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonAddVisit_Click(object sender, EventArgs e)
        {
            try
            {
                var dateDays = monthCalendar1.SelectionStart;
                dateDays = dateDays.AddHours((int)numericUpDownHours.Value);
                dateDays = dateDays.AddMinutes((int)numericUpDownMinutes.Value);

                string date = dateDays.Year.ToString() + "-" + dateDays.Month.ToString() + "-" + dateDays.Day.ToString() + " " + dateDays.Hour.ToString() + ":" + dateDays.Minute.ToString() + ":" + dateDays.Second.ToString();
                string courseIndex = courses.Rows[comboBoxCourses.SelectedIndex][0].ToString();
                string stationIndex = stations.Rows[comboBoxStations.SelectedIndex][0].ToString();
                string visitOrder = (Courses.GetNumberOfVisits(sqlConnection, courseIndex) + 1).ToString();
                string avaibleSeats = 50.ToString();

                Visits.VisitData visitData = new Visits.VisitData(stationIndex, courseIndex, visitOrder, avaibleSeats, date);
                if (Visits.AddNewVisit(sqlConnection, visitData))
                    MessageBox.Show("Przystanek dodano pomyślnie");

                string visitIndex = Visits.GetVisitId(sqlConnection, courseIndex, visitOrder);
                Seats.AddSeats(sqlConnection, courseIndex, visitIndex, 50);

                dataGridViewCourses.DataSource = Courses.GetCourseVisits(sqlConnection, courseIndex);
                courses = Courses.GetAllCourses(sqlConnection);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void comboBoxCourses_Click(object sender, EventArgs e)
        {
            dataGridViewCourses.DataSource = courses;
        }

        private void buttonAddStation_Click(object sender, EventArgs e)
        {
            string stationName = textBoxStationName.Text;

            if (!stationName.Any(char.IsDigit) && stationName.Any(char.IsLetter))
            {
                try
                {
                    if (Stations.AddStation(sqlConnection, stationName))
                        MessageBox.Show("Stacja została dodana pomyślnie!");
                    stations = Stations.GetAllStations(sqlConnection);
                    dataGridViewCourses.DataSource = stations;

                    comboBoxStations.Items.Clear();
                    stations = Stations.GetAllStations(sqlConnection);
                    for (int i = 0; i < stations.Rows.Count; i++)
                        comboBoxStations.Items.Add(stations.Rows[i][1].ToString());

                    textBoxStationName.Text = "";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
                MessageBox.Show("Nazwa stacji nie powinna zawierać cyfr/ nie powinna być pusta");
        }

        private void buttonAddTrain_Click(object sender, EventArgs e)
        {
            string trainName = textBoxTrainName.Text,
                   trainModel = textBoxTrainModel.Text;

            if (trainName.Any(char.IsLetterOrDigit) && trainModel.Any(char.IsLetterOrDigit))
            {
                try
                {
                    if (Trains.AddTrain(sqlConnection, trainName, trainModel))
                        MessageBox.Show("Pociąg dodano pomyślnie!");
                    trains = Trains.GetAllTrains(sqlConnection);
                    dataGridViewCourses.DataSource = trains;

                    comboBoxTrains.Items.Clear();
                    for (int i = 0; i < trains.Rows.Count; i++)
                        comboBoxTrains.Items.Add(trains.Rows[i][1].ToString());

                    textBoxTrainName.Text = "";
                    textBoxTrainModel.Text = "";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            MessageBox.Show("Pola nie mogą być puste");

        }

        private void buttonDeleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = dataGridViewCourses.CurrentCell.RowIndex;
                int courseId = Int32.Parse(courses.Rows[selectedRow][0].ToString());
                if (Courses.DeleteCourse(sqlConnection, courseId))
                    MessageBox.Show("Kurs został usunięty pomyślnie!");
                courses = Courses.GetAllCourses(sqlConnection);
                dataGridViewCourses.DataSource = courses;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }          
        }

        private void buttonDisplayAllStations_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCourses.DataSource = Stations.GetAllStations(sqlConnection);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void buttonDisplayAllTrains_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCourses.DataSource = Trains.GetAllTrains(sqlConnection);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

      
    }
}
