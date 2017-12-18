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

            var customerData = new Customers.CustomerData(textBoxCustomerName.Text != "" ? textBoxCustomerName.Text : SetDataIncorrect(),
                                                          textBoxCustomerSurname.Text != "" ? textBoxCustomerSurname.Text : SetDataIncorrect(),
                                                          textBoxCustomerAddress1.Text != "" ? textBoxCustomerAddress1.Text : SetDataIncorrect(),
                                                          textBoxCustomerAddress2.Text != "" ? textBoxCustomerAddress2.Text : SetDataIncorrect(),
                                                          textBoxCustomerZipCode.Text != "" ? textBoxCustomerZipCode.Text : SetDataIncorrect(),
                                                          textBoxCustomerPhoneNumber.Text != "" ? textBoxCustomerPhoneNumber.Text : SetDataIncorrect(),
                                                          textBoxCustomerEmail.Text != "" ? textBoxCustomerEmail.Text : SetDataIncorrect());
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
            string name = textBoxSearchByName.Text;
            var surname = textBoxSearchBySurname.Text;
            var email = textBoxSearchByEmail.Text;
            var phoneNumber = textBoxSearchByPhoneNumber.Text;

            string rowFilter = "";
            DataTable dataTable = (DataTable)dataGridViewCustomers.DataSource;

            rowFilter = string.Format("Imię LIKE '{0}%'", name);
            rowFilter += string.Format("AND Nazwisko LIKE '{0}%'", surname);
            rowFilter += string.Format("AND Email LIKE '{0}%'", email);
            rowFilter += string.Format("AND [Nr. tel.] LIKE '{0}%'", phoneNumber);
            dataTable.DefaultView.RowFilter = rowFilter;
        }

    }
}
