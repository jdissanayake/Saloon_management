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
    public partial class Home : UserControl
    {
        //create new conection object as connection
        MySqlConnection con;
       

        public Home()
        {
            InitializeComponent();
            //initialize conection string from variable class
            con = new MySqlConnection(Variable.conString);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            


            String count = "SELECT (SELECT COUNT(*)FROM employee)AS employeeCount";

            try
            {

                con.Open();

                MySqlCommand countcmd = new MySqlCommand(count, con);

                MySqlDataReader countdr = countcmd.ExecuteReader();

                // dgvAddBook.Rows.Clear();

                while (countdr.Read())
                {
                    lblEcount.Text = countdr["employeeCount"].ToString();



                }


                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }





            String acount = "SELECT (SELECT COUNT(*)FROM customer)AS customerCount";

            try
            {

                con.Open();

                MySqlCommand countcmd = new MySqlCommand(acount, con);

                MySqlDataReader countdr = countcmd.ExecuteReader();

                // dgvAddBook.Rows.Clear();

                while (countdr.Read())
                {
                    lblCusCount.Text = countdr["customerCount"].ToString();



                }


                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            String apcount = "SELECT (SELECT COUNT(*)FROM appointment)AS appointmentCount";

            try
            {

                con.Open();

                MySqlCommand countcmd = new MySqlCommand(apcount, con);

                MySqlDataReader countdr = countcmd.ExecuteReader();

                // dgvAddBook.Rows.Clear();

                while (countdr.Read())
                {
                    lblAcount.Text = countdr["appointmentCount"].ToString();



                }


                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblAttendenceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String qur = "SELECT * FROM appointment ;";


            try
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvHome.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvHome.Rows.Add(row);

                }



                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dtpHome_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // search date//

            String qur = "SELECT  attendence.Eid, employee.Ename, attendence.PA FROM attendence INNER JOIN employee ON attendence.Eid = employee.eid WHERE attendence.Date='" + lblAttendenceDate.Text + "';   ";


            try
            {

                con.Open();



                MySqlCommand cmd = new MySqlCommand(qur, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                dgvTo.Rows.Clear();

                while (dr.Read())
                {


                    String[] row = { dr[0].ToString(), dr[1].ToString() };
                    //Array.ForEach(row,Console.WriteLine);



                    dgvTo.Rows.Add(row);

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
