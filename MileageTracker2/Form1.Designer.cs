namespace MileageTracker2
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.totalMileageTab1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addDistanceButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mileCounter = new System.Windows.Forms.NumericUpDown();
            this.enableStartButton = new System.Windows.Forms.Button();
            this.addTripButton = new System.Windows.Forms.Button();
            this.destination = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tripDateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tripTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.locationAddress = new System.Windows.Forms.TextBox();
            this.addLocationButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.locationName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.expensesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.expenseAmount = new System.Windows.Forms.NumericUpDown();
            this.addExpenseButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.expenseType = new System.Windows.Forms.ComboBox();
            this.expenseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mileageRate = new System.Windows.Forms.NumericUpDown();
            this.profitTB = new System.Windows.Forms.TextBox();
            this.gasMaintTB = new System.Windows.Forms.TextBox();
            this.dollarAmountTB = new System.Windows.Forms.TextBox();
            this.totalMileageTab2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExpenseReport = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.newExpenseReportBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mileCounter)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseAmount)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mileageRate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(42, 18);
            this.tabControl1.Location = new System.Drawing.Point(12, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 382);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.totalMileageTab1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tripTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trips";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // totalMileageTab1
            // 
            this.totalMileageTab1.Enabled = false;
            this.totalMileageTab1.Location = new System.Drawing.Point(255, 327);
            this.totalMileageTab1.Name = "totalMileageTab1";
            this.totalMileageTab1.Size = new System.Drawing.Size(100, 20);
            this.totalMileageTab1.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total Mileage";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addDistanceButton);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.mileCounter);
            this.groupBox3.Controls.Add(this.enableStartButton);
            this.groupBox3.Controls.Add(this.addTripButton);
            this.groupBox3.Controls.Add(this.destination);
            this.groupBox3.Controls.Add(this.start);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tripDateTime);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 299);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Trip";
            // 
            // addDistanceButton
            // 
            this.addDistanceButton.Enabled = false;
            this.addDistanceButton.Location = new System.Drawing.Point(18, 234);
            this.addDistanceButton.Name = "addDistanceButton";
            this.addDistanceButton.Size = new System.Drawing.Size(203, 23);
            this.addDistanceButton.TabIndex = 25;
            this.addDistanceButton.Text = "Add Distance Between Locations";
            this.addDistanceButton.UseVisualStyleBackColor = true;
            this.addDistanceButton.Click += new System.EventHandler(this.addDistanceButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Miles";
            // 
            // mileCounter
            // 
            this.mileCounter.Enabled = false;
            this.mileCounter.Location = new System.Drawing.Point(18, 208);
            this.mileCounter.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.mileCounter.Name = "mileCounter";
            this.mileCounter.Size = new System.Drawing.Size(67, 20);
            this.mileCounter.TabIndex = 23;
            // 
            // enableStartButton
            // 
            this.enableStartButton.Enabled = false;
            this.enableStartButton.Location = new System.Drawing.Point(18, 116);
            this.enableStartButton.Name = "enableStartButton";
            this.enableStartButton.Size = new System.Drawing.Size(170, 23);
            this.enableStartButton.TabIndex = 22;
            this.enableStartButton.Text = "push to add new start location";
            this.enableStartButton.UseVisualStyleBackColor = true;
            this.enableStartButton.Click += new System.EventHandler(this.enableStartButton_Click);
            // 
            // addTripButton
            // 
            this.addTripButton.Enabled = false;
            this.addTripButton.Location = new System.Drawing.Point(18, 263);
            this.addTripButton.Name = "addTripButton";
            this.addTripButton.Size = new System.Drawing.Size(203, 23);
            this.addTripButton.TabIndex = 16;
            this.addTripButton.Text = "Add Trip to Expense Report";
            this.addTripButton.UseVisualStyleBackColor = true;
            this.addTripButton.Click += new System.EventHandler(this.addTripButton_Click);
            // 
            // destination
            // 
            this.destination.FormattingEnabled = true;
            this.destination.Location = new System.Drawing.Point(18, 158);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(170, 21);
            this.destination.Sorted = true;
            this.destination.TabIndex = 21;
            this.destination.SelectedIndexChanged += new System.EventHandler(this.toDropMenu_SelectedIndexChanged);
            // 
            // start
            // 
            this.start.FormattingEnabled = true;
            this.start.Location = new System.Drawing.Point(18, 89);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(170, 21);
            this.start.Sorted = true;
            this.start.TabIndex = 20;
            this.start.SelectedIndexChanged += new System.EventHandler(this.fromDropMenu_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "End Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Start Location";
            // 
            // tripDateTime
            // 
            this.tripDateTime.Location = new System.Drawing.Point(18, 44);
            this.tripDateTime.Name = "tripDateTime";
            this.tripDateTime.Size = new System.Drawing.Size(203, 20);
            this.tripDateTime.TabIndex = 17;
            this.tripDateTime.ValueChanged += new System.EventHandler(this.tripsDateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Trip Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Trips";
            // 
            // tripTextBox
            // 
            this.tripTextBox.Location = new System.Drawing.Point(255, 15);
            this.tripTextBox.Multiline = true;
            this.tripTextBox.Name = "tripTextBox";
            this.tripTextBox.Size = new System.Drawing.Size(222, 293);
            this.tripTextBox.TabIndex = 27;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Addresses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(484, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Locations";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.locationAddress);
            this.groupBox1.Controls.Add(this.addLocationButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.locationName);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 148);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(234, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 208);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Location Address";
            // 
            // locationAddress
            // 
            this.locationAddress.Location = new System.Drawing.Point(18, 85);
            this.locationAddress.Name = "locationAddress";
            this.locationAddress.Size = new System.Drawing.Size(203, 20);
            this.locationAddress.TabIndex = 25;
            this.locationAddress.TextChanged += new System.EventHandler(this.locationAddress_TextChanged);
            // 
            // addLocationButton
            // 
            this.addLocationButton.Enabled = false;
            this.addLocationButton.Location = new System.Drawing.Point(18, 111);
            this.addLocationButton.Name = "addLocationButton";
            this.addLocationButton.Size = new System.Drawing.Size(203, 23);
            this.addLocationButton.TabIndex = 24;
            this.addLocationButton.Text = "Add Location";
            this.addLocationButton.UseVisualStyleBackColor = true;
            this.addLocationButton.Click += new System.EventHandler(this.addLocationButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Location Name";
            // 
            // locationName
            // 
            this.locationName.Location = new System.Drawing.Point(18, 35);
            this.locationName.Name = "locationName";
            this.locationName.Size = new System.Drawing.Size(203, 20);
            this.locationName.TabIndex = 22;
            this.locationName.TextChanged += new System.EventHandler(this.locationName_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.expensesTextBox);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(484, 356);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Expenses";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Expenses";
            // 
            // expensesTextBox
            // 
            this.expensesTextBox.Enabled = false;
            this.expensesTextBox.Location = new System.Drawing.Point(6, 95);
            this.expensesTextBox.Multiline = true;
            this.expensesTextBox.Name = "expensesTextBox";
            this.expensesTextBox.Size = new System.Drawing.Size(472, 140);
            this.expensesTextBox.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.expenseAmount);
            this.groupBox5.Controls.Add(this.addExpenseButton);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.expenseType);
            this.groupBox5.Controls.Add(this.expenseDateTimePicker);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(472, 68);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Expense";
            // 
            // expenseAmount
            // 
            this.expenseAmount.DecimalPlaces = 2;
            this.expenseAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.expenseAmount.Location = new System.Drawing.Point(298, 32);
            this.expenseAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.expenseAmount.Name = "expenseAmount";
            this.expenseAmount.Size = new System.Drawing.Size(72, 20);
            this.expenseAmount.TabIndex = 14;
            this.expenseAmount.ThousandsSeparator = true;
            this.expenseAmount.ValueChanged += new System.EventHandler(this.expenseAmount_ValueChanged);
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Location = new System.Drawing.Point(373, 30);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(75, 23);
            this.addExpenseButton.TabIndex = 13;
            this.addExpenseButton.Text = "Add";
            this.addExpenseButton.UseVisualStyleBackColor = true;
            this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "$ Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Expense Type";
            // 
            // expenseType
            // 
            this.expenseType.FormattingEnabled = true;
            this.expenseType.Items.AddRange(new object[] {
            "Gasoline",
            "Oil",
            "Parts",
            "Service",
            "Other"});
            this.expenseType.Location = new System.Drawing.Point(212, 32);
            this.expenseType.Name = "expenseType";
            this.expenseType.Size = new System.Drawing.Size(80, 21);
            this.expenseType.TabIndex = 8;
            // 
            // expenseDateTimePicker
            // 
            this.expenseDateTimePicker.Location = new System.Drawing.Point(6, 33);
            this.expenseDateTimePicker.Name = "expenseDateTimePicker";
            this.expenseDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.expenseDateTimePicker.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mileageRate);
            this.groupBox4.Controls.Add(this.profitTB);
            this.groupBox4.Controls.Add(this.gasMaintTB);
            this.groupBox4.Controls.Add(this.dollarAmountTB);
            this.groupBox4.Controls.Add(this.totalMileageTab2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(8, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Expense Report";
            // 
            // mileageRate
            // 
            this.mileageRate.DecimalPlaces = 2;
            this.mileageRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.mileageRate.Location = new System.Drawing.Point(114, 48);
            this.mileageRate.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            131072});
            this.mileageRate.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.mileageRate.Name = "mileageRate";
            this.mileageRate.Size = new System.Drawing.Size(47, 20);
            this.mileageRate.TabIndex = 13;
            this.mileageRate.Value = new decimal(new int[] {
            58,
            0,
            0,
            131072});
            // 
            // profitTB
            // 
            this.profitTB.Enabled = false;
            this.profitTB.Location = new System.Drawing.Point(284, 48);
            this.profitTB.Name = "profitTB";
            this.profitTB.Size = new System.Drawing.Size(59, 20);
            this.profitTB.TabIndex = 12;
            // 
            // gasMaintTB
            // 
            this.gasMaintTB.Enabled = false;
            this.gasMaintTB.Location = new System.Drawing.Point(232, 48);
            this.gasMaintTB.Name = "gasMaintTB";
            this.gasMaintTB.Size = new System.Drawing.Size(46, 20);
            this.gasMaintTB.TabIndex = 11;
            // 
            // dollarAmountTB
            // 
            this.dollarAmountTB.Enabled = false;
            this.dollarAmountTB.Location = new System.Drawing.Point(167, 48);
            this.dollarAmountTB.Name = "dollarAmountTB";
            this.dollarAmountTB.Size = new System.Drawing.Size(59, 20);
            this.dollarAmountTB.TabIndex = 10;
            // 
            // totalMileageTab2
            // 
            this.totalMileageTab2.Enabled = false;
            this.totalMileageTab2.Location = new System.Drawing.Point(49, 48);
            this.totalMileageTab2.Name = "totalMileageTab2";
            this.totalMileageTab2.Size = new System.Drawing.Size(59, 20);
            this.totalMileageTab2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "mileage x mileage rate = dollar amount - expenses = profit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExpenseReport});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openExpenseReport
            // 
            this.openExpenseReport.Name = "openExpenseReport";
            this.openExpenseReport.Size = new System.Drawing.Size(154, 22);
            this.openExpenseReport.Text = "Expense Report";
            this.openExpenseReport.Click += new System.EventHandler(this.openExpenseReport_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stateToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.stateToolStripMenuItem.Text = "State";
            this.stateToolStripMenuItem.Click += new System.EventHandler(this.newStateToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.InitialDirectory = "C:\\Users\\pena\'s pc\\Documents\\Mileage Tracker Locations\\States";
            this.saveFileDialog1.Title = "Create A New State";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "C:\\Users\\pena\'s pc\\Documents\\Mileage Tracker Locations\\States";
            this.openFileDialog1.Title = "choose a state";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.InitialDirectory = "C:\\Users\\pena\'s pc\\Documents\\Mileage Tracker Locations\\Expense Reports";
            this.openFileDialog2.Title = "Choose an Expense Report";
            // 
            // newExpenseReportBtn
            // 
            this.newExpenseReportBtn.Location = new System.Drawing.Point(173, 40);
            this.newExpenseReportBtn.Name = "newExpenseReportBtn";
            this.newExpenseReportBtn.Size = new System.Drawing.Size(157, 35);
            this.newExpenseReportBtn.TabIndex = 34;
            this.newExpenseReportBtn.Text = "Start a New Expense Report";
            this.newExpenseReportBtn.UseVisualStyleBackColor = true;
            this.newExpenseReportBtn.Click += new System.EventHandler(this.newExpenseReportBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 477);
            this.Controls.Add(this.newExpenseReportBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Mileage Tracker";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mileCounter)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseAmount)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mileageRate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox totalMileageTab1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addDistanceButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown mileCounter;
        private System.Windows.Forms.Button enableStartButton;
        private System.Windows.Forms.Button addTripButton;
        private System.Windows.Forms.ComboBox destination;
        private System.Windows.Forms.ComboBox start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tripDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tripTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox locationAddress;
        private System.Windows.Forms.Button addLocationButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox locationName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openExpenseReport;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown mileageRate;
        private System.Windows.Forms.TextBox profitTB;
        private System.Windows.Forms.TextBox gasMaintTB;
        private System.Windows.Forms.TextBox dollarAmountTB;
        private System.Windows.Forms.TextBox totalMileageTab2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox expensesTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button addExpenseButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox expenseType;
        private System.Windows.Forms.DateTimePicker expenseDateTimePicker;
        private System.Windows.Forms.NumericUpDown expenseAmount;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button newExpenseReportBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

