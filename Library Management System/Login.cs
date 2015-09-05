using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string myConnection = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\rusha\\Documents\\Visual Studio 2015\\Projects\\Library Management System\\Library Management System\\LibTest.mdf\"; Integrated Security = True";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = myConnection;   //database connects here
               
                con.Open();
                string command = "select [Username][Password] from [User] where [Username] = '" + textBox1.Text + "'AND[Password] = '" + textBox2.Text + "'";
                MessageBox.Show(command);
                SqlCommand cmd = new SqlCommand(command,con);
                SqlDataReader sdr = cmd.ExecuteReader();
                int count = 0;
                while (sdr.Read())
                { count++; }
                if (count == 1)
                {
                    MessageBox.Show("Access Granted");
                    this.Close();
                    Search_User main_ui = new Search_User();
                    main_ui.Show();
                }
                else { MessageBox.Show("Wrong Username or Password."); }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
