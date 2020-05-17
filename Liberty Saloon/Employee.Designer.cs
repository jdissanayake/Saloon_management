namespace Liberty_Saloon
{
    partial class Employee
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvE = new System.Windows.Forms.DataGridView();
            this.Eid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtellNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.lblEid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpE = new System.Windows.Forms.DateTimePicker();
            this.txtEaddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEupdate = new System.Windows.Forms.Button();
            this.txtEtellno = new System.Windows.Forms.TextBox();
            this.btnEdelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEnic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvE)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 59);
            this.label6.TabIndex = 5;
            this.label6.Text = "Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(34, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1519, 723);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.dgvE);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(491, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 643);
            this.panel2.TabIndex = 10;
            // 
            // dgvE
            // 
            this.dgvE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eid,
            this.Ename,
            this.Eaddress,
            this.EtellNo,
            this.Edob,
            this.Enic});
            this.dgvE.Location = new System.Drawing.Point(23, 65);
            this.dgvE.Name = "dgvE";
            this.dgvE.RowHeadersWidth = 51;
            this.dgvE.RowTemplate.Height = 24;
            this.dgvE.Size = new System.Drawing.Size(956, 562);
            this.dgvE.TabIndex = 7;
            this.dgvE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvE_CellContentClick);
            this.dgvE.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvE_CellMouseDoubleClick);
            this.dgvE.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvE_CellDoubleClick);
            // 
            // Eid
            // 
            this.Eid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eid.HeaderText = "Employee ID";
            this.Eid.MinimumWidth = 6;
            this.Eid.Name = "Eid";
            // 
            // Ename
            // 
            this.Ename.HeaderText = "Employee Name";
            this.Ename.MinimumWidth = 6;
            this.Ename.Name = "Ename";
            this.Ename.Width = 125;
            // 
            // Eaddress
            // 
            this.Eaddress.HeaderText = "Address";
            this.Eaddress.MinimumWidth = 6;
            this.Eaddress.Name = "Eaddress";
            this.Eaddress.Width = 125;
            // 
            // EtellNo
            // 
            this.EtellNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EtellNo.HeaderText = "Telephone";
            this.EtellNo.MinimumWidth = 6;
            this.EtellNo.Name = "EtellNo";
            // 
            // Edob
            // 
            this.Edob.HeaderText = "Birthday";
            this.Edob.MinimumWidth = 6;
            this.Edob.Name = "Edob";
            this.Edob.Width = 125;
            // 
            // Enic
            // 
            this.Enic.HeaderText = "NIC";
            this.Enic.MinimumWidth = 6;
            this.Enic.Name = "Enic";
            this.Enic.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(380, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 41);
            this.label7.TabIndex = 4;
            this.label7.Text = "Employee Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtEname);
            this.groupBox1.Controls.Add(this.lblEid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpE);
            this.groupBox1.Controls.Add(this.txtEaddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnEupdate);
            this.groupBox1.Controls.Add(this.txtEtellno);
            this.groupBox1.Controls.Add(this.btnEdelete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtEnic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 599);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Employee";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::Liberty_Saloon.Properties.Resources.icons8_add_user_male_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(159, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 74);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "     Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "ID";
            // 
            // txtEname
            // 
            this.txtEname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEname.ForeColor = System.Drawing.Color.Navy;
            this.txtEname.Location = new System.Drawing.Point(121, 94);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(281, 30);
            this.txtEname.TabIndex = 1;
            // 
            // lblEid
            // 
            this.lblEid.AutoSize = true;
            this.lblEid.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEid.ForeColor = System.Drawing.Color.White;
            this.lblEid.Location = new System.Drawing.Point(128, 50);
            this.lblEid.Name = "lblEid";
            this.lblEid.Size = new System.Drawing.Size(55, 23);
            this.lblEid.TabIndex = 8;
            this.lblEid.Text = "label7";
            this.lblEid.Click += new System.EventHandler(this.lblEid_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "NIC";
            // 
            // dtpE
            // 
            this.dtpE.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpE.Location = new System.Drawing.Point(121, 270);
            this.dtpE.Name = "dtpE";
            this.dtpE.Size = new System.Drawing.Size(281, 30);
            this.dtpE.TabIndex = 7;
            this.dtpE.ValueChanged += new System.EventHandler(this.dtpE_ValueChanged);
            // 
            // txtEaddress
            // 
            this.txtEaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEaddress.ForeColor = System.Drawing.Color.Navy;
            this.txtEaddress.Location = new System.Drawing.Point(121, 152);
            this.txtEaddress.Name = "txtEaddress";
            this.txtEaddress.Size = new System.Drawing.Size(281, 30);
            this.txtEaddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "DOB";
            // 
            // btnEupdate
            // 
            this.btnEupdate.FlatAppearance.BorderSize = 0;
            this.btnEupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEupdate.Image = global::Liberty_Saloon.Properties.Resources.icons8_installing_updates_48;
            this.btnEupdate.Location = new System.Drawing.Point(82, 486);
            this.btnEupdate.Name = "btnEupdate";
            this.btnEupdate.Size = new System.Drawing.Size(76, 74);
            this.btnEupdate.TabIndex = 6;
            this.btnEupdate.UseVisualStyleBackColor = true;
            this.btnEupdate.Click += new System.EventHandler(this.btnEupdate_Click);
            // 
            // txtEtellno
            // 
            this.txtEtellno.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtellno.ForeColor = System.Drawing.Color.Navy;
            this.txtEtellno.Location = new System.Drawing.Point(121, 211);
            this.txtEtellno.Name = "txtEtellno";
            this.txtEtellno.Size = new System.Drawing.Size(281, 30);
            this.txtEtellno.TabIndex = 1;
            // 
            // btnEdelete
            // 
            this.btnEdelete.FlatAppearance.BorderSize = 0;
            this.btnEdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdelete.Image = global::Liberty_Saloon.Properties.Resources.icons8_trash_48;
            this.btnEdelete.Location = new System.Drawing.Point(179, 486);
            this.btnEdelete.Name = "btnEdelete";
            this.btnEdelete.Size = new System.Drawing.Size(76, 74);
            this.btnEdelete.TabIndex = 6;
            this.btnEdelete.UseVisualStyleBackColor = true;
            this.btnEdelete.Click += new System.EventHandler(this.btnEdelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tell No";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Liberty_Saloon.Properties.Resources.icons8_refresh_48;
            this.button2.Location = new System.Drawing.Point(276, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 74);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEnic
            // 
            this.txtEnic.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnic.ForeColor = System.Drawing.Color.Navy;
            this.txtEnic.Location = new System.Drawing.Point(121, 334);
            this.txtEnic.Name = "txtEnic";
            this.txtEnic.Size = new System.Drawing.Size(281, 30);
            this.txtEnic.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(149, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 41);
            this.label8.TabIndex = 4;
            this.label8.Text = "Add Employee";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(1587, 836);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEupdate;
        private System.Windows.Forms.Button btnEdelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEtellno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.DataGridView dgvE;
        private System.Windows.Forms.DateTimePicker dtpE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtellNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enic;
        private System.Windows.Forms.Panel panel2;
    }
}
