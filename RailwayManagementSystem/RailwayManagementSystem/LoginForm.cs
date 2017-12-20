using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection sqlConnection;

        private static string adminPassword = "admin";
        private static string cashierPassword = "cashier";

        bool textBoxModified = false;

        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            //Łukasz
            //sqlConnection = new SqlConnection("Data Source=DESKTOP-CDUIBQ6\\SQLEXPRESS; database=SRBK_database;Trusted_Connection=yes");
            //Seba
            sqlConnection = new SqlConnection("Data Source=DESKTOP-G92BDEO\\SQLEXPRESS; database=SRBK_database;Trusted_Connection=yes");

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            comboBoxUserType.SelectedIndex = 1;
            textBoxPassword.Text = "Podaj hasło...";
            this.ActiveControl = textBoxPassword;
            textBoxPassword.SelectionStart = 0;
        }

        private bool CheckPassword(string password, int comboBoxIndex)
        {
            switch(comboBoxIndex)
            {
                case 0:
                    if (password.Equals(adminPassword))
                        return true;
                    else
                        return false;
                case 1:
                    if (password.Equals(cashierPassword))
                        return true;
                    else
                        return false;
                default:
                    return false;
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            if (CheckPassword(textBoxPassword.Text, comboBoxUserType.SelectedIndex))
            {
                switch (comboBoxUserType.SelectedIndex)
                {
                    case 0:
                        var adminForm = new AdminForm(this.sqlConnection);
                        adminForm.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
                        adminForm.Show();
                        this.Hide();
                        break;

                    case 1:
                        var cashierForm = new CashierForm(this.sqlConnection);
                        cashierForm.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
                        cashierForm.Show();
                        this.Hide();
                        break;
                }
            }
            else
                MessageBox.Show(this, "Błędne hasło!");

        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                buttonLogin.PerformClick();
                e.Handled = true;
            }

            if (!textBoxModified)
            {
                textBoxModified = true;
                textBoxPassword.Clear();
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.Text = e.KeyChar.ToString();
                textBoxPassword.SelectionStart = 1;
            }
        }
    }
}
