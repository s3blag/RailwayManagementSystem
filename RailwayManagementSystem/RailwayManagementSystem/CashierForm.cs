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
            this.sqlConnection = sqlConnection;
            
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {

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
            if (Customers.AddNewCustomer(sqlConnection, new Customers.CustomerData("Łukasz", "Zatorski", "Prosta 1", "Wrocław", "50-439", "123456789", "zatorski@zatorski.pl")))
            {
                MessageBox.Show("Pomyślnie dodano użytkownika");
                dataGridViewCustomers.DataSource = Customers.GetAllCustomers(sqlConnection);
            }
            else
                MessageBox.Show("Nie udało się dodać użytkownika!");
        }
    }
}
