using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace Liberty_Saloon
{
    public partial class Employee : UserControl
    {

        //create new conection object as connection
        MySqlConnection con;


        public Employee()
        {
            InitializeComponent();
            //initialize conection string from variable class
            con = new MySqlConnection(Variable.conString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // create new sql command as cmd
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO employee(Ename,address,tellNo,dob,nicNo)VALUES('" + txtEname.Text + "','" + txtEaddress.Text + "','" + txtEtellno.Text + "','" + dtpE.Value.ToString("dd/MM/yyyy") + "','" + txtEnic.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");



                con.Close();

                txtEname.Text = "";
                txtEaddress.Text = "";
                txtEtellno.Text = "";
                dtpE.Text = "";
                txtEnic.Text = "";

            }
            catch
            {
                MessageBox.Show("Employee Alredy registered");
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            String qur = "SELECT * FROM employee";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvE.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvE.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvE_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //---------------------------------------------MANAGE LIBRARIAN DATAGRID VIEW DOUBLE CLICK-------------------------------------------------------------------------------------------------


            // this is function which get data when Double click cell in Manage LIBRARIAN DataGridView------------------------------------------------------------------------------------------------------------------

            //get Datagrid view silected row number---------------------------------------------------GET SELECTED ROW---------------------------------------------------------------
            int row = dgvE.CurrentRow.Index;

            //Disable Add button
            btnAdd.Enabled = false;
            //Enable Remove button and Update Button-------------------------------------------ENABLE REMVE AND UPDATE-----------------------------------------------------------------------
            btnEdelete.Enabled = true;
            btnEupdate.Enabled = true;

            //Disable Book number Text box-----------------------------------------------------------------DISABLE ADD BUTTON-------------------------------------------------
            // txtLbUname.Enabled = false;

            //Get values From datagrid View -----------------------------------------------------FILL VALUES FROM DATAGRIDVIEW-------------------------------------------------------------------------------
            lblEid.Text = dgvE.Rows[row].Cells[0].Value.ToString();
            txtEname.Text = dgvE.Rows[row].Cells[1].Value.ToString();
            txtEaddress.Text = dgvE.Rows[row].Cells[2].Value.ToString();
            txtEtellno.Text = dgvE.Rows[row].Cells[3].Value.ToString();
            txtEnic.Text = dgvE.Rows[row].Cells[5].Value.ToString();
        }

        private void dgvE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEaddress.Text = txtEtellno.Text = txtEname.Text = txtEnic.Text = lblEid.Text = "";

            btnAdd.Enabled = true;

            String qur = "SELECT * FROM employee";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvE.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvE.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnEdelete_Click(object sender, EventArgs e)
        {
           
                try
                {

                    con.Open();

                    //sql query only sellect name 
                    // which mach to username and password
                    String abQur = "DELETE employee.*, attendence.* FROM attendence INNER JOIN employee ON attendence.Eid = employee.eid WHERE attendence.eid='" + lblEid.Text + "'   ";

                    //create new mysql command
                    MySqlCommand cmd = new MySqlCommand
                    {

                        //add connection to mysql command
                        Connection = con,

                        //ass query to mysql command
                        CommandText = abQur
                    };

                    //execute querry
                    int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {

                    MessageBox.Show("Employee Remove sucess..");

                }
                else
                {
                    MessageBox.Show("error");
                }
                

                    con.Close();


                }
                catch (MySqlException ex)
                {
                    //if any error in database this part execute
                    //message box display that error
                   MessageBox.Show(ex.ToString());

                }
            
           
            

        }

        private void btnEupdate_Click(object sender, EventArgs e)
        {

            try
             {

            con.Open();

            //sql query only sellect name 
            // which mach to username and password
            String abQur = abQur = "UPDATE employee SET Ename = '" + txtEname.Text + "' ,address = '" + txtEaddress.Text + "'  ,tellNo = '" + txtEtellno.Text + "'  ,dob = " + dtpE.Value.ToString("dd / MM / yyyy") + "  ,nicNo = '" + txtEnic.Text + "' WHERE eid = '" + lblEid.Text + "'";

            //create new mysql command
            MySqlCommand cmd = new MySqlCommand
            {

                //add connection to mysql command
                Connection = con,

                //ass query to mysql command
                CommandText = abQur
            };

            //execute querry
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {

                MessageBox.Show("Member Update sucess..");

            }
            else
            {
                MessageBox.Show("Member Update fail..");
            }

            con.Close();


             }
             catch (MySqlException ex)
            {
            //if any error in database this part execute
            //message box display that error
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblEid_Click(object sender, EventArgs e)
        {

        }

        private void dtpE_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
