namespace RailwayManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogin.Location = new System.Drawing.Point(185, 255);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(121, 23);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBoxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUserType.Items.AddRange(new object[] {
            "Administrator",
            "Kasjer"});
            this.comboBoxUserType.Location = new System.Drawing.Point(185, 163);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserType.Sorted = true;
            this.comboBoxUserType.TabIndex = 0;
            this.comboBoxUserType.DropDownClosed += new System.EventHandler(this.comboBoxUserType_DropDownClosed);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(185, 212);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(121, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::RailwayManagementSystem.Properties.Resources.bckgrnd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(474, 403);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.comboBoxUserType);
            this.Controls.Add(this.buttonLogin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}

