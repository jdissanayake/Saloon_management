namespace Liberty_Saloon
{
    partial class Payment
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
            this.dgvAppP = new System.Windows.Forms.DataGridView();
            this.aid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emplid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPf = new System.Windows.Forms.TextBox();
            this.btnAppUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAppEid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAppDelete = new System.Windows.Forms.Button();
            this.lblAppCid = new System.Windows.Forms.Label();
            this.btnAppRefresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAppAdd = new System.Windows.Forms.Button();
            this.txtAtime = new System.Windows.Forms.TextBox();
            this.txtApayment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAppDate = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppP)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Payment";
            // 
            // dgvAppP
            // 
            this.dgvAppP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aid,
            this.Date,
            this.Time,
            this.Custid,
            this.Emplid,
            this.Payement});
            this.dgvAppP.Location = new System.Drawing.Point(18, 17);
            this.dgvAppP.Name = "dgvAppP";
            this.dgvAppP.RowHeadersWidth = 51;
            this.dgvAppP.RowTemplate.Height = 24;
            this.dgvAppP.Size = new System.Drawing.Size(918, 440);
            this.dgvAppP.TabIndex = 8;
            this.dgvAppP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppP_CellContentClick);
            this.dgvAppP.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppP_CellMouseDoubleClick);
            // 
            // aid
            // 
            this.aid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aid.HeaderText = "Appoinment ID";
            this.aid.MinimumWidth = 6;
            this.aid.Name = "aid";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // Custid
            // 
            this.Custid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Custid.HeaderText = "Customer ID";
            this.Custid.MinimumWidth = 6;
            this.Custid.Name = "Custid";
            // 
            // Emplid
            // 
            this.Emplid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Emplid.HeaderText = "Employee ID";
            this.Emplid.MinimumWidth = 6;
            this.Emplid.Name = "Emplid";
            // 
            // Payement
            // 
            this.Payement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Payement.HeaderText = "Payement";
            this.Payement.MinimumWidth = 6;
            this.Payement.Name = "Payement";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.dgvPay);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 801);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvPay
            // 
            this.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.cid,
            this.eid,
            this.da,
            this.price,
            this.pay});
            this.dgvPay.Location = new System.Drawing.Point(15, 499);
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.RowHeadersWidth = 51;
            this.dgvPay.RowTemplate.Height = 24;
            this.dgvPay.Size = new System.Drawing.Size(954, 276);
            this.dgvPay.TabIndex = 10;
            // 
            // pid
            // 
            this.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pid.HeaderText = "PID";
            this.pid.MinimumWidth = 6;
            this.pid.Name = "pid";
            // 
            // cid
            // 
            this.cid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cid.HeaderText = "C-ID";
            this.cid.MinimumWidth = 6;
            this.cid.Name = "cid";
            // 
            // eid
            // 
            this.eid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eid.HeaderText = "E-ID";
            this.eid.MinimumWidth = 6;
            this.eid.Name = "eid";
            // 
            // da
            // 
            this.da.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.da.HeaderText = "Date";
            this.da.MinimumWidth = 6;
            this.da.Name = "da";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // pay
            // 
            this.pay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pay.HeaderText = "payment";
            this.pay.MinimumWidth = 6;
            this.pay.Name = "pay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPf);
            this.groupBox1.Controls.Add(this.btnAppUpdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblAppEid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAppDelete);
            this.groupBox1.Controls.Add(this.lblAppCid);
            this.groupBox1.Controls.Add(this.btnAppRefresh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAppAdd);
            this.groupBox1.Controls.Add(this.txtAtime);
            this.groupBox1.Controls.Add(this.txtApayment);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAppDate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(989, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 772);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 741);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Employee Salary";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(169, 343);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(158, 30);
            this.txtprice.TabIndex = 8;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Liberty_Saloon.Properties.Resources.icons8_receive_cash_48;
            this.button1.Location = new System.Drawing.Point(182, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 70);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPf
            // 
            this.txtPf.Location = new System.Drawing.Point(169, 407);
            this.txtPf.Name = "txtPf";
            this.txtPf.Size = new System.Drawing.Size(158, 30);
            this.txtPf.TabIndex = 7;
            // 
            // btnAppUpdate
            // 
            this.btnAppUpdate.FlatAppearance.BorderSize = 0;
            this.btnAppUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppUpdate.Image = global::Liberty_Saloon.Properties.Resources.icons8_installing_updates_48;
            this.btnAppUpdate.Location = new System.Drawing.Point(90, 562);
            this.btnAppUpdate.Name = "btnAppUpdate";
            this.btnAppUpdate.Size = new System.Drawing.Size(76, 70);
            this.btnAppUpdate.TabIndex = 5;
            this.btnAppUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID";
            // 
            // lblAid
            // 
            this.lblAid.AutoSize = true;
            this.lblAid.Location = new System.Drawing.Point(166, 26);
            this.lblAid.Name = "lblAid";
            this.lblAid.Size = new System.Drawing.Size(55, 23);
            this.lblAid.TabIndex = 6;
            this.lblAid.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Appointment ID";
            // 
            // lblAppEid
            // 
            this.lblAppEid.AutoSize = true;
            this.lblAppEid.ForeColor = System.Drawing.Color.White;
            this.lblAppEid.Location = new System.Drawing.Point(166, 65);
            this.lblAppEid.Name = "lblAppEid";
            this.lblAppEid.Size = new System.Drawing.Size(107, 23);
            this.lblAppEid.TabIndex = 0;
            this.lblAppEid.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Time";
            // 
            // btnAppDelete
            // 
            this.btnAppDelete.FlatAppearance.BorderSize = 0;
            this.btnAppDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppDelete.Image = global::Liberty_Saloon.Properties.Resources.icons8_trash_48;
            this.btnAppDelete.Location = new System.Drawing.Point(188, 562);
            this.btnAppDelete.Name = "btnAppDelete";
            this.btnAppDelete.Size = new System.Drawing.Size(76, 70);
            this.btnAppDelete.TabIndex = 5;
            this.btnAppDelete.UseVisualStyleBackColor = true;
            this.btnAppDelete.Click += new System.EventHandler(this.btnAppDelete_Click);
            // 
            // lblAppCid
            // 
            this.lblAppCid.AutoSize = true;
            this.lblAppCid.ForeColor = System.Drawing.Color.White;
            this.lblAppCid.Location = new System.Drawing.Point(166, 106);
            this.lblAppCid.Name = "lblAppCid";
            this.lblAppCid.Size = new System.Drawing.Size(106, 23);
            this.lblAppCid.TabIndex = 0;
            this.lblAppCid.Text = "Customer ID";
            // 
            // btnAppRefresh
            // 
            this.btnAppRefresh.FlatAppearance.BorderSize = 0;
            this.btnAppRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppRefresh.Image = global::Liberty_Saloon.Properties.Resources.icons8_refresh_48;
            this.btnAppRefresh.Location = new System.Drawing.Point(286, 562);
            this.btnAppRefresh.Name = "btnAppRefresh";
            this.btnAppRefresh.Size = new System.Drawing.Size(76, 70);
            this.btnAppRefresh.TabIndex = 5;
            this.btnAppRefresh.UseVisualStyleBackColor = true;
            this.btnAppRefresh.Click += new System.EventHandler(this.btnAppRefresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Advance";
            // 
            // btnAppAdd
            // 
            this.btnAppAdd.FlatAppearance.BorderSize = 0;
            this.btnAppAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppAdd.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppAdd.Image = global::Liberty_Saloon.Properties.Resources.icons8_paper_money_48;
            this.btnAppAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppAdd.Location = new System.Drawing.Point(138, 473);
            this.btnAppAdd.Name = "btnAppAdd";
            this.btnAppAdd.Size = new System.Drawing.Size(174, 70);
            this.btnAppAdd.TabIndex = 5;
            this.btnAppAdd.Text = "      Done";
            this.btnAppAdd.UseVisualStyleBackColor = true;
            this.btnAppAdd.Click += new System.EventHandler(this.btnAppAdd_Click);
            // 
            // txtAtime
            // 
            this.txtAtime.Location = new System.Drawing.Point(169, 150);
            this.txtAtime.Name = "txtAtime";
            this.txtAtime.Size = new System.Drawing.Size(158, 30);
            this.txtAtime.TabIndex = 1;
            // 
            // txtApayment
            // 
            this.txtApayment.Location = new System.Drawing.Point(169, 280);
            this.txtApayment.Name = "txtApayment";
            this.txtApayment.Size = new System.Drawing.Size(158, 30);
            this.txtApayment.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date";
            // 
            // txtAppDate
            // 
            this.txtAppDate.Location = new System.Drawing.Point(169, 215);
            this.txtAppDate.Name = "txtAppDate";
            this.txtAppDate.Size = new System.Drawing.Size(158, 30);
            this.txtAppDate.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.dgvAppP);
            this.panel2.Location = new System.Drawing.Point(15, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 472);
            this.panel2.TabIndex = 9;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1587, 923);
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppP)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAppP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAppUpdate;
        private System.Windows.Forms.Button btnAppDelete;
        private System.Windows.Forms.Button btnAppRefresh;
        private System.Windows.Forms.Button btnAppAdd;
        private System.Windows.Forms.TextBox txtApayment;
        private System.Windows.Forms.TextBox txtAppDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAtime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAppCid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAppEid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emplid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payement;
        private System.Windows.Forms.TextBox txtPf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn eid;
        private System.Windows.Forms.DataGridViewTextBoxColumn da;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
    }
}
