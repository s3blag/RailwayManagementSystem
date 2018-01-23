using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayManagementSystem
{
    public partial class LoginForm : Form
    {
        private SqlConnection _sqlConnection;

        private static string _adminPassword = "admin";
        private static string _cashierPassword = "cashier";

        private bool _textBoxModified = false;

        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            var machineName = Environment.MachineName;
            _sqlConnection = new SqlConnection("Data Source="+ machineName + "\\SQLEXPRESS; database=SRBK_database;Trusted_Connection=yes");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            comboBoxUserType.SelectedIndex = 1;
            textBoxPassword.Text = "Podaj hasło...";
            this.ActiveControl = textBoxPassword;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            textBoxPassword.SelectionStart = 0;
        }

        private bool CheckPassword(string password, int comboBoxIndex)
        {
            switch(comboBoxIndex)
            {
                case 0:
                    if (password.Equals(_adminPassword))
                        return true;
                    else
                        return false;
                case 1:
                    if (password.Equals(_cashierPassword))
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
                        var adminForm = new AdminForm(this._sqlConnection);
                        adminForm.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
                        adminForm.Show();
                        this.Hide();
                        break;

                    case 1:
                        var cashierForm = new CashierForm(this._sqlConnection);
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

            if (!_textBoxModified)
            {
                _textBoxModified = true;
                textBoxPassword.Clear();
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.Text = e.KeyChar.ToString();
                textBoxPassword.SelectionStart = 1;
            }
        }
    }
}
