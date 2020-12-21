using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BahrainBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Connect to our Class dbControl
        dbControl sql = new dbControl();

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            Hide();
            rf.ShowDialog();
          }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            
            //We created a Class called Login and we will asgin it here
            if (Login() == true)
            {
                Main m = new Main(textBox_UserName.Text);
                Hide();
                m.ShowDialog();
            }
        }
        //Class of type bool for login button
        bool Login()
            {
                sql.Param("@UserName", textBox_UserName.Text);
                sql.Param("@Password", textBox_Password.Text);
                //query to check if the username and password is valid
                sql.query("select count(*) from tbl_Customer where UserName=@UserName and Password=@Password");
                if ((int)sql.dt.Rows[0][0] == 1)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Check your information or conact us: 5466-4344");
                    return false;
                }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox_UserName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
