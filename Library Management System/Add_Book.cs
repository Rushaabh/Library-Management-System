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
    public partial class Add_Book : Form
    {
        public string emp;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        SqlConnection con;
        public Add_Book()
        {
            string myConnection = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\rusha\\Documents\\Visual Studio 2015\\Projects\\Library Management System\\Library Management System\\LibTest.mdf\"; Integrated Security = True";
            con = new SqlConnection();
            con.ConnectionString = myConnection;   //database connects here
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Command = " SELECT * FROM Books";

            sda = new SqlDataAdapter(Command, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}