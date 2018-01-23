using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace RailwayManagementSystem
{
    public partial class AdminForm : Form
    {
        SqlConnection _sqlConnection;
        DataTable _trains;
        DataTable _courses;
        DataTable _stations;

        public AdminForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            var machineName = Environment.MachineName;
            _sqlConnection = new SqlConnection("Data Source=" + machineName + "\\SQLEXPRESS; database=SRBK_database;Trusted_Connection=yes");
           
        }

        public AdminForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.CenterToScreen();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            this._sqlConnection = sqlConnection;
        }

        private void buttonSearchAtoB_Click_1(object sender, EventArgs e)
        {
            string cityA = textBoxCityA.Text,
                   cityB = textBoxCityB.Text;
            
            if(!cityA.Any(char.IsDigit) && !cityB.Any(char.IsDigit))
                try
                {
                    using (DataTable dataTable = Courses.GetCoursesFromAtoB(_sqlConnection, cityA, cityB))
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
                    using (DataTable dataTable = Courses.GetCourseVisits(_sqlConnection, id))
                    {

                        if (dataTable != null)
                            dataGridViewCourses.DataSource = dataTable;
                        else
                            MessageBox.Show("Kurs o podanych danych nie istnieje!");
                        textBoxCourseVisits.Text = "";
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
                _courses = Courses.GetAllCourses(_sqlConnection);
                dataGridViewCourses.DataSource = _courses;
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
                    int index = Int32.Parse(_trains.Rows[comboBoxTrains.SelectedIndex][0].ToString());

                    if (Courses.AddCourse(_sqlConnection, index))
                        MessageBox.Show("Kurs został dodany pomyślnie!");
                    _courses = Courses.GetAllCourses(_sqlConnection);
                    dataGridViewCourses.DataSource = _courses;

                    comboBoxCourses.Items.Clear();
                    for (int i = 0; i < _courses.Rows.Count; i++)
                        comboBoxCourses.Items.Add(_courses.Rows[i][0].ToString());
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
                _trains = Trains.GetAllTrains(_sqlConnection);

                comboBoxTrains.Items.Clear();
                for (int i = 0; i < _trains.Rows.Count; i++)
                    comboBoxTrains.Items.Add(_trains.Rows[i][1].ToString());

                _courses = Courses.GetAllCourses(_sqlConnection);

                comboBoxCourses.Items.Clear();
                for (int i = 0; i < _courses.Rows.Count; i++)
                    comboBoxCourses.Items.Add(_courses.Rows[i][0].ToString());

                comboBoxStations.Items.Clear();
                _stations = Stations.GetAllStations(_sqlConnection);
                for (int i = 0; i < _stations.Rows.Count; i++)
                    comboBoxStations.Items.Add(_stations.Rows[i][1].ToString());
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
                string courseIndex = _courses.Rows[comboBoxCourses.SelectedIndex][0].ToString();
                string stationIndex = _stations.Rows[comboBoxStations.SelectedIndex][0].ToString();
                string visitOrder = (Courses.GetNumberOfVisits(_sqlConnection, courseIndex) + 1).ToString();
                string avaibleSeats = 50.ToString();

                Visits.VisitData visitData = new Visits.VisitData(stationIndex, courseIndex, visitOrder, avaibleSeats, date);
                if (Visits.AddNewVisit(_sqlConnection, visitData))
                    MessageBox.Show("Przystanek dodano pomyślnie");

                string visitIndex = Visits.GetVisitId(_sqlConnection, courseIndex, visitOrder);
                Seats.AddSeats(_sqlConnection, courseIndex, visitIndex, 50);

                dataGridViewCourses.DataSource = Courses.GetCourseVisits(_sqlConnection, courseIndex);
                _courses = Courses.GetAllCourses(_sqlConnection);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void comboBoxCourses_Click(object sender, EventArgs e)
        {
            dataGridViewCourses.DataSource = _courses;
        }

        private void buttonAddStation_Click(object sender, EventArgs e)
        {
            string stationName = textBoxStationName.Text;

            if (!stationName.Any(char.IsDigit) && stationName.Any(char.IsLetter) && stationName.Length < 51)
            {
                try
                {
                    if (Stations.AddStation(_sqlConnection, stationName))
                        MessageBox.Show("Stacja została dodana pomyślnie!");
                    _stations = Stations.GetAllStations(_sqlConnection);
                    dataGridViewCourses.DataSource = _stations;

                    comboBoxStations.Items.Clear();
                    _stations = Stations.GetAllStations(_sqlConnection);
                    for (int i = 0; i < _stations.Rows.Count; i++)
                        comboBoxStations.Items.Add(_stations.Rows[i][1].ToString());

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

            if (trainName.Any(char.IsLetterOrDigit) && trainModel.Any(char.IsLetterOrDigit) && trainName.Length < 51 && trainModel.Length < 51)
            {
                try
                {
                    if (Trains.AddTrain(_sqlConnection, trainName, trainModel))
                        MessageBox.Show("Pociąg dodano pomyślnie!");
                    _trains = Trains.GetAllTrains(_sqlConnection);
                    dataGridViewCourses.DataSource = _trains;

                    comboBoxTrains.Items.Clear();
                    for (int i = 0; i < _trains.Rows.Count; i++)
                        comboBoxTrains.Items.Add(_trains.Rows[i][1].ToString());

                    textBoxTrainName.Text = "";
                    textBoxTrainModel.Text = "";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
                MessageBox.Show("Pola nie mogą być puste");

        }

        private void buttonDeleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = dataGridViewCourses.CurrentCell.RowIndex;
                int courseId = Int32.Parse(_courses.Rows[selectedRow][0].ToString());
                if (Courses.DeleteCourse(_sqlConnection, courseId))
                    MessageBox.Show("Kurs został usunięty pomyślnie!");
                _courses = Courses.GetAllCourses(_sqlConnection);
                dataGridViewCourses.DataSource = _courses;
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
                dataGridViewCourses.DataSource = Stations.GetAllStations(_sqlConnection);
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
                dataGridViewCourses.DataSource = Trains.GetAllTrains(_sqlConnection);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
