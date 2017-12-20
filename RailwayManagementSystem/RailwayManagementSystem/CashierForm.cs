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
using System.Diagnostics;

namespace RailwayManagementSystem
{
    public partial class CashierForm : Form
    {
        SqlConnection sqlConnection;
        int selectedCourse = -1;
        int selectedCustomer = -1;

        public CashierForm()
        {   
            InitializeComponent();
            this.CenterToScreen();
            //Łukasz
            sqlConnection = new SqlConnection("Data Source=DESKTOP-CDUIBQ6\\SQLEXPRESS; database=SRBK_database;Trusted_Connection=yes");
            //Seba
            //sqlConnection = new SqlConnection("Data Source=DESKTOP-G92BDEO\\SQLEXPRESS; database=SRBK_database;Trusted_Connection=yes");

            dataGridViewCustomers.DataSource = Customers.GetAllCustomers(sqlConnection);
        }

        public CashierForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.sqlConnection = sqlConnection;
            dataGridViewCustomers.DataSource = Customers.GetAllCustomers(sqlConnection);
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            textBoxSearchByName.TextChanged += textBoxSearch_TextChanged;
            textBoxSearchBySurname.TextChanged += textBoxSearch_TextChanged;
            textBoxSearchByEmail.TextChanged += textBoxSearch_TextChanged;
            textBoxSearchByPhoneNumber.TextChanged += textBoxSearch_TextChanged;

            textBoxAddReservationSearchCustomerName.TextChanged += textBoxSearch_TextChangedReservation;
            textBoxAddReservationSearchCustomerSurname.TextChanged += textBoxSearch_TextChangedReservation;
            textBoxAddReservationSearchCustomerEmail.TextChanged += textBoxSearch_TextChangedReservation;
            textBoxAddReservationSearchCustomerPhoneNumber.TextChanged += textBoxSearch_TextChangedReservation;
        }

        private void buttonSearchAtoB_Click(object sender, EventArgs e)
        {
            using (DataTable dataTable = Courses.GetCoursesFromAtoB(sqlConnection, textBoxCityA.Text, textBoxCityB.Text))
            {
                if ( dataTable != null)
                    dataGridViewCourses.DataSource = dataTable;
                else
                    MessageBox.Show("Kurs o podanych danych nie istnieje!");
            }
           
        }

        private void buttonShowCourseVisits_Click(object sender, EventArgs e)
        {
            using (DataTable dataTable = Courses.GetCourseVisits(sqlConnection, textBoxCourseVisits.Text))
            {   
                if (dataTable != null)
                    dataGridViewCourses.DataSource = dataTable;
                else
                    MessageBox.Show("Kurs o podanych danych nie istnieje!");
            }
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            bool isDataCorrect = true;

            string SetDataIncorrect()
            {
                isDataCorrect = false;
                return "";
            }

            var customerData = new Customers.CustomerData(textBoxNewCustomerName.Text != "" ? textBoxNewCustomerName.Text : SetDataIncorrect(),
                                                          textBoxNewCustomerSurname.Text != "" ? textBoxNewCustomerSurname.Text : SetDataIncorrect(),
                                                          textBoxNewCustomerAddress.Text != "" ? textBoxNewCustomerAddress.Text : SetDataIncorrect(),
                                                          textBoxNewCustomerCity.Text != "" ? textBoxNewCustomerCity.Text : SetDataIncorrect(),
                                                          textBoxNewCustomerZipCode.Text != "" ? textBoxNewCustomerZipCode.Text : SetDataIncorrect(),
                                                          textBoxNewCustomerPhoneNumber.Text != "" ? textBoxNewCustomerPhoneNumber.Text : SetDataIncorrect(),
                                                          textBoxNewCustomerEmail.Text != "" ? textBoxNewCustomerEmail.Text : SetDataIncorrect());
            if (isDataCorrect)
            {
                if (Customers.AddNewCustomer(sqlConnection, customerData))
                {
                    MessageBox.Show("Pomyślnie dodano użytkownika");
                    dataGridViewCustomers.DataSource = Customers.GetAllCustomers(sqlConnection);
                }
                else
                    //Taki użytkownik już istnieje
                    MessageBox.Show("Nie udało się dodać użytkownika!");
            }
            else
                MessageBox.Show("Błędne dane! Pola nie mogą być puste!");
           
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {   
            var name = textBoxSearchByName.Text;
            var surname = textBoxSearchBySurname.Text;
            var email = textBoxSearchByEmail.Text;
            var phoneNumber = textBoxSearchByPhoneNumber.Text;

            DataTable dataTable = (DataTable)dataGridViewCustomers.DataSource;
            string rowFilter = "";

            rowFilter = string.Format("Imię LIKE '{0}%'", name);
            rowFilter += string.Format("AND Nazwisko LIKE '{0}%'", surname);
            rowFilter += string.Format("AND Email LIKE '{0}%'", email);
            rowFilter += string.Format("AND [Nr. tel.] LIKE '{0}%'", phoneNumber);
            dataTable.DefaultView.RowFilter = rowFilter;
        }

        private void textBoxSearch_TextChangedReservation(object sender, EventArgs e)
        {
            var name = textBoxAddReservationSearchCustomerName.Text;
            var surname = textBoxAddReservationSearchCustomerSurname.Text;
            var email = textBoxAddReservationSearchCustomerEmail.Text;
            var phoneNumber = textBoxAddReservationSearchCustomerPhoneNumber.Text;

            DataTable dataTable = (DataTable)dataGridViewCustomers.DataSource;
            string rowFilter = "";

            rowFilter = string.Format("Imię LIKE '{0}%'", name);
            rowFilter += string.Format("AND Nazwisko LIKE '{0}%'", surname);
            rowFilter += string.Format("AND Email LIKE '{0}%'", email);
            rowFilter += string.Format("AND [Nr. tel.] LIKE '{0}%'", phoneNumber);
            dataTable.DefaultView.RowFilter = rowFilter;
            dataGridViewReservations.DataSource = dataTable;
            Debug.WriteLine("ZMIANA");
        }

        private void buttonAdReservationSearchCoursesAB_Click(object sender, EventArgs e)
        {
            string cityA = comboBoxCityA.Text;
            string cityB = comboBoxCityB.Text;

            using (DataTable dataTable = Courses.GetAvaibleCoursesFromAtoB(sqlConnection, cityA, cityB))
            {
                if (dataTable != null)
                    dataGridViewReservations.DataSource = dataTable;
            }
        }

        private void buttonAddReservationSaveCourseID_Click(object sender, EventArgs e)
        {
            try
            {
                selectedCourse = Int32.Parse(dataGridViewReservations.Rows[dataGridViewReservations.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show("Nie wybrano kursu!");
            }
        }

        private void tabControl2_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxCityA.Items.Clear();
                var stations = Stations.GetAllStations(sqlConnection);
                for (int i = 0; i < stations.Rows.Count; i++)
                {
                    comboBoxCityA.Items.Add(stations.Rows[i][1].ToString());
                    comboBoxCityB.Items.Add(stations.Rows[i][1].ToString());
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonAddReservationSaveSelectedCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                selectedCustomer = Int32.Parse(dataGridViewReservations.Rows[dataGridViewReservations.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            //string customerId, string price, string courseId, string stationA, string stationB, string seatNumber)
            string customerId = selectedCustomer.ToString();
            string price = 30.ToString();
            string courseId = selectedCourse.ToString();
            string stationA = comboBoxCityA.Text;
            string stationB = comboBoxCityB.Text;
            try
            {
                string seatNumber = Seats.GetRandomSeat(sqlConnection, courseId, stationA, stationB).ToString();
                if (Reservations.AddReservations(sqlConnection, customerId, price, courseId, stationA, stationB, seatNumber))
                    MessageBox.Show("Rezerwacja została pomyślnie dodana!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
