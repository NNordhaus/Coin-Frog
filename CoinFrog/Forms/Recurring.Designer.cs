namespace CoinFrog
{
    partial class Recurring
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.cmboRepeat = new System.Windows.Forms.ComboBox();
            this.pnlWeeks = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSunday = new System.Windows.Forms.CheckBox();
            this.cbSaturday = new System.Windows.Forms.CheckBox();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.cbTuesday = new System.Windows.Forms.CheckBox();
            this.cbMonday = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flpMonths = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.checkBox63 = new System.Windows.Forms.CheckBox();
            this.checkBox62 = new System.Windows.Forms.CheckBox();
            this.checkBox61 = new System.Windows.Forms.CheckBox();
            this.checkBox60 = new System.Windows.Forms.CheckBox();
            this.checkBox59 = new System.Windows.Forms.CheckBox();
            this.checkBox58 = new System.Windows.Forms.CheckBox();
            this.checkBox57 = new System.Windows.Forms.CheckBox();
            this.checkBox56 = new System.Windows.Forms.CheckBox();
            this.checkBox55 = new System.Windows.Forms.CheckBox();
            this.checkBox54 = new System.Windows.Forms.CheckBox();
            this.checkBox53 = new System.Windows.Forms.CheckBox();
            this.checkBox52 = new System.Windows.Forms.CheckBox();
            this.checkBox51 = new System.Windows.Forms.CheckBox();
            this.checkBox50 = new System.Windows.Forms.CheckBox();
            this.checkBox49 = new System.Windows.Forms.CheckBox();
            this.checkBox48 = new System.Windows.Forms.CheckBox();
            this.checkBox47 = new System.Windows.Forms.CheckBox();
            this.checkBox46 = new System.Windows.Forms.CheckBox();
            this.checkBox45 = new System.Windows.Forms.CheckBox();
            this.checkBox44 = new System.Windows.Forms.CheckBox();
            this.checkBox43 = new System.Windows.Forms.CheckBox();
            this.checkBox42 = new System.Windows.Forms.CheckBox();
            this.checkBox41 = new System.Windows.Forms.CheckBox();
            this.checkBox40 = new System.Windows.Forms.CheckBox();
            this.checkBox39 = new System.Windows.Forms.CheckBox();
            this.checkBox38 = new System.Windows.Forms.CheckBox();
            this.checkBox37 = new System.Windows.Forms.CheckBox();
            this.checkBox36 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.txtBaseAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlYears = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpUntil = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTransName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            this.pnlWeeks.SuspendLayout();
            this.flpMonths.SuspendLayout();
            this.pnlAmount.SuspendLayout();
            this.flpMain.SuspendLayout();
            this.pnlYears.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repeat every";
            // 
            // nudNum
            // 
            this.nudNum.Location = new System.Drawing.Point(89, 71);
            this.nudNum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(64, 20);
            this.nudNum.TabIndex = 2;
            this.nudNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNum.ThousandsSeparator = true;
            this.nudNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmboRepeat
            // 
            this.cmboRepeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboRepeat.FormattingEnabled = true;
            this.cmboRepeat.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cmboRepeat.Location = new System.Drawing.Point(159, 70);
            this.cmboRepeat.Name = "cmboRepeat";
            this.cmboRepeat.Size = new System.Drawing.Size(121, 21);
            this.cmboRepeat.TabIndex = 3;
            this.cmboRepeat.SelectedIndexChanged += new System.EventHandler(this.cmboRepeat_SelectedIndexChanged);
            // 
            // pnlWeeks
            // 
            this.pnlWeeks.Controls.Add(this.label2);
            this.pnlWeeks.Controls.Add(this.cbSunday);
            this.pnlWeeks.Controls.Add(this.cbSaturday);
            this.pnlWeeks.Controls.Add(this.cbFriday);
            this.pnlWeeks.Controls.Add(this.cbThursday);
            this.pnlWeeks.Controls.Add(this.cbWednesday);
            this.pnlWeeks.Controls.Add(this.cbTuesday);
            this.pnlWeeks.Controls.Add(this.cbMonday);
            this.pnlWeeks.Location = new System.Drawing.Point(3, 3);
            this.pnlWeeks.Name = "pnlWeeks";
            this.pnlWeeks.Size = new System.Drawing.Size(540, 23);
            this.pnlWeeks.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "On";
            // 
            // cbSunday
            // 
            this.cbSunday.AutoSize = true;
            this.cbSunday.Location = new System.Drawing.Point(35, 3);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(62, 17);
            this.cbSunday.TabIndex = 6;
            this.cbSunday.Text = "Sunday";
            this.cbSunday.UseVisualStyleBackColor = true;
            // 
            // cbSaturday
            // 
            this.cbSaturday.AutoSize = true;
            this.cbSaturday.Location = new System.Drawing.Point(471, 3);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(68, 17);
            this.cbSaturday.TabIndex = 12;
            this.cbSaturday.Text = "Saturday";
            this.cbSaturday.UseVisualStyleBackColor = true;
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.Location = new System.Drawing.Point(411, 3);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(54, 17);
            this.cbFriday.TabIndex = 11;
            this.cbFriday.Text = "Friday";
            this.cbFriday.UseVisualStyleBackColor = true;
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.Location = new System.Drawing.Point(335, 3);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(70, 17);
            this.cbThursday.TabIndex = 10;
            this.cbThursday.Text = "Thursday";
            this.cbThursday.UseVisualStyleBackColor = true;
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.Location = new System.Drawing.Point(246, 3);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(83, 17);
            this.cbWednesday.TabIndex = 9;
            this.cbWednesday.Text = "Wednesday";
            this.cbWednesday.UseVisualStyleBackColor = true;
            // 
            // cbTuesday
            // 
            this.cbTuesday.AutoSize = true;
            this.cbTuesday.Location = new System.Drawing.Point(173, 3);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(67, 17);
            this.cbTuesday.TabIndex = 8;
            this.cbTuesday.Text = "Tuesday";
            this.cbTuesday.UseVisualStyleBackColor = true;
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.Location = new System.Drawing.Point(103, 3);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(64, 17);
            this.cbMonday.TabIndex = 7;
            this.cbMonday.Text = "Monday";
            this.cbMonday.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(177, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 20);
            this.txtName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Recurrence Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(446, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(527, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flpMonths
            // 
            this.flpMonths.Controls.Add(this.label3);
            this.flpMonths.Controls.Add(this.cb1);
            this.flpMonths.Controls.Add(this.checkBox63);
            this.flpMonths.Controls.Add(this.checkBox62);
            this.flpMonths.Controls.Add(this.checkBox61);
            this.flpMonths.Controls.Add(this.checkBox60);
            this.flpMonths.Controls.Add(this.checkBox59);
            this.flpMonths.Controls.Add(this.checkBox58);
            this.flpMonths.Controls.Add(this.checkBox57);
            this.flpMonths.Controls.Add(this.checkBox56);
            this.flpMonths.Controls.Add(this.checkBox55);
            this.flpMonths.Controls.Add(this.checkBox54);
            this.flpMonths.Controls.Add(this.checkBox53);
            this.flpMonths.Controls.Add(this.checkBox52);
            this.flpMonths.Controls.Add(this.checkBox51);
            this.flpMonths.Controls.Add(this.checkBox50);
            this.flpMonths.Controls.Add(this.checkBox49);
            this.flpMonths.Controls.Add(this.checkBox48);
            this.flpMonths.Controls.Add(this.checkBox47);
            this.flpMonths.Controls.Add(this.checkBox46);
            this.flpMonths.Controls.Add(this.checkBox45);
            this.flpMonths.Controls.Add(this.checkBox44);
            this.flpMonths.Controls.Add(this.checkBox43);
            this.flpMonths.Controls.Add(this.checkBox42);
            this.flpMonths.Controls.Add(this.checkBox41);
            this.flpMonths.Controls.Add(this.checkBox40);
            this.flpMonths.Controls.Add(this.checkBox39);
            this.flpMonths.Controls.Add(this.checkBox38);
            this.flpMonths.Controls.Add(this.checkBox37);
            this.flpMonths.Controls.Add(this.checkBox36);
            this.flpMonths.Controls.Add(this.checkBox23);
            this.flpMonths.Controls.Add(this.checkBox22);
            this.flpMonths.Controls.Add(this.checkBox21);
            this.flpMonths.Location = new System.Drawing.Point(3, 32);
            this.flpMonths.Name = "flpMonths";
            this.flpMonths.Size = new System.Drawing.Size(539, 121);
            this.flpMonths.TabIndex = 12;
            // 
            // label3
            // 
            this.flpMonths.SetFlowBreak(this.label3, true);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "On";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(15, 26);
            this.cb1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.cb1.Name = "cb1";
            this.cb1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.cb1.Size = new System.Drawing.Size(38, 17);
            this.cb1.TabIndex = 13;
            this.cb1.Text = "1";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // checkBox63
            // 
            this.checkBox63.AutoSize = true;
            this.checkBox63.Location = new System.Drawing.Point(71, 26);
            this.checkBox63.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox63.Name = "checkBox63";
            this.checkBox63.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.checkBox63.Size = new System.Drawing.Size(38, 17);
            this.checkBox63.TabIndex = 14;
            this.checkBox63.Text = "2";
            this.checkBox63.UseVisualStyleBackColor = true;
            // 
            // checkBox62
            // 
            this.checkBox62.AutoSize = true;
            this.checkBox62.Location = new System.Drawing.Point(127, 26);
            this.checkBox62.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox62.Name = "checkBox62";
            this.checkBox62.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.checkBox62.Size = new System.Drawing.Size(38, 17);
            this.checkBox62.TabIndex = 15;
            this.checkBox62.Text = "3";
            this.checkBox62.UseVisualStyleBackColor = true;
            // 
            // checkBox61
            // 
            this.checkBox61.AutoSize = true;
            this.checkBox61.Location = new System.Drawing.Point(183, 26);
            this.checkBox61.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox61.Name = "checkBox61";
            this.checkBox61.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.checkBox61.Size = new System.Drawing.Size(38, 17);
            this.checkBox61.TabIndex = 16;
            this.checkBox61.Text = "4";
            this.checkBox61.UseVisualStyleBackColor = true;
            // 
            // checkBox60
            // 
            this.checkBox60.AutoSize = true;
            this.checkBox60.Location = new System.Drawing.Point(239, 26);
            this.checkBox60.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox60.Name = "checkBox60";
            this.checkBox60.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.checkBox60.Size = new System.Drawing.Size(38, 17);
            this.checkBox60.TabIndex = 17;
            this.checkBox60.Text = "5";
            this.checkBox60.UseVisualStyleBackColor = true;
            // 
            // checkBox59
            // 
            this.checkBox59.AutoSize = true;
            this.checkBox59.Location = new System.Drawing.Point(295, 26);
            this.checkBox59.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox59.Name = "checkBox59";
            this.checkBox59.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.checkBox59.Size = new System.Drawing.Size(38, 17);
            this.checkBox59.TabIndex = 43;
            this.checkBox59.Text = "6";
            this.checkBox59.UseVisualStyleBackColor = true;
            // 
            // checkBox58
            // 
            this.checkBox58.AutoSize = true;
            this.checkBox58.Location = new System.Drawing.Point(351, 26);
            this.checkBox58.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox58.Name = "checkBox58";
            this.checkBox58.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.checkBox58.Size = new System.Drawing.Size(38, 17);
            this.checkBox58.TabIndex = 44;
            this.checkBox58.Text = "7";
            this.checkBox58.UseVisualStyleBackColor = true;
            // 
            // checkBox57
            // 
            this.checkBox57.AutoSize = true;
            this.checkBox57.Location = new System.Drawing.Point(407, 26);
            this.checkBox57.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox57.Name = "checkBox57";
            this.checkBox57.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.checkBox57.Size = new System.Drawing.Size(38, 17);
            this.checkBox57.TabIndex = 45;
            this.checkBox57.Text = "8";
            this.checkBox57.UseVisualStyleBackColor = true;
            // 
            // checkBox56
            // 
            this.checkBox56.AutoSize = true;
            this.checkBox56.Location = new System.Drawing.Point(463, 26);
            this.checkBox56.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox56.Name = "checkBox56";
            this.checkBox56.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.checkBox56.Size = new System.Drawing.Size(38, 17);
            this.checkBox56.TabIndex = 46;
            this.checkBox56.Text = "9";
            this.checkBox56.UseVisualStyleBackColor = true;
            // 
            // checkBox55
            // 
            this.checkBox55.AutoSize = true;
            this.checkBox55.Location = new System.Drawing.Point(15, 49);
            this.checkBox55.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox55.Name = "checkBox55";
            this.checkBox55.Size = new System.Drawing.Size(38, 17);
            this.checkBox55.TabIndex = 47;
            this.checkBox55.Text = "10";
            this.checkBox55.UseVisualStyleBackColor = true;
            // 
            // checkBox54
            // 
            this.checkBox54.AutoSize = true;
            this.checkBox54.Location = new System.Drawing.Point(71, 49);
            this.checkBox54.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox54.Name = "checkBox54";
            this.checkBox54.Size = new System.Drawing.Size(38, 17);
            this.checkBox54.TabIndex = 48;
            this.checkBox54.Text = "11";
            this.checkBox54.UseVisualStyleBackColor = true;
            // 
            // checkBox53
            // 
            this.checkBox53.AutoSize = true;
            this.checkBox53.Location = new System.Drawing.Point(127, 49);
            this.checkBox53.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox53.Name = "checkBox53";
            this.checkBox53.Size = new System.Drawing.Size(38, 17);
            this.checkBox53.TabIndex = 49;
            this.checkBox53.Text = "12";
            this.checkBox53.UseVisualStyleBackColor = true;
            // 
            // checkBox52
            // 
            this.checkBox52.AutoSize = true;
            this.checkBox52.Location = new System.Drawing.Point(183, 49);
            this.checkBox52.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox52.Name = "checkBox52";
            this.checkBox52.Size = new System.Drawing.Size(38, 17);
            this.checkBox52.TabIndex = 50;
            this.checkBox52.Text = "13";
            this.checkBox52.UseVisualStyleBackColor = true;
            // 
            // checkBox51
            // 
            this.checkBox51.AutoSize = true;
            this.checkBox51.Location = new System.Drawing.Point(239, 49);
            this.checkBox51.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox51.Name = "checkBox51";
            this.checkBox51.Size = new System.Drawing.Size(38, 17);
            this.checkBox51.TabIndex = 51;
            this.checkBox51.Text = "14";
            this.checkBox51.UseVisualStyleBackColor = true;
            // 
            // checkBox50
            // 
            this.checkBox50.AutoSize = true;
            this.checkBox50.Location = new System.Drawing.Point(295, 49);
            this.checkBox50.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox50.Name = "checkBox50";
            this.checkBox50.Size = new System.Drawing.Size(38, 17);
            this.checkBox50.TabIndex = 52;
            this.checkBox50.Text = "15";
            this.checkBox50.UseVisualStyleBackColor = true;
            // 
            // checkBox49
            // 
            this.checkBox49.AutoSize = true;
            this.checkBox49.Location = new System.Drawing.Point(351, 49);
            this.checkBox49.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox49.Name = "checkBox49";
            this.checkBox49.Size = new System.Drawing.Size(38, 17);
            this.checkBox49.TabIndex = 53;
            this.checkBox49.Text = "16";
            this.checkBox49.UseVisualStyleBackColor = true;
            // 
            // checkBox48
            // 
            this.checkBox48.AutoSize = true;
            this.checkBox48.Location = new System.Drawing.Point(407, 49);
            this.checkBox48.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox48.Name = "checkBox48";
            this.checkBox48.Size = new System.Drawing.Size(38, 17);
            this.checkBox48.TabIndex = 54;
            this.checkBox48.Text = "17";
            this.checkBox48.UseVisualStyleBackColor = true;
            // 
            // checkBox47
            // 
            this.checkBox47.AutoSize = true;
            this.checkBox47.Location = new System.Drawing.Point(463, 49);
            this.checkBox47.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox47.Name = "checkBox47";
            this.checkBox47.Size = new System.Drawing.Size(38, 17);
            this.checkBox47.TabIndex = 55;
            this.checkBox47.Text = "18";
            this.checkBox47.UseVisualStyleBackColor = true;
            // 
            // checkBox46
            // 
            this.checkBox46.AutoSize = true;
            this.checkBox46.Location = new System.Drawing.Point(15, 72);
            this.checkBox46.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox46.Name = "checkBox46";
            this.checkBox46.Size = new System.Drawing.Size(38, 17);
            this.checkBox46.TabIndex = 56;
            this.checkBox46.Text = "19";
            this.checkBox46.UseVisualStyleBackColor = true;
            // 
            // checkBox45
            // 
            this.checkBox45.AutoSize = true;
            this.checkBox45.Location = new System.Drawing.Point(71, 72);
            this.checkBox45.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox45.Name = "checkBox45";
            this.checkBox45.Size = new System.Drawing.Size(38, 17);
            this.checkBox45.TabIndex = 57;
            this.checkBox45.Text = "20";
            this.checkBox45.UseVisualStyleBackColor = true;
            // 
            // checkBox44
            // 
            this.checkBox44.AutoSize = true;
            this.checkBox44.Location = new System.Drawing.Point(127, 72);
            this.checkBox44.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox44.Name = "checkBox44";
            this.checkBox44.Size = new System.Drawing.Size(38, 17);
            this.checkBox44.TabIndex = 58;
            this.checkBox44.Text = "21";
            this.checkBox44.UseVisualStyleBackColor = true;
            // 
            // checkBox43
            // 
            this.checkBox43.AutoSize = true;
            this.checkBox43.Location = new System.Drawing.Point(183, 72);
            this.checkBox43.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox43.Name = "checkBox43";
            this.checkBox43.Size = new System.Drawing.Size(38, 17);
            this.checkBox43.TabIndex = 59;
            this.checkBox43.Text = "22";
            this.checkBox43.UseVisualStyleBackColor = true;
            // 
            // checkBox42
            // 
            this.checkBox42.AutoSize = true;
            this.checkBox42.Location = new System.Drawing.Point(239, 72);
            this.checkBox42.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox42.Name = "checkBox42";
            this.checkBox42.Size = new System.Drawing.Size(38, 17);
            this.checkBox42.TabIndex = 60;
            this.checkBox42.Text = "23";
            this.checkBox42.UseVisualStyleBackColor = true;
            // 
            // checkBox41
            // 
            this.checkBox41.AutoSize = true;
            this.checkBox41.Location = new System.Drawing.Point(295, 72);
            this.checkBox41.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox41.Name = "checkBox41";
            this.checkBox41.Size = new System.Drawing.Size(38, 17);
            this.checkBox41.TabIndex = 61;
            this.checkBox41.Text = "24";
            this.checkBox41.UseVisualStyleBackColor = true;
            // 
            // checkBox40
            // 
            this.checkBox40.AutoSize = true;
            this.checkBox40.Location = new System.Drawing.Point(351, 72);
            this.checkBox40.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox40.Name = "checkBox40";
            this.checkBox40.Size = new System.Drawing.Size(38, 17);
            this.checkBox40.TabIndex = 62;
            this.checkBox40.Text = "25";
            this.checkBox40.UseVisualStyleBackColor = true;
            // 
            // checkBox39
            // 
            this.checkBox39.AutoSize = true;
            this.checkBox39.Location = new System.Drawing.Point(407, 72);
            this.checkBox39.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox39.Name = "checkBox39";
            this.checkBox39.Size = new System.Drawing.Size(38, 17);
            this.checkBox39.TabIndex = 63;
            this.checkBox39.Text = "26";
            this.checkBox39.UseVisualStyleBackColor = true;
            // 
            // checkBox38
            // 
            this.checkBox38.AutoSize = true;
            this.checkBox38.Location = new System.Drawing.Point(463, 72);
            this.checkBox38.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox38.Name = "checkBox38";
            this.checkBox38.Size = new System.Drawing.Size(38, 17);
            this.checkBox38.TabIndex = 64;
            this.checkBox38.Text = "27";
            this.checkBox38.UseVisualStyleBackColor = true;
            // 
            // checkBox37
            // 
            this.checkBox37.AutoSize = true;
            this.checkBox37.Location = new System.Drawing.Point(15, 95);
            this.checkBox37.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox37.Name = "checkBox37";
            this.checkBox37.Size = new System.Drawing.Size(38, 17);
            this.checkBox37.TabIndex = 65;
            this.checkBox37.Text = "28";
            this.checkBox37.UseVisualStyleBackColor = true;
            // 
            // checkBox36
            // 
            this.checkBox36.AutoSize = true;
            this.checkBox36.Enabled = false;
            this.checkBox36.Location = new System.Drawing.Point(71, 95);
            this.checkBox36.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox36.Name = "checkBox36";
            this.checkBox36.Size = new System.Drawing.Size(38, 17);
            this.checkBox36.TabIndex = 66;
            this.checkBox36.Text = "29";
            this.checkBox36.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Enabled = false;
            this.checkBox23.Location = new System.Drawing.Point(127, 95);
            this.checkBox23.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(38, 17);
            this.checkBox23.TabIndex = 67;
            this.checkBox23.Text = "30";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Enabled = false;
            this.checkBox22.Location = new System.Drawing.Point(183, 95);
            this.checkBox22.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(38, 17);
            this.checkBox22.TabIndex = 43;
            this.checkBox22.Text = "31";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Enabled = false;
            this.checkBox21.Location = new System.Drawing.Point(239, 95);
            this.checkBox21.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(68, 17);
            this.checkBox21.TabIndex = 44;
            this.checkBox21.Text = "Last Day";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // pnlAmount
            // 
            this.pnlAmount.Controls.Add(this.txtBaseAmount);
            this.pnlAmount.Controls.Add(this.label7);
            this.pnlAmount.Location = new System.Drawing.Point(3, 188);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(539, 43);
            this.pnlAmount.TabIndex = 13;
            // 
            // txtBaseAmount
            // 
            this.txtBaseAmount.Location = new System.Drawing.Point(87, 10);
            this.txtBaseAmount.Name = "txtBaseAmount";
            this.txtBaseAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBaseAmount.TabIndex = 46;
            this.txtBaseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Base Amount:";
            // 
            // flpMain
            // 
            this.flpMain.AutoSize = true;
            this.flpMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMain.Controls.Add(this.pnlWeeks);
            this.flpMain.Controls.Add(this.flpMonths);
            this.flpMain.Controls.Add(this.pnlYears);
            this.flpMain.Controls.Add(this.pnlAmount);
            this.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMain.Location = new System.Drawing.Point(27, 115);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(563, 241);
            this.flpMain.TabIndex = 14;
            // 
            // pnlYears
            // 
            this.pnlYears.Controls.Add(this.label9);
            this.pnlYears.Controls.Add(this.txtOn);
            this.pnlYears.Controls.Add(this.label8);
            this.pnlYears.Location = new System.Drawing.Point(3, 159);
            this.pnlYears.Name = "pnlYears";
            this.pnlYears.Size = new System.Drawing.Size(540, 23);
            this.pnlYears.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "(Comma seperated list of days of the year, as integers)";
            // 
            // txtOn
            // 
            this.txtOn.Location = new System.Drawing.Point(30, 1);
            this.txtOn.Name = "txtOn";
            this.txtOn.Size = new System.Drawing.Size(219, 20);
            this.txtOn.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "On";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(343, 70);
            this.dtpFrom.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(101, 20);
            this.dtpFrom.TabIndex = 4;
            // 
            // dtpUntil
            // 
            this.dtpUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUntil.Location = new System.Drawing.Point(494, 70);
            this.dtpUntil.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpUntil.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(101, 20);
            this.dtpUntil.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Until";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Transaction Name:";
            // 
            // txtTransName
            // 
            this.txtTransName.Location = new System.Drawing.Point(177, 35);
            this.txtTransName.Name = "txtTransName";
            this.txtTransName.Size = new System.Drawing.Size(233, 20);
            this.txtTransName.TabIndex = 1;
            // 
            // Recurring
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(616, 408);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTransName);
            this.Controls.Add(this.dtpUntil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmboRepeat);
            this.Controls.Add(this.nudNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpMain);
            this.Name = "Recurring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Recurring Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            this.pnlWeeks.ResumeLayout(false);
            this.pnlWeeks.PerformLayout();
            this.flpMonths.ResumeLayout(false);
            this.flpMonths.PerformLayout();
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            this.flpMain.ResumeLayout(false);
            this.pnlYears.ResumeLayout(false);
            this.pnlYears.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.ComboBox cmboRepeat;
        private System.Windows.Forms.Panel pnlWeeks;
        private System.Windows.Forms.CheckBox cbSunday;
        private System.Windows.Forms.CheckBox cbSaturday;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.CheckBox cbTuesday;
        private System.Windows.Forms.CheckBox cbMonday;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flpMonths;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox checkBox63;
        private System.Windows.Forms.CheckBox checkBox62;
        public System.Windows.Forms.CheckBox checkBox61;
        private System.Windows.Forms.CheckBox checkBox60;
        private System.Windows.Forms.CheckBox checkBox59;
        private System.Windows.Forms.CheckBox checkBox58;
        private System.Windows.Forms.CheckBox checkBox57;
        public System.Windows.Forms.CheckBox checkBox56;
        private System.Windows.Forms.CheckBox checkBox55;
        private System.Windows.Forms.CheckBox checkBox54;
        private System.Windows.Forms.CheckBox checkBox53;
        private System.Windows.Forms.CheckBox checkBox52;
        public System.Windows.Forms.CheckBox checkBox51;
        private System.Windows.Forms.CheckBox checkBox50;
        private System.Windows.Forms.CheckBox checkBox49;
        private System.Windows.Forms.CheckBox checkBox48;
        private System.Windows.Forms.CheckBox checkBox47;
        public System.Windows.Forms.CheckBox checkBox46;
        private System.Windows.Forms.CheckBox checkBox45;
        private System.Windows.Forms.CheckBox checkBox44;
        private System.Windows.Forms.CheckBox checkBox43;
        private System.Windows.Forms.CheckBox checkBox42;
        public System.Windows.Forms.CheckBox checkBox41;
        private System.Windows.Forms.CheckBox checkBox40;
        private System.Windows.Forms.CheckBox checkBox39;
        private System.Windows.Forms.CheckBox checkBox38;
        private System.Windows.Forms.CheckBox checkBox37;
        public System.Windows.Forms.CheckBox checkBox36;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.Panel pnlAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaseAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpUntil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlYears;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTransName;
    }
}