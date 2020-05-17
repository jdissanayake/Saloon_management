namespace Liberty_Saloon
{
    partial class DashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bTnEmployee = new System.Windows.Forms.Button();
            this.bTnAppoinment = new System.Windows.Forms.Button();
            this.bTnCustomer = new System.Windows.Forms.Button();
            this.bTnHome = new System.Windows.Forms.Button();
            this.bTnPayment = new System.Windows.Forms.Button();
            this.bTnAttendence = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.appoinment1 = new Liberty_Saloon.Appoinment();
            this.customer1 = new Liberty_Saloon.Customer();
            this.employee1 = new Liberty_Saloon.Employee();
            this.payment1 = new Liberty_Saloon.Payment();
            this.attendence1 = new Liberty_Saloon.Attendence();
            this.home1 = new Liberty_Saloon.Home();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.appoinment1);
            this.panel1.Controls.Add(this.customer1);
            this.panel1.Controls.Add(this.employee1);
            this.panel1.Controls.Add(this.payment1);
            this.panel1.Controls.Add(this.attendence1);
            this.panel1.Controls.Add(this.home1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(315, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 563);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.bTnEmployee);
            this.panel3.Controls.Add(this.bTnAppoinment);
            this.panel3.Controls.Add(this.bTnCustomer);
            this.panel3.Controls.Add(this.bTnHome);
            this.panel3.Controls.Add(this.bTnPayment);
            this.panel3.Controls.Add(this.bTnAttendence);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 673);
            this.panel3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(315, 212);
            this.panel5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anuradhapura";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liberty Saloon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Liberty_Saloon.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(79, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bTnEmployee
            // 
            this.bTnEmployee.FlatAppearance.BorderSize = 0;
            this.bTnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTnEmployee.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnEmployee.ForeColor = System.Drawing.Color.White;
            this.bTnEmployee.Image = global::Liberty_Saloon.Properties.Resources.icons8_worker_48;
            this.bTnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnEmployee.Location = new System.Drawing.Point(32, 727);
            this.bTnEmployee.Name = "bTnEmployee";
            this.bTnEmployee.Size = new System.Drawing.Size(268, 61);
            this.bTnEmployee.TabIndex = 2;
            this.bTnEmployee.Text = "          Employee";
            this.bTnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnEmployee.UseVisualStyleBackColor = true;
            this.bTnEmployee.Click += new System.EventHandler(this.bTnEmployee_Click);
            // 
            // bTnAppoinment
            // 
            this.bTnAppoinment.FlatAppearance.BorderSize = 0;
            this.bTnAppoinment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTnAppoinment.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnAppoinment.ForeColor = System.Drawing.Color.White;
            this.bTnAppoinment.Image = global::Liberty_Saloon.Properties.Resources.icons8_today_48;
            this.bTnAppoinment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnAppoinment.Location = new System.Drawing.Point(32, 432);
            this.bTnAppoinment.Name = "bTnAppoinment";
            this.bTnAppoinment.Size = new System.Drawing.Size(283, 61);
            this.bTnAppoinment.TabIndex = 6;
            this.bTnAppoinment.Text = "          Appoinment";
            this.bTnAppoinment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnAppoinment.UseVisualStyleBackColor = true;
            this.bTnAppoinment.Click += new System.EventHandler(this.bTnAppoinment_Click);
            // 
            // bTnCustomer
            // 
            this.bTnCustomer.FlatAppearance.BorderSize = 0;
            this.bTnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTnCustomer.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnCustomer.ForeColor = System.Drawing.Color.White;
            this.bTnCustomer.Image = global::Liberty_Saloon.Properties.Resources.icons8_customer_481;
            this.bTnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnCustomer.Location = new System.Drawing.Point(32, 634);
            this.bTnCustomer.Name = "bTnCustomer";
            this.bTnCustomer.Size = new System.Drawing.Size(268, 61);
            this.bTnCustomer.TabIndex = 5;
            this.bTnCustomer.Text = "          Customer";
            this.bTnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnCustomer.UseVisualStyleBackColor = true;
            this.bTnCustomer.Click += new System.EventHandler(this.bTnCustomer_Click);
            // 
            // bTnHome
            // 
            this.bTnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.bTnHome.FlatAppearance.BorderSize = 0;
            this.bTnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTnHome.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnHome.ForeColor = System.Drawing.Color.White;
            this.bTnHome.Image = global::Liberty_Saloon.Properties.Resources.icons8_home_48;
            this.bTnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnHome.Location = new System.Drawing.Point(32, 236);
            this.bTnHome.Name = "bTnHome";
            this.bTnHome.Size = new System.Drawing.Size(268, 61);
            this.bTnHome.TabIndex = 1;
            this.bTnHome.Text = "          Home";
            this.bTnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnHome.UseVisualStyleBackColor = false;
            this.bTnHome.Click += new System.EventHandler(this.bTnHome_Click);
            // 
            // bTnPayment
            // 
            this.bTnPayment.FlatAppearance.BorderSize = 0;
            this.bTnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTnPayment.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnPayment.ForeColor = System.Drawing.Color.White;
            this.bTnPayment.Image = global::Liberty_Saloon.Properties.Resources.icons8_online_payment_with_a_credit_card_48;
            this.bTnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnPayment.Location = new System.Drawing.Point(32, 533);
            this.bTnPayment.Name = "bTnPayment";
            this.bTnPayment.Size = new System.Drawing.Size(268, 61);
            this.bTnPayment.TabIndex = 4;
            this.bTnPayment.Text = "          Payment";
            this.bTnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnPayment.UseVisualStyleBackColor = true;
            this.bTnPayment.Click += new System.EventHandler(this.bTnPayment_Click);
            // 
            // bTnAttendence
            // 
            this.bTnAttendence.FlatAppearance.BorderSize = 0;
            this.bTnAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTnAttendence.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnAttendence.ForeColor = System.Drawing.Color.White;
            this.bTnAttendence.Image = global::Liberty_Saloon.Properties.Resources.icons8_attendance_48;
            this.bTnAttendence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnAttendence.Location = new System.Drawing.Point(32, 334);
            this.bTnAttendence.Name = "bTnAttendence";
            this.bTnAttendence.Size = new System.Drawing.Size(268, 61);
            this.bTnAttendence.TabIndex = 3;
            this.bTnAttendence.Text = "          Attendence";
            this.bTnAttendence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTnAttendence.UseVisualStyleBackColor = true;
            this.bTnAttendence.Click += new System.EventHandler(this.bTnAttendence_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(315, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 43);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(315, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(947, 67);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Liberty Saloon Anuradhapura";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // appoinment1
            // 
            this.appoinment1.AutoSize = true;
            this.appoinment1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appoinment1.BackColor = System.Drawing.Color.White;
            this.appoinment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appoinment1.Location = new System.Drawing.Point(0, 0);
            this.appoinment1.Name = "appoinment1";
            this.appoinment1.Size = new System.Drawing.Size(947, 563);
            this.appoinment1.TabIndex = 5;
            // 
            // customer1
            // 
            this.customer1.BackColor = System.Drawing.Color.White;
            this.customer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer1.Location = new System.Drawing.Point(0, 0);
            this.customer1.Name = "customer1";
            this.customer1.Size = new System.Drawing.Size(947, 563);
            this.customer1.TabIndex = 4;
            // 
            // employee1
            // 
            this.employee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employee1.Location = new System.Drawing.Point(0, 0);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(947, 563);
            this.employee1.TabIndex = 3;
            // 
            // payment1
            // 
            this.payment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payment1.Location = new System.Drawing.Point(0, 0);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(947, 563);
            this.payment1.TabIndex = 2;
            // 
            // attendence1
            // 
            this.attendence1.BackColor = System.Drawing.SystemColors.Control;
            this.attendence1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendence1.Location = new System.Drawing.Point(0, 0);
            this.attendence1.Name = "attendence1";
            this.attendence1.Size = new System.Drawing.Size(947, 563);
            this.attendence1.TabIndex = 1;
            // 
            // home1
            // 
            this.home1.AutoSize = true;
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(947, 563);
            this.home1.TabIndex = 0;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bTnEmployee;
        private System.Windows.Forms.Button bTnAppoinment;
        private System.Windows.Forms.Button bTnCustomer;
        private System.Windows.Forms.Button bTnHome;
        private System.Windows.Forms.Button bTnPayment;
        private System.Windows.Forms.Button bTnAttendence;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private Home home1;
        private Customer customer1;
        private Employee employee1;
        private Payment payment1;
        private Attendence attendence1;
        private Appoinment appoinment1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}