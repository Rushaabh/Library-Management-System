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

namespace Library_Management_System
{
    public partial class A_login : Form
    {
        public A_login()
        {
            InitializeComponent();
            textBox2.PasswordChar = 'X';
        }

        private void A_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string myConnection = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\rusha\\Documents\\Visual Studio 2015\\Projects\\Library Management System\\Library Management System\\LibTest.mdf\"; Integrated Security = True";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = myConnection;   //database connects here
                // string command = "insert into [User]([Id],[Username],[Password]) values(" +(i++)+",\'"+ textBox1.Text +"\',\'" + textBox2.Text + "\')"  ;
                con.Open();
                string command = "select [Admin_Id][Admin_Name] from [Librarian] where [Admin_Id] = '" + textBox1.Text + "'AND [Admin_Pass] = '" + textBox2.Text + "'";
                MessageBox.Show(command);
                SqlCommand cmd = new SqlCommand(command, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                int count = 0;
                while (sdr.Read())
                { count++; }
                if (count == 1)
                {
                    MessageBox.Show("Access Granted");
                    this.Close();
                    MainUI_Admin main_ui = new MainUI_Admin();
                    main_ui.Show();
                }
                else { MessageBox.Show("Invalid Username Or Password"); }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
