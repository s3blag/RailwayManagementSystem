namespace RailwayManagementSystem
{
    partial class AdminForm
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageCourses = new System.Windows.Forms.TabPage();
            this.tabControlCourses = new System.Windows.Forms.TabControl();
            this.tabPageManage = new System.Windows.Forms.TabPage();
            this.groupBoxManageCourses = new System.Windows.Forms.GroupBox();
            this.buttonDeleteCourse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonShowCourseVisits = new System.Windows.Forms.Button();
            this.textBoxCourseVisits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSelectAllCourses = new System.Windows.Forms.Button();
            this.buttonSearchAtoB = new System.Windows.Forms.Button();
            this.textBoxCityB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCityA = new System.Windows.Forms.TextBox();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.groupBoxAddVisit = new System.Windows.Forms.GroupBox();
            this.comboBoxStations = new System.Windows.Forms.ComboBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelMinutest = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonAddVisit = new System.Windows.Forms.Button();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.groupBoxAddCourse = new System.Windows.Forms.GroupBox();
            this.comboBoxTrains = new System.Windows.Forms.ComboBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.tabPageOthers = new System.Windows.Forms.TabPage();
            this.groupBoxTrains = new System.Windows.Forms.GroupBox();
            this.buttonAddTrain = new System.Windows.Forms.Button();
            this.textBoxTrainModel = new System.Windows.Forms.TextBox();
            this.textBoxTrainName = new System.Windows.Forms.TextBox();
            this.groupBoxStations = new System.Windows.Forms.GroupBox();
            this.buttonAddStation = new System.Windows.Forms.Button();
            this.textBoxStationName = new System.Windows.Forms.TextBox();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.buttonDisplayAllStations = new System.Windows.Forms.Button();
            this.buttonDisplayAllTrains = new System.Windows.Forms.Button();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageCourses.SuspendLayout();
            this.tabControlCourses.SuspendLayout();
            this.tabPageManage.SuspendLayout();
            this.groupBoxManageCourses.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.groupBoxAddVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.groupBoxAddCourse.SuspendLayout();
            this.tabPageOthers.SuspendLayout();
            this.groupBoxTrains.SuspendLayout();
            this.groupBoxStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageCourses);
            this.tabControlAdmin.Controls.Add(this.tabPageOthers);
            this.tabControlAdmin.Location = new System.Drawing.Point(13, 322);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(902, 442);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPageCourses
            // 
            this.tabPageCourses.Controls.Add(this.tabControlCourses);
            this.tabPageCourses.Location = new System.Drawing.Point(4, 22);
            this.tabPageCourses.Name = "tabPageCourses";
            this.tabPageCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCourses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageCourses.Size = new System.Drawing.Size(894, 416);
            this.tabPageCourses.TabIndex = 0;
            this.tabPageCourses.Text = "Kursy";
            this.tabPageCourses.UseVisualStyleBackColor = true;
            // 
            // tabControlCourses
            // 
            this.tabControlCourses.Controls.Add(this.tabPageManage);
            this.tabControlCourses.Controls.Add(this.tabPageAdd);
            this.tabControlCourses.Location = new System.Drawing.Point(3, 6);
            this.tabControlCourses.Name = "tabControlCourses";
            this.tabControlCourses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlCourses.SelectedIndex = 0;
            this.tabControlCourses.Size = new System.Drawing.Size(882, 407);
            this.tabControlCourses.TabIndex = 0;
            this.tabControlCourses.Click += new System.EventHandler(this.tabControlCourses_Click);
            // 
            // tabPageManage
            // 
            this.tabPageManage.Controls.Add(this.groupBoxManageCourses);
            this.tabPageManage.Controls.Add(this.groupBox2);
            this.tabPageManage.Controls.Add(this.groupBox1);
            this.tabPageManage.Location = new System.Drawing.Point(4, 22);
            this.tabPageManage.Name = "tabPageManage";
            this.tabPageManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManage.Size = new System.Drawing.Size(874, 381);
            this.tabPageManage.TabIndex = 0;
            this.tabPageManage.Text = "Zarządzaj";
            this.tabPageManage.UseVisualStyleBackColor = true;
            // 
            // groupBoxManageCourses
            // 
            this.groupBoxManageCourses.Controls.Add(this.buttonDeleteCourse);
            this.groupBoxManageCourses.Location = new System.Drawing.Point(6, 273);
            this.groupBoxManageCourses.Name = "groupBoxManageCourses";
            this.groupBoxManageCourses.Size = new System.Drawing.Size(862, 100);
            this.groupBoxManageCourses.TabIndex = 5;
            this.groupBoxManageCourses.TabStop = false;
            this.groupBoxManageCourses.Text = "Zarządzaj";
            // 
            // buttonDeleteCourse
            // 
            this.buttonDeleteCourse.Location = new System.Drawing.Point(19, 41);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(101, 23);
            this.buttonDeleteCourse.TabIndex = 0;
            this.buttonDeleteCourse.Text = "Usuń zaznaczony";
            this.buttonDeleteCourse.UseVisualStyleBackColor = true;
            this.buttonDeleteCourse.Click += new System.EventHandler(this.buttonDeleteCourse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonShowCourseVisits);
            this.groupBox2.Controls.Add(this.textBoxCourseVisits);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 126);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyświetl trasę dla kursu";
            // 
            // buttonShowCourseVisits
            // 
            this.buttonShowCourseVisits.Location = new System.Drawing.Point(194, 68);
            this.buttonShowCourseVisits.Name = "buttonShowCourseVisits";
            this.buttonShowCourseVisits.Size = new System.Drawing.Size(75, 23);
            this.buttonShowCourseVisits.TabIndex = 5;
            this.buttonShowCourseVisits.Text = "Szukaj";
            this.buttonShowCourseVisits.UseVisualStyleBackColor = true;
            this.buttonShowCourseVisits.Click += new System.EventHandler(this.buttonShowCourseVisits_Click_1);
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
            this.groupBox1.Controls.Add(this.buttonSelectAllCourses);
            this.groupBox1.Controls.Add(this.buttonSearchAtoB);
            this.groupBox1.Controls.Add(this.textBoxCityB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCityA);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyświetl kursy";
            // 
            // buttonSelectAllCourses
            // 
            this.buttonSelectAllCourses.Location = new System.Drawing.Point(519, 75);
            this.buttonSelectAllCourses.Name = "buttonSelectAllCourses";
            this.buttonSelectAllCourses.Size = new System.Drawing.Size(122, 23);
            this.buttonSelectAllCourses.TabIndex = 5;
            this.buttonSelectAllCourses.Text = "Wyswietl wszystkie";
            this.buttonSelectAllCourses.UseVisualStyleBackColor = true;
            this.buttonSelectAllCourses.Click += new System.EventHandler(this.buttonSelectAllCourses_Click);
            // 
            // buttonSearchAtoB
            // 
            this.buttonSearchAtoB.Location = new System.Drawing.Point(386, 75);
            this.buttonSearchAtoB.Name = "buttonSearchAtoB";
            this.buttonSearchAtoB.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchAtoB.TabIndex = 3;
            this.buttonSearchAtoB.Text = "Szukaj";
            this.buttonSearchAtoB.UseVisualStyleBackColor = true;
            this.buttonSearchAtoB.Click += new System.EventHandler(this.buttonSearchAtoB_Click_1);
            // 
            // textBoxCityB
            // 
            this.textBoxCityB.Location = new System.Drawing.Point(194, 77);
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
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.groupBoxAddVisit);
            this.tabPageAdd.Controls.Add(this.groupBoxAddCourse);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(874, 381);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Dodaj";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddVisit
            // 
            this.groupBoxAddVisit.Controls.Add(this.comboBoxStations);
            this.groupBoxAddVisit.Controls.Add(this.labelDays);
            this.groupBoxAddVisit.Controls.Add(this.labelMinutest);
            this.groupBoxAddVisit.Controls.Add(this.labelHours);
            this.groupBoxAddVisit.Controls.Add(this.numericUpDownMinutes);
            this.groupBoxAddVisit.Controls.Add(this.numericUpDownHours);
            this.groupBoxAddVisit.Controls.Add(this.monthCalendar1);
            this.groupBoxAddVisit.Controls.Add(this.buttonAddVisit);
            this.groupBoxAddVisit.Controls.Add(this.comboBoxCourses);
            this.groupBoxAddVisit.Location = new System.Drawing.Point(7, 87);
            this.groupBoxAddVisit.Name = "groupBoxAddVisit";
            this.groupBoxAddVisit.Size = new System.Drawing.Size(855, 248);
            this.groupBoxAddVisit.TabIndex = 3;
            this.groupBoxAddVisit.TabStop = false;
            this.groupBoxAddVisit.Text = "Dodaj przystanek";
            // 
            // comboBoxStations
            // 
            this.comboBoxStations.FormattingEnabled = true;
            this.comboBoxStations.Location = new System.Drawing.Point(144, 35);
            this.comboBoxStations.Name = "comboBoxStations";
            this.comboBoxStations.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStations.TabIndex = 7;
            this.comboBoxStations.Text = "Wybierz stację...";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(16, 59);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(34, 13);
            this.labelDays.TabIndex = 6;
            this.labelDays.Text = "Dzień";
            // 
            // labelMinutest
            // 
            this.labelMinutest.AutoSize = true;
            this.labelMinutest.Location = new System.Drawing.Point(334, 17);
            this.labelMinutest.Name = "labelMinutest";
            this.labelMinutest.Size = new System.Drawing.Size(38, 13);
            this.labelMinutest.TabIndex = 5;
            this.labelMinutest.Text = "Minuty";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(286, 17);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(45, 13);
            this.labelHours.TabIndex = 4;
            this.labelHours.Text = "Godziny";
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(337, 36);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownMinutes.TabIndex = 3;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(289, 36);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownHours.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(16, 73);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // buttonAddVisit
            // 
            this.buttonAddVisit.Location = new System.Drawing.Point(395, 33);
            this.buttonAddVisit.Name = "buttonAddVisit";
            this.buttonAddVisit.Size = new System.Drawing.Size(100, 23);
            this.buttonAddVisit.TabIndex = 1;
            this.buttonAddVisit.Text = "Dodaj przystanek";
            this.buttonAddVisit.UseVisualStyleBackColor = true;
            this.buttonAddVisit.Click += new System.EventHandler(this.buttonAddVisit_Click);
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(17, 35);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCourses.TabIndex = 0;
            this.comboBoxCourses.Text = "Wybierz kurs...";
            this.comboBoxCourses.Click += new System.EventHandler(this.comboBoxCourses_Click);
            // 
            // groupBoxAddCourse
            // 
            this.groupBoxAddCourse.Controls.Add(this.comboBoxTrains);
            this.groupBoxAddCourse.Controls.Add(this.buttonAddCourse);
            this.groupBoxAddCourse.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAddCourse.Name = "groupBoxAddCourse";
            this.groupBoxAddCourse.Size = new System.Drawing.Size(856, 74);
            this.groupBoxAddCourse.TabIndex = 2;
            this.groupBoxAddCourse.TabStop = false;
            this.groupBoxAddCourse.Text = "Dodaj kurs";
            // 
            // comboBoxTrains
            // 
            this.comboBoxTrains.FormattingEnabled = true;
            this.comboBoxTrains.Location = new System.Drawing.Point(20, 28);
            this.comboBoxTrains.Name = "comboBoxTrains";
            this.comboBoxTrains.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrains.TabIndex = 1;
            this.comboBoxTrains.Text = "Wybierz pociąg...";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(147, 28);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(101, 23);
            this.buttonAddCourse.TabIndex = 0;
            this.buttonAddCourse.Text = "Dodaj kurs";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // tabPageOthers
            // 
            this.tabPageOthers.Controls.Add(this.groupBoxTrains);
            this.tabPageOthers.Controls.Add(this.groupBoxStations);
            this.tabPageOthers.Location = new System.Drawing.Point(4, 22);
            this.tabPageOthers.Name = "tabPageOthers";
            this.tabPageOthers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOthers.Size = new System.Drawing.Size(894, 416);
            this.tabPageOthers.TabIndex = 1;
            this.tabPageOthers.Text = "Inne";
            this.tabPageOthers.UseVisualStyleBackColor = true;
            // 
            // groupBoxTrains
            // 
            this.groupBoxTrains.Controls.Add(this.buttonDisplayAllTrains);
            this.groupBoxTrains.Controls.Add(this.buttonAddTrain);
            this.groupBoxTrains.Controls.Add(this.textBoxTrainModel);
            this.groupBoxTrains.Controls.Add(this.textBoxTrainName);
            this.groupBoxTrains.Location = new System.Drawing.Point(6, 88);
            this.groupBoxTrains.Name = "groupBoxTrains";
            this.groupBoxTrains.Size = new System.Drawing.Size(882, 83);
            this.groupBoxTrains.TabIndex = 3;
            this.groupBoxTrains.TabStop = false;
            this.groupBoxTrains.Text = "Zarządzanie pociągami";
            // 
            // buttonAddTrain
            // 
            this.buttonAddTrain.Location = new System.Drawing.Point(234, 33);
            this.buttonAddTrain.Name = "buttonAddTrain";
            this.buttonAddTrain.Size = new System.Drawing.Size(86, 23);
            this.buttonAddTrain.TabIndex = 2;
            this.buttonAddTrain.Text = "Dodaj pociąg";
            this.buttonAddTrain.UseVisualStyleBackColor = true;
            this.buttonAddTrain.Click += new System.EventHandler(this.buttonAddTrain_Click);
            // 
            // textBoxTrainModel
            // 
            this.textBoxTrainModel.Location = new System.Drawing.Point(115, 35);
            this.textBoxTrainModel.Name = "textBoxTrainModel";
            this.textBoxTrainModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrainModel.TabIndex = 1;
            this.textBoxTrainModel.Text = "Model";
            // 
            // textBoxTrainName
            // 
            this.textBoxTrainName.Location = new System.Drawing.Point(7, 35);
            this.textBoxTrainName.Name = "textBoxTrainName";
            this.textBoxTrainName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrainName.TabIndex = 0;
            this.textBoxTrainName.Text = "Nazwa pociągu";
            // 
            // groupBoxStations
            // 
            this.groupBoxStations.Controls.Add(this.buttonDisplayAllStations);
            this.groupBoxStations.Controls.Add(this.buttonAddStation);
            this.groupBoxStations.Controls.Add(this.textBoxStationName);
            this.groupBoxStations.Location = new System.Drawing.Point(6, 6);
            this.groupBoxStations.Name = "groupBoxStations";
            this.groupBoxStations.Size = new System.Drawing.Size(882, 76);
            this.groupBoxStations.TabIndex = 2;
            this.groupBoxStations.TabStop = false;
            this.groupBoxStations.Text = "Zarządzanie stacjami";
            // 
            // buttonAddStation
            // 
            this.buttonAddStation.Location = new System.Drawing.Point(140, 28);
            this.buttonAddStation.Name = "buttonAddStation";
            this.buttonAddStation.Size = new System.Drawing.Size(75, 23);
            this.buttonAddStation.TabIndex = 1;
            this.buttonAddStation.Text = "Dodaj stacje";
            this.buttonAddStation.UseVisualStyleBackColor = true;
            this.buttonAddStation.Click += new System.EventHandler(this.buttonAddStation_Click);
            // 
            // textBoxStationName
            // 
            this.textBoxStationName.Location = new System.Drawing.Point(7, 30);
            this.textBoxStationName.Name = "textBoxStationName";
            this.textBoxStationName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStationName.TabIndex = 0;
            this.textBoxStationName.Text = "Nazwa stacji";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(30, 12);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewCourses.Size = new System.Drawing.Size(862, 300);
            this.dataGridViewCourses.TabIndex = 1;
            // 
            // buttonDisplayAllStations
            // 
            this.buttonDisplayAllStations.Location = new System.Drawing.Point(234, 28);
            this.buttonDisplayAllStations.Name = "buttonDisplayAllStations";
            this.buttonDisplayAllStations.Size = new System.Drawing.Size(147, 23);
            this.buttonDisplayAllStations.TabIndex = 2;
            this.buttonDisplayAllStations.Text = "Wyświetl wszystkie stacje";
            this.buttonDisplayAllStations.UseVisualStyleBackColor = true;
            this.buttonDisplayAllStations.Click += new System.EventHandler(this.buttonDisplayAllStations_Click);
            // 
            // buttonDisplayAllTrains
            // 
            this.buttonDisplayAllTrains.Location = new System.Drawing.Point(341, 33);
            this.buttonDisplayAllTrains.Name = "buttonDisplayAllTrains";
            this.buttonDisplayAllTrains.Size = new System.Drawing.Size(147, 23);
            this.buttonDisplayAllTrains.TabIndex = 3;
            this.buttonDisplayAllTrains.Text = "Wyświetl wszystkie pociągi";
            this.buttonDisplayAllTrains.UseVisualStyleBackColor = true;
            this.buttonDisplayAllTrains.Click += new System.EventHandler(this.buttonDisplayAllTrains_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 776);
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.dataGridViewCourses);
            this.Name = "AdminForm";
            this.Text = "Administrator";
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageCourses.ResumeLayout(false);
            this.tabControlCourses.ResumeLayout(false);
            this.tabPageManage.ResumeLayout(false);
            this.groupBoxManageCourses.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageAdd.ResumeLayout(false);
            this.groupBoxAddVisit.ResumeLayout(false);
            this.groupBoxAddVisit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.groupBoxAddCourse.ResumeLayout(false);
            this.tabPageOthers.ResumeLayout(false);
            this.groupBoxTrains.ResumeLayout(false);
            this.groupBoxTrains.PerformLayout();
            this.groupBoxStations.ResumeLayout(false);
            this.groupBoxStations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPageCourses;
        private System.Windows.Forms.TabPage tabPageOthers;
        private System.Windows.Forms.TabControl tabControlCourses;
        private System.Windows.Forms.TabPage tabPageManage;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearchAtoB;
        private System.Windows.Forms.TextBox textBoxCityB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCityA;
        private System.Windows.Forms.GroupBox groupBoxManageCourses;
        private System.Windows.Forms.Button buttonDeleteCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonShowCourseVisits;
        private System.Windows.Forms.TextBox textBoxCourseVisits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSelectAllCourses;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.GroupBox groupBoxAddCourse;
        private System.Windows.Forms.ComboBox comboBoxTrains;
        private System.Windows.Forms.GroupBox groupBoxAddVisit;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Button buttonAddVisit;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelMinutest;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBoxStations;
        private System.Windows.Forms.GroupBox groupBoxStations;
        private System.Windows.Forms.Button buttonAddStation;
        private System.Windows.Forms.TextBox textBoxStationName;
        private System.Windows.Forms.GroupBox groupBoxTrains;
        private System.Windows.Forms.Button buttonAddTrain;
        private System.Windows.Forms.TextBox textBoxTrainModel;
        private System.Windows.Forms.TextBox textBoxTrainName;
        private System.Windows.Forms.Button buttonDisplayAllTrains;
        private System.Windows.Forms.Button buttonDisplayAllStations;
    }
}