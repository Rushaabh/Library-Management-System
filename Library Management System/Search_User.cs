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
    public partial class Search_User : Form
    {
        public string emp;
        SqlDataAdapter sda;
        DataTable dt;
        SqlConnection con;
        public Search_User()
        {
            string myConnection = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\rusha\\Documents\\Visual Studio 2015\\Projects\\Library Management System\\Library Management System\\LibTest.mdf\"; Integrated Security = True";
            con = new SqlConnection();
            con.ConnectionString = myConnection;   //database connects here
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            string Command = " SELECT * FROM Books";

            sda = new SqlDataAdapter(Command, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string Command = "";
            if (Title.Text != "")
            {
                Command = " SELECT * FROM Books WHERE [Title]  =  '" + Title.Text + "' ";
            }
            else if (Author.Text != "")
            {
                Command = " SELECT * FROM Books WHERE [Author] =  '" + Author.Text + "' ";
            }

            sda = new SqlDataAdapter(Command, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_User_Load(object sender, EventArgs e)
        {

        }
    }
}
