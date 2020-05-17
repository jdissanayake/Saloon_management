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
    public partial class Customer : UserControl
    {
        //create new conection object as connection
        MySqlConnection con;


        public Customer()
        {
            InitializeComponent();

            //initialize conection string from variable class
            con = new MySqlConnection(Variable.conString);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            String qur = "SELECT * FROM customer";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvCus.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvCus.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
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




            //-----------Refresh After Click Add Button------------------//
            String qur = "SELECT * FROM customer";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvCus.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvCus.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnCrefresh_Click(object sender, EventArgs e)
        {

            lblCusId.Text = txtCname.Text = txtCaddress.Text = txtCtell.Text = "";

            btnCadd.Enabled = true;
            String qur = "SELECT * FROM customer";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvCus.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvCus.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvCus_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //---------------------------------------------MANAGE LIBRARIAN DATAGRID VIEW DOUBLE CLICK-------------------------------------------------------------------------------------------------


            // this is function which get data when Double click cell in Manage LIBRARIAN DataGridView------------------------------------------------------------------------------------------------------------------

            //get Datagrid view silected row number---------------------------------------------------GET SELECTED ROW---------------------------------------------------------------
            int row = dgvCus.CurrentRow.Index;

            //Disable Add button
            btnCadd.Enabled = false;
            //Enable Remove button and Update Button-------------------------------------------ENABLE REMVE AND UPDATE-----------------------------------------------------------------------
            btnCusDelete.Enabled = true;
            btnCusUpdate.Enabled = true;

            //Disable Book number Text box-----------------------------------------------------------------DISABLE ADD BUTTON-------------------------------------------------
            txtCname.Enabled = false;

            //Get values From datagrid View -----------------------------------------------------FILL VALUES FROM DATAGRIDVIEW-------------------------------------------------------------------------------
            lblCusId.Text = dgvCus.Rows[row].Cells[0].Value.ToString();
            txtCname.Text = dgvCus.Rows[row].Cells[1].Value.ToString();
            txtCtell.Text = dgvCus.Rows[row].Cells[2].Value.ToString();
            txtCaddress.Text = dgvCus.Rows[row].Cells[3].Value.ToString();
        }

        private void btnCusDelete_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                //sql query only sellect name 
                // which mach to username and password
                String abcQur = " DELETE appointment.*, customer.* FROM appointment INNER JOIN customer ON appointment.Cid = customer.Cid WHERE appointment.Cid='"+lblCusId.Text+"'   ";

                //create new mysql command
                MySqlCommand cmd = new MySqlCommand
                {

                    //add connection to mysql command
                    Connection = con,

                    //ass query to mysql command
                    CommandText = abcQur
                };

                //execute querry
                int p = cmd.ExecuteNonQuery();

                if (p > 0)
                {

                    MessageBox.Show("Customer Remove sucess..");

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

        private void btnCusUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();

                //sql query only sellect name 
                // which mach to username and password
                String abQur = abQur = "UPDATE customer SET Name = '"+txtCname.Text+"'  ,TellNo = '"+txtCtell.Text+"'  ,Address = '"+txtCaddress.Text+"'  WHERE Cid = '"+lblCusId.Text+"'      ";

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

                    MessageBox.Show("Customer Update sucess..");

                }
                else
                {
                    MessageBox.Show("Customer Update fail..");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
