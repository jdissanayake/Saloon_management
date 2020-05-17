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
    public partial class Attendence : UserControl
    {
        //create new conection object as connection
        MySqlConnection con;
        private string att;

        public Attendence()
        {
            InitializeComponent();
            //initialize conection string from variable class
            con = new MySqlConnection(Variable.conString);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Attendence_Load(object sender, EventArgs e)
        {
           

            lblAttendenceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtAttDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
            String qur = "SELECT attendence.Date, attendence.Eid, employee.Ename, attendence.PA FROM attendence INNER JOIN employee  ON attendence.Eid = employee.eid";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAttendenceeDisplay.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(),dr[2].ToString(), dr[3].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAttendenceeDisplay.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }







            String aqur = "SELECT  eid,  Ename FROM employee;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(aqur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAttendence.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAttendence.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvAttendence_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //---------------------------------------------MANAGE LIBRARIAN DATAGRID VIEW DOUBLE CLICK-------------------------------------------------------------------------------------------------


            // this is function which get data when Double click cell in Manage LIBRARIAN DataGridView------------------------------------------------------------------------------------------------------------------

            //get Datagrid view silected row number---------------------------------------------------GET SELECTED ROW---------------------------------------------------------------
            int row = dgvAttendence.CurrentRow.Index;

            //Disable Add button
            //btnAdd.Enabled = false;
            //Enable Remove button and Update Button-------------------------------------------ENABLE REMVE AND UPDATE-----------------------------------------------------------------------
            //btnEdelete.Enabled = true;
            // btnEupdate.Enabled = true;

            //Disable Book number Text box-----------------------------------------------------------------DISABLE ADD BUTTON-------------------------------------------------
            // txtLbUname.Enabled = false;

            //Get values From datagrid View -----------------------------------------------------FILL VALUES FROM DATAGRIDVIEW-------------------------------------------------------------------------------
            lblAEid.Text = dgvAttendence.Rows[row].Cells[0].Value.ToString();
            lblAEname.Text = dgvAttendence.Rows[row].Cells[1].Value.ToString();

        }

        private void btnAddAttendence_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                if(Pcheck.Checked == true )
                {
                    att = "Pracence";
                }
                else if (Acheck.Checked == true)
                {
                    att = "Abcence";
                }

                // create new sql command as cmd
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO attendence (Date ,Eid ,PA)VALUES('" + lblAttendenceDate.Text + "', '" + lblAEid.Text + "', '" + att+ "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");



                con.Close();

                lblAEid.Text = "";
                lblAEname.Text = "";
                Pcheck.Checked = false;
                Acheck.Checked = false;


            }
            catch
            {
                MessageBox.Show("Employee Alredy registered");
            }






            String qur = "SELECT attendence.Date, attendence.Eid, employee.Ename, attendence.PA FROM attendence INNER JOIN employee  ON attendence.Eid = employee.eid";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAttendenceeDisplay.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAttendenceeDisplay.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void dgvAttendence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAttendenceRefresh_Click(object sender, EventArgs e)
        {
            lblAttendenceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtAttDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            String qur = "SELECT attendence.Date, attendence.Eid, employee.Ename, attendence.PA FROM attendence INNER JOIN employee  ON attendence.Eid = employee.eid";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAttendenceeDisplay.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAttendenceeDisplay.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }






            String aqur = "SELECT  eid,  Ename FROM employee;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(aqur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAttendence.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAttendence.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // search date//

            String qur = "SELECT attendence.Date, attendence.Eid, employee.Ename, attendence.PA FROM attendence INNER JOIN employee ON attendence.Eid = employee.eid WHERE attendence.Date='"+txtAttDate.Text+"';   ";


            try
            {

                con.Open();

               

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAttSearch.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAttSearch.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void Pcheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

           
                txtAttDate.Enabled = true;
                txtAtt.Enabled = false;


        }

        private void rbtnEid_CheckedChanged(object sender, EventArgs e)
        {
            
                txtAtt.Enabled = true; 
                txtAttDate.Enabled = false;
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            String qur = "SELECT attendence.Date, attendence.Eid, employee.Ename, attendence.PA FROM attendence INNER JOIN employee ON attendence.Eid = employee.eid WHERE employee.eid='" + txtAtt.Text + "'   ";


            try
            {

                con.Open();



                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAttSearch.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAttSearch.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void lblAttendenceDate_Click(object sender, EventArgs e)
        {

        }
    }
}
