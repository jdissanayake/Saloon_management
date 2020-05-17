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
    public partial class Payment : UserControl
    {
        //create new conection object as connection
        MySqlConnection con;

        public Payment()
        {
            InitializeComponent();

            //initialize conection string from variable class
            con = new MySqlConnection(Variable.conString);
        }

        private void Payment_Load(object sender, EventArgs e)
        {

            String qrqurp = "SELECT Aid, date,time, Cid, Eid, Payment FROM appointment;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qrqurp, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAppP.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAppP.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }



            String qr = "SELECT Pid, Cid, Eid, date, price, Payment FROM payment;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qr, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvPay.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvPay.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvAppP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //---------------------------------------------MANAGE LIBRARIAN DATAGRID VIEW DOUBLE CLICK-------------------------------------------------------------------------------------------------


            // this is function which get data when Double click cell in Manage LIBRARIAN DataGridView------------------------------------------------------------------------------------------------------------------

            //get Datagrid view silected row number---------------------------------------------------GET SELECTED ROW---------------------------------------------------------------
            int row = dgvAppP.CurrentRow.Index;

            //Disable Add button
            //btnAppAdd.Enabled = false;
            //Enable Remove button and Update Button-------------------------------------------ENABLE REMVE AND UPDATE-----------------------------------------------------------------------
            btnAppDelete.Enabled = true;
            btnAppUpdate.Enabled = true;

            //Disable Book number Text box-----------------------------------------------------------------DISABLE ADD BUTTON-------------------------------------------------
            // txtLbUname.Enabled = false;

            //Get values From datagrid View -----------------------------------------------------FILL VALUES FROM DATAGRIDVIEW-------------------------------------------------------------------------------
            lblAid.Text = dgvAppP.Rows[row].Cells[0].Value.ToString();
            txtAppDate.Text = dgvAppP.Rows[row].Cells[1].Value.ToString();
            txtAtime.Text = dgvAppP.Rows[row].Cells[2].Value.ToString();
            lblAppCid.Text = dgvAppP.Rows[row].Cells[3].Value.ToString();
            lblAppEid.Text = dgvAppP.Rows[row].Cells[4].Value.ToString();
            txtApayment.Text = dgvAppP.Rows[row].Cells[5].Value.ToString();
        }

        private void btnAppAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // create new sql command as cmd
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO payment (Date, Cid ,Eid , Payment, price )VALUES('" + txtAppDate.Text + "','" + lblAppCid.Text + "','" + lblAppEid.Text + "','" + txtPf.Text + "','" + txtprice.Text + "')";
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


            try
            {

                con.Open();

                //sql query only sellect name 
                // which mach to username and password
                String abcQur = "DELETE FROM appointment WHERE Aid = '" + lblAid.Text + "' ;";

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

        private void dgvAppP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAppDelete_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                //sql query only sellect name 
                // which mach to username and password
                String abcQur = "DELETE FROM appointment WHERE Aid = '"+ lblAid .Text+ "' ;";

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

        private void btnAppRefresh_Click(object sender, EventArgs e)
        {
            String qrqurp = "SELECT Aid, date,time, Cid, Eid, Payment FROM appointment;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qrqurp, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvAppP.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvAppP.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }


            String qr = "SELECT Pid, Cid, Eid, date, price, Payment FROM payment;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qr, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvPay.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvPay.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPf.Text = (float.Parse(txtprice.Text) - float.Parse(txtApayment.Text)).ToString();
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Esalary newForm = new Esalary();
            newForm.Show();
            
        }
    }
}