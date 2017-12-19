namespace RailwayManagementSystem
{
    partial class CashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonShowCourseVisits = new System.Windows.Forms.Button();
            this.textBoxCourseVisits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearchAtoB = new System.Windows.Forms.Button();
            this.textBoxCityB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCityA = new System.Windows.Forms.TextBox();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxSearchByPhoneNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSearchByEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSearchBySurname = new System.Windows.Forms.TextBox();
            this.textBoxSearchByName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCustomerEmail = new System.Windows.Forms.TextBox();
            this.textBoxCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCustomerZipCode = new System.Windows.Forms.TextBox();
            this.textBoxCustomerAddress2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCustomerAddress1 = new System.Windows.Forms.TextBox();
            this.buttonAddNewCustomer = new System.Windows.Forms.Button();
            this.textBoxCustomerSurname = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 750);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridViewCourses);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 724);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kursy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonShowCourseVisits);
            this.groupBox2.Controls.Add(this.textBoxCourseVisits);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 561);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 157);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyświetl trasę dla kursu";
            // 
            // buttonShowCourseVisits
            // 
            this.buttonShowCourseVisits.Location = new System.Drawing.Point(202, 67);
            this.buttonShowCourseVisits.Name = "buttonShowCourseVisits";
            this.buttonShowCourseVisits.Size = new System.Drawing.Size(75, 23);
            this.buttonShowCourseVisits.TabIndex = 5;
            this.buttonShowCourseVisits.Text = "Szukaj";
            this.buttonShowCourseVisits.UseVisualStyleBackColor = true;
            this.buttonShowCourseVisits.Click += new System.EventHandler(this.buttonShowCourseVisits_Click);
            // 
            // textBoxCourseVisits
            // 
            this.textBoxCourseVisits.Location = new System.Drawing.Point(19, 70);
            this.textBoxCourseVisits.Name = "textBoxCourseVisits";
            this.textBoxCourseVisits.Size = new System.Drawing.Size(100, 20);
            this.textBoxCourseVisits.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Podaj ID kursu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearchAtoB);
            this.groupBox1.Controls.Add(this.textBoxCityB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCityA);
            this.groupBox1.Location = new System.Drawing.Point(6, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyświetl kursy";
            // 
            // buttonSearchAtoB
            // 
            this.buttonSearchAtoB.Location = new System.Drawing.Point(385, 78);
            this.buttonSearchAtoB.Name = "buttonSearchAtoB";
            this.buttonSearchAtoB.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchAtoB.TabIndex = 3;
            this.buttonSearchAtoB.Text = "Szukaj";
            this.buttonSearchAtoB.UseVisualStyleBackColor = true;
            this.buttonSearchAtoB.Click += new System.EventHandler(this.buttonSearchAtoB_Click);
            // 
            // textBoxCityB
            // 
            this.textBoxCityB.Location = new System.Drawing.Point(202, 78);
            this.textBoxCityB.Name = "textBoxCityB";
            this.textBoxCityB.Size = new System.Drawing.Size(100, 20);
            this.textBoxCityB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miejsce docelowe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miejsce początkowe:";
            // 
            // textBoxCityA
            // 
            this.textBoxCityA.Location = new System.Drawing.Point(19, 78);
            this.textBoxCityA.Name = "textBoxCityA";
            this.textBoxCityA.Size = new System.Drawing.Size(100, 20);
            this.textBoxCityA.TabIndex = 1;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.Size = new System.Drawing.Size(711, 420);
            this.dataGridViewCourses.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dataGridViewCustomers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 724);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Klienci";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxSearchByPhoneNumber);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBoxSearchByEmail);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBoxSearchBySurname);
            this.groupBox4.Controls.Add(this.textBoxSearchByName);
            this.groupBox4.Location = new System.Drawing.Point(6, 557);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(702, 161);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wyszukaj klienta";
            // 
            // textBoxSearchByPhoneNumber
            // 
            this.textBoxSearchByPhoneNumber.Location = new System.Drawing.Point(536, 78);
            this.textBoxSearchByPhoneNumber.Name = "textBoxSearchByPhoneNumber";
            this.textBoxSearchByPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchByPhoneNumber.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(533, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Nr. telefonu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(380, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nazwisko:";
            // 
            // textBoxSearchByEmail
            // 
            this.textBoxSearchByEmail.Location = new System.Drawing.Point(383, 78);
            this.textBoxSearchByEmail.Name = "textBoxSearchByEmail";
            this.textBoxSearchByEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchByEmail.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Imię:";
            // 
            // textBoxSearchBySurname
            // 
            this.textBoxSearchBySurname.Location = new System.Drawing.Point(230, 78);
            this.textBoxSearchBySurname.Name = "textBoxSearchBySurname";
            this.textBoxSearchBySurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchBySurname.TabIndex = 7;
            // 
            // textBoxSearchByName
            // 
            this.textBoxSearchByName.Location = new System.Drawing.Point(77, 78);
            this.textBoxSearchByName.Name = "textBoxSearchByName";
            this.textBoxSearchByName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchByName.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxCustomerEmail);
            this.groupBox3.Controls.Add(this.textBoxCustomerPhoneNumber);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxCustomerZipCode);
            this.groupBox3.Controls.Add(this.textBoxCustomerAddress2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxCustomerAddress1);
            this.groupBox3.Controls.Add(this.buttonAddNewCustomer);
            this.groupBox3.Controls.Add(this.textBoxCustomerSurname);
            this.groupBox3.Controls.Add(this.textBoxCustomerName);
            this.groupBox3.Location = new System.Drawing.Point(6, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(702, 143);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodaj klienta";
            // 
            // buttonAddNewCustomer
            // 
            this.buttonAddNewCustomer.Location = new System.Drawing.Point(604, 66);
            this.buttonAddNewCustomer.Name = "buttonAddNewCustomer";
            this.buttonAddNewCustomer.Size = new System.Drawing.Size(92, 20);
            this.buttonAddNewCustomer.TabIndex = 2;
            this.buttonAddNewCustomer.Text = "Dodaj";
            this.buttonAddNewCustomer.UseVisualStyleBackColor = true;
            this.buttonAddNewCustomer.Click += new System.EventHandler(this.buttonAddNewCustomer_Click);
            // 
            // textBoxCustomerSurname
            // 
            this.textBoxCustomerSurname.Location = new System.Drawing.Point(6, 90);
            this.textBoxCustomerSurname.Name = "textBoxCustomerSurname";
            this.textBoxCustomerSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerSurname.TabIndex = 2;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(6, 46);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerName.TabIndex = 3;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(702, 385);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(714, 724);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rezerwacje";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(746, 774);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierForm";
            this.Text = "Kasjer";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearchAtoB;
        private System.Windows.Forms.TextBox textBoxCityB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCityA;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Button buttonShowCourseVisits;
        private System.Windows.Forms.TextBox textBoxCourseVisits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCustomerSurname;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Button buttonAddNewCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCustomerEmail;
        private System.Windows.Forms.TextBox textBoxCustomerPhoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCustomerZipCode;
        private System.Windows.Forms.TextBox textBoxCustomerAddress2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCustomerAddress1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxSearchByPhoneNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSearchByEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSearchBySurname;
        private System.Windows.Forms.TextBox textBoxSearchByName;
    }
}