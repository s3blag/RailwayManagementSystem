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
        SqlDataAdapter sqlDataAdapter;

        public CashierForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=DESKTOP-G92BDEO\\SQLEXPRESS; database=SRBK_database;Trusted_Connection=yes");
        }

        public CashierForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.sqlConnection = sqlConnection;
            
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {

        }

        //sqlDataAdapter = new SqlDataAdapter("SELECT * FROM SHOW_TRAINS", sqlConnection);
        //DataTable dataTable = new DataTable();
        //sqlDataAdapter.Fill(dataTable);
        //dataGridView1.DataSource = dataTable;
    }
}
