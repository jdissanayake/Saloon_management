using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Liberty_Saloon
{
    public partial class Esalary : Form
    {
        //create new conection object as connection
        MySqlConnection con;

        public Esalary()
        {

            InitializeComponent();

            //initialize conection string from variable class
            con = new MySqlConnection(Variable.conString);
        }

        private void Esalary_Load(object sender, EventArgs e)
        {
            txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            String qr = "SELECT Pid, Eid, date, price FROM payment;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qr, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                EmpSal.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    EmpSal.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }


            String qur = "SELECT  eid,  Ename FROM employee";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvEmpID.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvEmpID.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvEmpID_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //---------------------------------------------MANAGE LIBRARIAN DATAGRID VIEW DOUBLE CLICK-------------------------------------------------------------------------------------------------


            // this is function which get data when Double click cell in Manage LIBRARIAN DataGridView------------------------------------------------------------------------------------------------------------------

            //get Datagrid view silected row number---------------------------------------------------GET SELECTED ROW---------------------------------------------------------------
            int row = dgvEmpID.CurrentRow.Index;

            //Disable Add button
            // btnAdd.Enabled = false;
            //Enable Remove button and Update Button-------------------------------------------ENABLE REMVE AND UPDATE-----------------------------------------------------------------------
            //btnEdelete.Enabled = true;
            // btnEupdate.Enabled = true;

            //Disable Book number Text box-----------------------------------------------------------------DISABLE ADD BUTTON-------------------------------------------------
            // txtLbUname.Enabled = false;

            //Get values From datagrid View -----------------------------------------------------FILL VALUES FROM DATAGRIDVIEW-------------------------------------------------------------------------------
            txtSei.Text = dgvEmpID.Rows[row].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String qr = "SELECT  Pid,  Eid,  date,  price FROM payment WHERE Eid = '" + txtSei.Text + "';";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qr, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                EmpSal.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    EmpSal.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String qr = "SELECT  Pid,  Eid,  date,  price FROM payment WHERE Date = '" + txtdate.Text + "';";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qr, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                EmpSal.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    EmpSal.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
