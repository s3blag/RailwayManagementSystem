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
    public partial class CashierForm : Form
    {
        SqlConnection sqlConnection;

        public CashierForm()
        {   
            InitializeComponent();
            this.CenterToScreen();
            //Łukasz
            //sqlConnection = new SqlConnection("Data Source=DESKTOP-CDUIBQ6\\SQLEXPRESS; database=SRBK_database;Trusted_Connection=yes");
            //Seba
            sqlConnection = new SqlConnection("Data Source=DESKTOP-G92BDEO\\SQLEXPRESS; database=SRBK_database;Trusted_Connection=yes");

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

        }

        private void buttonSearchAtoB_Click(object sender, EventArgs e)
        {
            string cityA = textBoxCityA.Text,
                   cityB = textBoxCityA.Text;

            if (!cityA.Any(char.IsDigit) && !cityB.Any(char.IsDigit))
            {
                using (DataTable dataTable = Courses.GetCoursesFromAtoB(sqlConnection, cityA, cityB))
                {
                    if (dataTable != null)
                        dataGridViewCourses.DataSource = dataTable;
                    else
                        MessageBox.Show("Kurs o podanych danych nie istnieje!");
                }
            }
            else
            {
                textBoxCityA.Text = "";
                textBoxCityB.Text = "";
                MessageBox.Show("Nazwy stacji nie zawierają cyfr");
            }
                

            

        }

        private void buttonShowCourseVisits_Click(object sender, EventArgs e)
        {
            string id = textBoxCourseVisits.Text;

            if (id.All(char.IsDigit))
            {
                using (DataTable dataTable = Courses.GetCourseVisits(sqlConnection, id))
                {
                    if (dataTable != null)
                        dataGridViewCourses.DataSource = dataTable;
                    else
                        MessageBox.Show("Kurs o podanych danych nie istnieje!");

                }
            }
            else
            {
                MessageBox.Show("ID musi być liczbą!");
                textBoxCourseVisits.Text = "";
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

            var customerData = new Customers.CustomerData(
                                                          textBoxNewCustomerName.Text.All(char.IsLetter) ? textBoxNewCustomerName.Text : SetDataIncorrect(),
                                                          textBoxNewCustomerSurname.Text.All(char.IsLetter) ? textBoxNewCustomerSurname.Text : SetDataIncorrect(),
                                                          textBoxNewCustomerAddress.Text.Any(char.IsLetter) && textBoxNewCustomerAddress.Text.Any(char.IsDigit) ? textBoxNewCustomerAddress.Text : SetDataIncorrect(),
                                                          textBoxNewCustomerCity.Text.All(char.IsLetter) ? textBoxNewCustomerCity.Text : SetDataIncorrect(),
                                                          !textBoxNewCustomerZipCode.Text.Any(char.IsLetter) && textBoxNewCustomerZipCode.Text.Length == 6 && textBoxNewCustomerZipCode.Text.Contains('-') ? textBoxNewCustomerZipCode.Text : SetDataIncorrect(),
                                                          textBoxNewCustomerPhoneNumber.Text.All(char.IsDigit) && textBoxNewCustomerPhoneNumber.Text.Length == 11 ? textBoxNewCustomerPhoneNumber.Text : SetDataIncorrect(),
                                                          textBoxNewCustomerEmail.Text.Contains('@') && textBoxNewCustomerEmail.Text.Contains('.') && textBoxNewCustomerEmail.Text.Length > 2 ? textBoxNewCustomerEmail.Text : SetDataIncorrect());


            //var customerData = new Customers.CustomerData(textBoxNewCustomerName.Text != "" ? textBoxNewCustomerName.Text : SetDataIncorrect(),
            //                                              textBoxNewCustomerSurname.Text != "" ? textBoxNewCustomerSurname.Text : SetDataIncorrect(),
            //                                              textBoxNewCustomerAddress.Text != "" ? textBoxNewCustomerAddress.Text : SetDataIncorrect(),
            //                                              textBoxNewCustomerCity.Text != "" ? textBoxNewCustomerCity.Text : SetDataIncorrect(),
            //                                              textBoxNewCustomerZipCode.Text != "" ? textBoxNewCustomerZipCode.Text : SetDataIncorrect(),
            //                                              textBoxNewCustomerPhoneNumber.Text != "" ? textBoxNewCustomerPhoneNumber.Text : SetDataIncorrect(),
            //                                              textBoxNewCustomerEmail.Text != "" ? textBoxNewCustomerEmail.Text : SetDataIncorrect());


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
                MessageBox.Show("Błędne dane!");
           
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {   
            var name = textBoxSearchByName.Text;
            var surname = textBoxSearchBySurname.Text;
            var email = textBoxSearchByEmail.Text;
            var phoneNumber = textBoxSearchByPhoneNumber.Text;

            DataTable dataTable = (DataTable)dataGridViewCustomers.DataSource;
    
            string rowFilter = string.Format("Imię LIKE '{0}%'", name);
            rowFilter += string.Format("AND Nazwisko LIKE '{0}%'", surname);
            rowFilter += string.Format("AND Email LIKE '{0}%'", email);
            rowFilter += string.Format("AND [Nr. tel.] LIKE '{0}%'", phoneNumber);

            dataTable.DefaultView.RowFilter = rowFilter;
        }

        private void buttonAdReservationSearchCoursesAB_Click(object sender, EventArgs e)
        {
            string cityA = textBoxAddReservationCityA.Text;
            string cityB = textBoxAddReservationCityB.Text;

            if (cityA.Any(char.IsDigit) == false && cityB.Any(char.IsDigit) == false)
                using (DataTable dataTable = Courses.GetCoursesFromAtoB(sqlConnection, cityA, cityB))
                {
                    if (dataTable != null)
                        dataGridViewReservations.DataSource = dataTable;
                }
            else
                MessageBox.Show("Nazwy stacji nie powinny zawierać cyfr");
        }

      
    }
}
