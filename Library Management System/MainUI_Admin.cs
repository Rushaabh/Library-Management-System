using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class MainUI_Admin : Form
    {
        public MainUI_Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Book ab = new Add_Book();
            ab.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search sr = new Search();
            sr.Show();
        }
    }
}
