namespace Liberty_Saloon
{
    partial class Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadd = new System.Windows.Forms.Button();
            this.btnCusUpdate = new System.Windows.Forms.Button();
            this.btnCusDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCusId = new System.Windows.Forms.Label();
            this.txtCaddress = new System.Windows.Forms.TextBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCtell = new System.Windows.Forms.TextBox();
            this.dgvCus = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1519, 723);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(843, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 41);
            this.label6.TabIndex = 2;
            this.label6.Text = "Customer Details";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadd);
            this.groupBox1.Controls.Add(this.btnCusUpdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCusDelete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCrefresh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCusId);
            this.groupBox1.Controls.Add(this.txtCaddress);
            this.groupBox1.Controls.Add(this.txtCname);
            this.groupBox1.Controls.Add(this.txtCtell);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 674);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // btnCadd
            // 
            this.btnCadd.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnCadd.FlatAppearance.BorderSize = 0;
            this.btnCadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadd.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadd.ForeColor = System.Drawing.Color.White;
            this.btnCadd.Image = global::Liberty_Saloon.Properties.Resources.icons8_add_user_male_48;
            this.btnCadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadd.Location = new System.Drawing.Point(131, 404);
            this.btnCadd.Name = "btnCadd";
            this.btnCadd.Size = new System.Drawing.Size(199, 68);
            this.btnCadd.TabIndex = 5;
            this.btnCadd.Text = "      ADD";
            this.btnCadd.UseVisualStyleBackColor = true;
            this.btnCadd.UseWaitCursor = true;
            this.btnCadd.Click += new System.EventHandler(this.btnCadd_Click);
            // 
            // btnCusUpdate
            // 
            this.btnCusUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusUpdate.FlatAppearance.BorderSize = 0;
            this.btnCusUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusUpdate.Image = global::Liberty_Saloon.Properties.Resources.icons8_installing_updates_48;
            this.btnCusUpdate.Location = new System.Drawing.Point(60, 508);
            this.btnCusUpdate.Name = "btnCusUpdate";
            this.btnCusUpdate.Size = new System.Drawing.Size(101, 68);
            this.btnCusUpdate.TabIndex = 5;
            this.btnCusUpdate.UseVisualStyleBackColor = true;
            this.btnCusUpdate.Click += new System.EventHandler(this.btnCusUpdate_Click);
            // 
            // btnCusDelete
            // 
            this.btnCusDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusDelete.FlatAppearance.BorderSize = 0;
            this.btnCusDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusDelete.ForeColor = System.Drawing.Color.Red;
            this.btnCusDelete.Image = global::Liberty_Saloon.Properties.Resources.icons8_trash_48;
            this.btnCusDelete.Location = new System.Drawing.Point(170, 508);
            this.btnCusDelete.Name = "btnCusDelete";
            this.btnCusDelete.Size = new System.Drawing.Size(101, 68);
            this.btnCusDelete.TabIndex = 5;
            this.btnCusDelete.UseVisualStyleBackColor = true;
            this.btnCusDelete.Click += new System.EventHandler(this.btnCusDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Name";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCrefresh
            // 
            this.btnCrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrefresh.FlatAppearance.BorderSize = 0;
            this.btnCrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrefresh.Image = global::Liberty_Saloon.Properties.Resources.icons8_refresh_48;
            this.btnCrefresh.Location = new System.Drawing.Point(282, 508);
            this.btnCrefresh.Name = "btnCrefresh";
            this.btnCrefresh.Size = new System.Drawing.Size(101, 68);
            this.btnCrefresh.TabIndex = 5;
            this.btnCrefresh.UseVisualStyleBackColor = true;
            this.btnCrefresh.Click += new System.EventHandler(this.btnCrefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCusId
            // 
            this.lblCusId.AutoSize = true;
            this.lblCusId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusId.Location = new System.Drawing.Point(253, 80);
            this.lblCusId.Name = "lblCusId";
            this.lblCusId.Size = new System.Drawing.Size(40, 23);
            this.lblCusId.TabIndex = 3;
            this.lblCusId.Text = "C id";
            this.lblCusId.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCaddress
            // 
            this.txtCaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaddress.Location = new System.Drawing.Point(248, 254);
            this.txtCaddress.Name = "txtCaddress";
            this.txtCaddress.Size = new System.Drawing.Size(100, 30);
            this.txtCaddress.TabIndex = 4;
            // 
            // txtCname
            // 
            this.txtCname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCname.Location = new System.Drawing.Point(248, 130);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 30);
            this.txtCname.TabIndex = 4;
            // 
            // txtCtell
            // 
            this.txtCtell.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtell.Location = new System.Drawing.Point(248, 189);
            this.txtCtell.Name = "txtCtell";
            this.txtCtell.Size = new System.Drawing.Size(100, 30);
            this.txtCtell.TabIndex = 4;
            // 
            // dgvCus
            // 
            this.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CName,
            this.CTell,
            this.CAddress});
            this.dgvCus.GridColor = System.Drawing.Color.White;
            this.dgvCus.Location = new System.Drawing.Point(21, 16);
            this.dgvCus.Name = "dgvCus";
            this.dgvCus.RowHeadersWidth = 51;
            this.dgvCus.RowTemplate.Height = 24;
            this.dgvCus.Size = new System.Drawing.Size(947, 605);
            this.dgvCus.TabIndex = 5;
            this.dgvCus.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCus_CellMouseDoubleClick);
            // 
            // CID
            // 
            this.CID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CID.HeaderText = "Customer ID";
            this.CID.MinimumWidth = 6;
            this.CID.Name = "CID";
            this.CID.Width = 105;
            // 
            // CName
            // 
            this.CName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CName.HeaderText = "Customer Name";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            // 
            // CTell
            // 
            this.CTell.HeaderText = "Telephone";
            this.CTell.MinimumWidth = 6;
            this.CTell.Name = "CTell";
            this.CTell.Width = 125;
            // 
            // CAddress
            // 
            this.CAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CAddress.HeaderText = "Address";
            this.CAddress.MinimumWidth = 6;
            this.CAddress.Name = "CAddress";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.dgvCus);
            this.panel2.Location = new System.Drawing.Point(499, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 639);
            this.panel2.TabIndex = 7;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(1587, 923);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCusUpdate;
        private System.Windows.Forms.Button btnCusDelete;
        private System.Windows.Forms.Button btnCrefresh;
        private System.Windows.Forms.Button btnCadd;
        private System.Windows.Forms.TextBox txtCaddress;
        private System.Windows.Forms.TextBox txtCtell;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label lblCusId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTell;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAddress;
        private System.Windows.Forms.Panel panel2;
    }
}
