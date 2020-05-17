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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // create mysql connection 
            // connection variable get from variable class in bottem of loging form
            MySqlConnection con = new MySqlConnection(Variable.conString);


            try
            {

                con.Open();

                //sql query only sellect name 
                // which mach to username and password
                String usrQur = "SELECT Priviladge FROM user WHERE  UserName='" + txtUID.Text + "' AND Password='" + txtpswrd.Text + "'";

                //create new mysql command
                MySqlCommand cmd = new MySqlCommand();

                //add connection to mysql command
                cmd.Connection = con;

                //ass query to mysql command
                cmd.CommandText = usrQur;

                //create new data reader and initialize it using cmd executed result
                MySqlDataReader dr = cmd.ExecuteReader();

                String priv = "";

                //read data reader data line by line
                // if query dont have any data this loop naver run 
                while (dr.Read())
                {
                    priv = dr[0].ToString();

                }

                MessageBox.Show(priv);
                //check user is available in the database
                if (priv == "Admin")
                {

                    MessageBox.Show("Loging Success");

                    //if there is 1 row in datareader  show dashboard
                    DashBoard newForm = new DashBoard();
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalied credintial..!");

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, Color.White);
        }
    }

    public class Variable
    {

        public static String conString = "SERVER=localhost;DATABASE=saloon managemnet;UID=root;";

        public static String UName = "null";
        public static String UID = "null";
    }
}
