using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add some libr here
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BahrainBank
{
    public partial class Main : Form
    {
        public Main(string username1)
        {

            InitializeComponent();
            label_firstNameInPage.Text = username1;


        }
        dbControl sql = new dbControl();
        
  
        private void Main_Load(object sender, EventArgs e)
        {
            

        }

        private void label_firstNameInPage_Click(object sender, EventArgs e)
        {
            
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label_CurrentBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
