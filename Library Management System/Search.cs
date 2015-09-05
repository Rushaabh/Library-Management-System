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
    public partial class Search : Form
    {
        public string emp;
        SqlDataAdapter sda;
        DataTable dt;
        SqlConnection con;
        public Search()
        {
            string myConnection = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\rusha\\Documents\\Visual Studio 2015\\Projects\\Library Management System\\Library Management System\\LibTest.mdf\"; Integrated Security = True";
            con = new SqlConnection();
            con.ConnectionString = myConnection;   //database connects here
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Command = " SELECT * FROM Books";
           
            sda = new SqlDataAdapter(Command,con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Command = "";
            if (textBox1.Text != "")  
            {
                Command = " SELECT * FROM Books WHERE [Title]  =  '" + textBox1.Text + "' ";
            }
            else if(textBox2.Text != "")
            {
                Command = " SELECT * FROM Books WHERE [Author] =  '" + textBox2.Text + "' ";
            }

            sda = new SqlDataAdapter(Command, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            int index= dataGridView1.CurrentRow.Index;

            row.Cells[4].Value = false;
            

         }

        private void Return_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            int index = dataGridView1.CurrentRow.Index;
            row.Cells[4].Value = true;
        }
    }
}
