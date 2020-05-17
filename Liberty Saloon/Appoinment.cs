using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Liberty_Saloon
{
    public partial class Appoinment : UserControl
    {

        //create new conection object as connection
        MySqlConnection con;

        public Appoinment()
        {
            InitializeComponent();

            //initialize conection string from variable class
            con = new MySqlConnection(Variable.conString);

        }

        private void Appoinment_Load(object sender, EventArgs e)
        {
            txtAtime.Text = DateTime.Now.ToString("hh:mm tt"); //result 11:11:45 PM
             txtAppDate.Text= DateTime.Now.ToString(" dd-MM-yyyy");


            String qur = "SELECT eid, Ename FROM employee;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAppointmentE.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAppointmentE.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }






            String returnqur = "SELECT Cid, Name FROM customer;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(returnqur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAppoinmentC.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAppoinmentC.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }








            String qrqur = "SELECT Aid, date,time, Cid, Eid, Payment FROM appointment;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qrqur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvApp.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvApp.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvAppointmentE_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //---------------------------------------------MANAGE LIBRARIAN DATAGRID VIEW DOUBLE CLICK-------------------------------------------------------------------------------------------------


            // this is function which get data when Double click cell in Manage LIBRARIAN DataGridView------------------------------------------------------------------------------------------------------------------

            //get Datagrid view silected row number---------------------------------------------------GET SELECTED ROW---------------------------------------------------------------
            int row = dgvAppointmentE.CurrentRow.Index;

            //Disable Add button
            //btnAdd.Enabled = false;
            //Enable Remove button and Update Button-------------------------------------------ENABLE REMVE AND UPDATE-----------------------------------------------------------------------
            btnAppDelete.Enabled = false;
            btnAppUpdate.Enabled = false;

            //Disable Book number Text box-----------------------------------------------------------------DISABLE ADD BUTTON-------------------------------------------------
            // txtLbUname.Enabled = false;

            //Get values From datagrid View -----------------------------------------------------FILL VALUES FROM DATAGRIDVIEW-------------------------------------------------------------------------------
            lblAppEid.Text = dgvAppointmentE.Rows[row].Cells[0].Value.ToString();
            
        }

        private void dgvAppoinmentC_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //---------------------------------------------MANAGE LIBRARIAN DATAGRID VIEW DOUBLE CLICK-------------------------------------------------------------------------------------------------


            // this is function which get data when Double click cell in Manage LIBRARIAN DataGridView------------------------------------------------------------------------------------------------------------------

            //get Datagrid view silected row number---------------------------------------------------GET SELECTED ROW---------------------------------------------------------------
            int row = dgvAppoinmentC.CurrentRow.Index;

            //Disable Add button
            //btnAdd.Enabled = false;
            //Enable Remove button and Update Button-------------------------------------------ENABLE REMVE AND UPDATE-----------------------------------------------------------------------
            btnAppDelete.Enabled = false;
            btnAppUpdate.Enabled = false;

            //Disable Book number Text box-----------------------------------------------------------------DISABLE ADD BUTTON-------------------------------------------------
            // txtLbUname.Enabled = false;

            //Get values From datagrid View -----------------------------------------------------FILL VALUES FROM DATAGRIDVIEW-------------------------------------------------------------------------------
            lblAppCid.Text = dgvAppoinmentC.Rows[row].Cells[0].Value.ToString();
        }

        private void btnAppAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // create new sql command as cmd
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO appointment ( date ,Cid ,Eid ,Payment ,Time)VALUES('" + txtAppDate.Text + "','" + lblAppCid.Text + "','" + lblAppEid.Text + "','" + txtApayment.Text + "','" + txtAtime.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");



                con.Close();

                lblAppEid.Text = "";
                lblAppCid.Text = "";
                txtAppDate.Text = "";
                txtAtime.Text = "";
                txtApayment.Text = "";

            }
            catch
            {
                MessageBox.Show("Employee Alredy registered");
            }

            //refresh

            lblAppEid.Text = "";
            lblAppCid.Text = "";
            txtAppDate.Text = "";
            txtAtime.Text = "";
            txtApayment.Text = "";


            txtAtime.Text = DateTime.Now.ToString("hh:mm tt"); //result 11:11:45 PM
            txtAppDate.Text = DateTime.Now.ToString(" dd-MM-yyyy");



            String qur = "SELECT eid, Ename FROM employee";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAppointmentE.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAppointmentE.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }






            String returnqur = "SELECT Cid, Name FROM customer;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(returnqur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAppoinmentC.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAppoinmentC.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }





            String qrqur = "SELECT Aid, date,time, Cid, Eid, Payment FROM appointment;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qrqur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvApp.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvApp.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnAppRefresh_Click(object sender, EventArgs e)
        {
            lblAppEid.Text = "";
            lblAppCid.Text = "";
            txtAppDate.Text = "";
            txtAtime.Text = "";
            txtApayment.Text = "";


            txtAtime.Text = DateTime.Now.ToString("hh:mm tt"); //result 11:11:45 PM
            txtAppDate.Text = DateTime.Now.ToString(" dd-MM-yyyy");



            String qur = "SELECT eid, Ename FROM employee";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAppointmentE.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAppointmentE.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }






            String returnqur = "SELECT Cid, Name FROM customer;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(returnqur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAppoinmentC.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAppoinmentC.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }





            String qrqur = "SELECT Aid, date,time, Cid, Eid, Payment FROM appointment;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qrqur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvApp.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvApp.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnAppDelete_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                //sql query only sellect name 
                // which mach to username and password
                String abQur = "DELETE FROM appointment WHERE Aid = '"+ lblAid .Text+ "' ;   ";

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

                    MessageBox.Show("Appoinment Remove sucess..");

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

        private void dgvAppoinmentC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvApp_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //---------------------------------------------MANAGE LIBRARIAN DATAGRID VIEW DOUBLE CLICK-------------------------------------------------------------------------------------------------


            // this is function which get data when Double click cell in Manage LIBRARIAN DataGridView------------------------------------------------------------------------------------------------------------------

            //get Datagrid view silected row number---------------------------------------------------GET SELECTED ROW---------------------------------------------------------------
            int row = dgvApp.CurrentRow.Index;

            //Disable Add button
            //btnAppAdd.Enabled = false;
            //Enable Remove button and Update Button-------------------------------------------ENABLE REMVE AND UPDATE-----------------------------------------------------------------------
            btnAppDelete.Enabled = true;
            btnAppUpdate.Enabled = true;

            //Disable Book number Text box-----------------------------------------------------------------DISABLE ADD BUTTON-------------------------------------------------
            // txtLbUname.Enabled = false;

            //Get values From datagrid View -----------------------------------------------------FILL VALUES FROM DATAGRIDVIEW-------------------------------------------------------------------------------
            lblAid.Text = dgvApp.Rows[row].Cells[0].Value.ToString();
            txtAppDate.Text = dgvApp.Rows[row].Cells[1].Value.ToString();
            txtAtime.Text = dgvApp.Rows[row].Cells[2].Value.ToString();
            lblAppCid.Text = dgvApp.Rows[row].Cells[3].Value.ToString();
            lblAppEid.Text = dgvApp.Rows[row].Cells[4].Value.ToString();
            txtApayment.Text = dgvApp.Rows[row].Cells[5].Value.ToString();


        }

        private void btnAppUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCadd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // create new sql command as cmd
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO customer ( Name ,TellNo ,Address) VALUES('" + txtCname.Text + "','" + txtCtell.Text + "','" + txtCaddress.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");



                con.Close();

                txtCname.Text = "";
                txtCtell.Text = "";
                txtCaddress.Text = "";


            }
            catch
            {
                MessageBox.Show("Customer Alredy registered");
            }
        }
    }
}
