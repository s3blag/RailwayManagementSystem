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

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonShowCourseVisits_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchAtoB_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchAtoB_Click_1(object sender, EventArgs e)
        {
            using (DataTable dataTable = Courses.GetCoursesFromAtoB(sqlConnection, textBoxCityA.Text, textBoxCityB.Text))
            {
                if (dataTable != null)
                    dataGridViewCourses.DataSource = dataTable;
                else
                    MessageBox.Show("Kurs o podanych danych nie istnieje!");
            }
        }

        private void buttonShowCourseVisits_Click_1(object sender, EventArgs e)
        {
            using (DataTable dataTable = Courses.GetCourseVisits(sqlConnection, textBoxCourseVisits.Text))
            {
                if (dataTable != null)
                    dataGridViewCourses.DataSource = dataTable;
                else
                    MessageBox.Show("Kurs o podanych danych nie istnieje!");
            }
        }

        private void buttonSelectAllCourses_Click(object sender, EventArgs e)
        {
            courses = Courses.GetAllCourses(sqlConnection);
            dataGridViewCourses.DataSource = courses;
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            if(comboBoxTrains.SelectedIndex != -1)
            {
                int index = Int32.Parse(trains.Rows[comboBoxTrains.SelectedIndex][0].ToString());
                Courses.AddCourse(sqlConnection, index);
                courses = Courses.GetAllCourses(sqlConnection);
                dataGridViewCourses.DataSource = courses;
                comboBoxCourses.Items.Clear();
                for (int i = 0; i < courses.Rows.Count; i++)
                    comboBoxCourses.Items.Add(courses.Rows[i][0].ToString());
            }
        }

        private void tabControlCourses_Click(object sender, EventArgs e)
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

        private void buttonAddVisit_Click(object sender, EventArgs e)
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
            Visits.AddNewVisit(sqlConnection, visitData);
            string visitIndex = Visits.GetVisitId(sqlConnection, courseIndex, visitOrder);
            Seats.AddSeats(sqlConnection, courseIndex, visitIndex, 50);
            dataGridViewCourses.DataSource = Courses.GetCourseVisits(sqlConnection, courseIndex);
            courses = Courses.GetAllCourses(sqlConnection);

        }

        private void comboBoxCourses_Click(object sender, EventArgs e)
        {
            dataGridViewCourses.DataSource = courses;
        }

        private void buttonAddStation_Click(object sender, EventArgs e)
        {
            try
            {
                Stations.AddStation(sqlConnection, textBoxStationName.Text);
                dataGridViewCourses.DataSource = Stations.GetAllStations(sqlConnection);                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonAddTrain_Click(object sender, EventArgs e)
        {
            try
            {
                Trains.AddTrain(sqlConnection, textBoxTrainName.Text, textBoxTrainModel.Text);
                dataGridViewCourses.DataSource = Trains.GetAllTrains(sqlConnection);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
