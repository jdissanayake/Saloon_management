namespace Liberty_Saloon
{
    partial class Attendence
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAEid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAEname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pcheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAttendenceRefresh = new System.Windows.Forms.Button();
            this.lblAttendenceDate = new System.Windows.Forms.Label();
            this.dgvAttendence = new System.Windows.Forms.DataGridView();
            this.Eid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAttendence = new System.Windows.Forms.Button();
            this.Acheck = new System.Windows.Forms.CheckBox();
            this.dgvAttendenceeDisplay = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnEid = new System.Windows.Forms.RadioButton();
            this.RbtnDate = new System.Windows.Forms.RadioButton();
            this.dgvAttSearch = new System.Windows.Forms.DataGridView();
            this.Emplid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAttSearchD = new System.Windows.Forms.Button();
            this.txtAttDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAtt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendenceeDisplay)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttSearch)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Attendence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAEid
            // 
            this.lblAEid.AutoSize = true;
            this.lblAEid.BackColor = System.Drawing.Color.Transparent;
            this.lblAEid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAEid.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAEid.Location = new System.Drawing.Point(206, 53);
            this.lblAEid.Name = "lblAEid";
            this.lblAEid.Size = new System.Drawing.Size(66, 28);
            this.lblAEid.TabIndex = 4;
            this.lblAEid.Text = "label2";
            this.lblAEid.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Employee Name";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAEname
            // 
            this.lblAEname.AutoSize = true;
            this.lblAEname.BackColor = System.Drawing.Color.Transparent;
            this.lblAEname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAEname.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAEname.Location = new System.Drawing.Point(206, 118);
            this.lblAEname.Name = "lblAEname";
            this.lblAEname.Size = new System.Drawing.Size(66, 28);
            this.lblAEname.TabIndex = 4;
            this.lblAEname.Text = "label2";
            this.lblAEname.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // Pcheck
            // 
            this.Pcheck.AutoSize = true;
            this.Pcheck.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pcheck.ForeColor = System.Drawing.Color.White;
            this.Pcheck.Location = new System.Drawing.Point(95, 304);
            this.Pcheck.Name = "Pcheck";
            this.Pcheck.Size = new System.Drawing.Size(138, 42);
            this.Pcheck.TabIndex = 5;
            this.Pcheck.Text = "Precent";
            this.Pcheck.UseVisualStyleBackColor = true;
            this.Pcheck.CheckedChanged += new System.EventHandler(this.Pcheck_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.btnAttendenceRefresh);
            this.panel1.Controls.Add(this.lblAttendenceDate);
            this.panel1.Controls.Add(this.dgvAttendence);
            this.panel1.Controls.Add(this.btnAddAttendence);
            this.panel1.Controls.Add(this.Acheck);
            this.panel1.Controls.Add(this.Pcheck);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAEid);
            this.panel1.Controls.Add(this.lblAEname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(58, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 433);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAttendenceRefresh
            // 
            this.btnAttendenceRefresh.BackgroundImage = global::Liberty_Saloon.Properties.Resources.icons8_refresh_48;
            this.btnAttendenceRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAttendenceRefresh.FlatAppearance.BorderSize = 0;
            this.btnAttendenceRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendenceRefresh.Location = new System.Drawing.Point(253, 357);
            this.btnAttendenceRefresh.Name = "btnAttendenceRefresh";
            this.btnAttendenceRefresh.Size = new System.Drawing.Size(73, 59);
            this.btnAttendenceRefresh.TabIndex = 9;
            this.btnAttendenceRefresh.UseVisualStyleBackColor = true;
            this.btnAttendenceRefresh.Click += new System.EventHandler(this.btnAttendenceRefresh_Click);
            // 
            // lblAttendenceDate
            // 
            this.lblAttendenceDate.AutoSize = true;
            this.lblAttendenceDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendenceDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendenceDate.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAttendenceDate.Location = new System.Drawing.Point(203, 182);
            this.lblAttendenceDate.Name = "lblAttendenceDate";
            this.lblAttendenceDate.Size = new System.Drawing.Size(66, 28);
            this.lblAttendenceDate.TabIndex = 8;
            this.lblAttendenceDate.Text = "label3";
            this.lblAttendenceDate.Click += new System.EventHandler(this.lblAttendenceDate_Click);
            // 
            // dgvAttendence
            // 
            this.dgvAttendence.AllowUserToAddRows = false;
            this.dgvAttendence.AllowUserToDeleteRows = false;
            this.dgvAttendence.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eid,
            this.Ename});
            this.dgvAttendence.Location = new System.Drawing.Point(334, 10);
            this.dgvAttendence.Name = "dgvAttendence";
            this.dgvAttendence.ReadOnly = true;
            this.dgvAttendence.RowHeadersWidth = 51;
            this.dgvAttendence.RowTemplate.Height = 24;
            this.dgvAttendence.Size = new System.Drawing.Size(408, 416);
            this.dgvAttendence.TabIndex = 8;
            this.dgvAttendence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendence_CellContentClick);
            this.dgvAttendence.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAttendence_CellMouseDoubleClick);
            // 
            // Eid
            // 
            this.Eid.HeaderText = "Employee ID";
            this.Eid.MinimumWidth = 6;
            this.Eid.Name = "Eid";
            this.Eid.ReadOnly = true;
            this.Eid.Width = 125;
            // 
            // Ename
            // 
            this.Ename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ename.HeaderText = "Employee Name";
            this.Ename.MinimumWidth = 6;
            this.Ename.Name = "Ename";
            this.Ename.ReadOnly = true;
            // 
            // btnAddAttendence
            // 
            this.btnAddAttendence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnAddAttendence.FlatAppearance.BorderSize = 0;
            this.btnAddAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAttendence.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAttendence.ForeColor = System.Drawing.Color.White;
            this.btnAddAttendence.Location = new System.Drawing.Point(23, 366);
            this.btnAddAttendence.Name = "btnAddAttendence";
            this.btnAddAttendence.Size = new System.Drawing.Size(210, 50);
            this.btnAddAttendence.TabIndex = 7;
            this.btnAddAttendence.Text = "ADD";
            this.btnAddAttendence.UseVisualStyleBackColor = false;
            this.btnAddAttendence.Click += new System.EventHandler(this.btnAddAttendence_Click);
            // 
            // Acheck
            // 
            this.Acheck.AutoSize = true;
            this.Acheck.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acheck.ForeColor = System.Drawing.Color.White;
            this.Acheck.Location = new System.Drawing.Point(95, 245);
            this.Acheck.Name = "Acheck";
            this.Acheck.Size = new System.Drawing.Size(132, 42);
            this.Acheck.TabIndex = 5;
            this.Acheck.Text = "Abcent";
            this.Acheck.UseVisualStyleBackColor = true;
            // 
            // dgvAttendenceeDisplay
            // 
            this.dgvAttendenceeDisplay.AllowUserToAddRows = false;
            this.dgvAttendenceeDisplay.AllowUserToOrderColumns = true;
            this.dgvAttendenceeDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendenceeDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.Emid,
            this.Emname,
            this.availability});
            this.dgvAttendenceeDisplay.Location = new System.Drawing.Point(19, 18);
            this.dgvAttendenceeDisplay.Name = "dgvAttendenceeDisplay";
            this.dgvAttendenceeDisplay.RowHeadersWidth = 51;
            this.dgvAttendenceeDisplay.RowTemplate.Height = 24;
            this.dgvAttendenceeDisplay.Size = new System.Drawing.Size(599, 408);
            this.dgvAttendenceeDisplay.TabIndex = 9;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // Emid
            // 
            this.Emid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Emid.HeaderText = "Employee ID";
            this.Emid.MinimumWidth = 6;
            this.Emid.Name = "Emid";
            // 
            // Emname
            // 
            this.Emname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Emname.HeaderText = "Employee Name";
            this.Emname.MinimumWidth = 6;
            this.Emname.Name = "Emname";
            // 
            // availability
            // 
            this.availability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.availability.HeaderText = "Availability";
            this.availability.MinimumWidth = 6;
            this.availability.Name = "availability";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.rbtnEid);
            this.panel2.Controls.Add(this.RbtnDate);
            this.panel2.Controls.Add(this.dgvAttSearch);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnAttSearchD);
            this.panel2.Controls.Add(this.txtAttDate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtAtt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(58, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 322);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Liberty_Saloon.Properties.Resources.icons8_search_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(334, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "   Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rbtnEid
            // 
            this.rbtnEid.AutoSize = true;
            this.rbtnEid.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEid.ForeColor = System.Drawing.Color.White;
            this.rbtnEid.Location = new System.Drawing.Point(97, 174);
            this.rbtnEid.Name = "rbtnEid";
            this.rbtnEid.Size = new System.Drawing.Size(82, 30);
            this.rbtnEid.TabIndex = 13;
            this.rbtnEid.TabStop = true;
            this.rbtnEid.Text = "On E ID";
            this.rbtnEid.UseVisualStyleBackColor = true;
            this.rbtnEid.CheckedChanged += new System.EventHandler(this.rbtnEid_CheckedChanged);
            // 
            // RbtnDate
            // 
            this.RbtnDate.AutoSize = true;
            this.RbtnDate.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnDate.ForeColor = System.Drawing.Color.White;
            this.RbtnDate.Location = new System.Drawing.Point(95, 87);
            this.RbtnDate.Name = "RbtnDate";
            this.RbtnDate.Size = new System.Drawing.Size(84, 30);
            this.RbtnDate.TabIndex = 12;
            this.RbtnDate.TabStop = true;
            this.RbtnDate.Text = "On Date";
            this.RbtnDate.UseVisualStyleBackColor = true;
            this.RbtnDate.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dgvAttSearch
            // 
            this.dgvAttSearch.AllowUserToAddRows = false;
            this.dgvAttSearch.AllowUserToDeleteRows = false;
            this.dgvAttSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvAttSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emplid,
            this.EmpName,
            this.Adate,
            this.pa});
            this.dgvAttSearch.Location = new System.Drawing.Point(589, 20);
            this.dgvAttSearch.Name = "dgvAttSearch";
            this.dgvAttSearch.ReadOnly = true;
            this.dgvAttSearch.RowHeadersWidth = 51;
            this.dgvAttSearch.RowTemplate.Height = 24;
            this.dgvAttSearch.Size = new System.Drawing.Size(662, 286);
            this.dgvAttSearch.TabIndex = 11;
            // 
            // Emplid
            // 
            this.Emplid.HeaderText = "Employee ID";
            this.Emplid.MinimumWidth = 6;
            this.Emplid.Name = "Emplid";
            this.Emplid.ReadOnly = true;
            this.Emplid.Width = 125;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // Adate
            // 
            this.Adate.HeaderText = "Date";
            this.Adate.MinimumWidth = 6;
            this.Adate.Name = "Adate";
            this.Adate.ReadOnly = true;
            this.Adate.Width = 125;
            // 
            // pa
            // 
            this.pa.HeaderText = "Avalability";
            this.pa.MinimumWidth = 6;
            this.pa.Name = "pa";
            this.pa.ReadOnly = true;
            this.pa.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(88, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 41);
            this.label5.TabIndex = 6;
            this.label5.Text = "Attendence Search";
            // 
            // btnAttSearchD
            // 
            this.btnAttSearchD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnAttSearchD.FlatAppearance.BorderSize = 0;
            this.btnAttSearchD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttSearchD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttSearchD.ForeColor = System.Drawing.Color.White;
            this.btnAttSearchD.Image = global::Liberty_Saloon.Properties.Resources.icons8_search_16;
            this.btnAttSearchD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttSearchD.Location = new System.Drawing.Point(332, 120);
            this.btnAttSearchD.Name = "btnAttSearchD";
            this.btnAttSearchD.Size = new System.Drawing.Size(116, 35);
            this.btnAttSearchD.TabIndex = 5;
            this.btnAttSearchD.Text = "     Search";
            this.btnAttSearchD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttSearchD.UseVisualStyleBackColor = false;
            this.btnAttSearchD.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAttDate
            // 
            this.txtAttDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttDate.Location = new System.Drawing.Point(93, 121);
            this.txtAttDate.Name = "txtAttDate";
            this.txtAttDate.Size = new System.Drawing.Size(233, 34);
            this.txtAttDate.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Date -";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAtt
            // 
            this.txtAtt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtt.Location = new System.Drawing.Point(95, 208);
            this.txtAtt.Name = "txtAtt";
            this.txtAtt.Size = new System.Drawing.Size(233, 34);
            this.txtAtt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "E ID  -";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.panel3.Controls.Add(this.dgvAttendenceeDisplay);
            this.panel3.Location = new System.Drawing.Point(827, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 433);
            this.panel3.TabIndex = 11;
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Attendence";
            this.Size = new System.Drawing.Size(1587, 923);
            this.Load += new System.EventHandler(this.Attendence_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendenceeDisplay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttSearch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAEid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAEname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Pcheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAttendence;
        private System.Windows.Forms.Button btnAddAttendence;
        private System.Windows.Forms.CheckBox Acheck;
        private System.Windows.Forms.Label lblAttendenceDate;
        private System.Windows.Forms.DataGridView dgvAttendenceeDisplay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAttSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAttSearchD;
        private System.Windows.Forms.TextBox txtAtt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAttDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RbtnDate;
        private System.Windows.Forms.RadioButton rbtnEid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ename;
        private System.Windows.Forms.Button btnAttendenceRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emplid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emname;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
    }
}
