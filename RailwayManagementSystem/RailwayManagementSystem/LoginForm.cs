using System;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RailwayManagementSystem
{
    public partial class LoginForm : Form
    {
        private SqlConnection _sqlConnection;

        private bool _textBoxModified = false;

        #region OnLoad Actions

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
        #endregion

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxUserType.SelectedIndex)
                {
                    case 0:
                        if((bool)Logins.Validate("Admin", Encrypt(textBoxPassword.Text), _sqlConnection))
                        {
                            var adminForm = new AdminForm(this._sqlConnection);
                            adminForm.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Błędne hasło!");
                        }
                        break;

                    case 1:
                        if ((bool)Logins.Validate("Cashier", Encrypt(textBoxPassword.Text), _sqlConnection))
                        {
                            var cashierForm = new CashierForm(this._sqlConnection);
                            cashierForm.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
                            cashierForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Błędne hasło!");
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Bład zapytania do BD!");
            }
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

        #region AES encryption

        private string Encrypt(string clearText)
        {
            string encryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

            using (Aes encryptor = Aes.Create())
            {
                var pdb = new Rfc2898DeriveBytes(encryptionKey,
                    new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            string encryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            using (Aes encryptor = Aes.Create())
            {
                var pdb = new Rfc2898DeriveBytes(encryptionKey, 
                    new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        
    }
    #endregion
}
