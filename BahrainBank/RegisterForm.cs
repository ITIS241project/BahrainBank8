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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        //Connect the class dbControl in our form
        dbControl sql = new dbControl();
        //create class for register
        void register()
        {
            sql.Param("@UserName", textBox_UserName.Text);
            sql.Param("@FirstName", textBox_FirstName.Text);
            sql.Param("@LastName", textBox_LastName.Text);
            sql.Param("@Age", textBox_Age.Text);
            sql.Param("@PhoneNumber", textBox_PhoneNumber.Text);
            sql.Param("@Gender", comboBox_gender.Text);
            sql.Param("@Password", textBox_Password.Text);
            sql.Param("@Job", textBox_Job.Text);
            //create a query string to insert data into our table
            //sql.query("insert into tbl_Customer (UserName,FirstName,LastName,Age,PhoneNumber,Gender,Password,Job) values (@UserName,@FirstName,@LastName,@Age,@PhoneNumber,@Gender,@Password,@Job)");
            if (sql.Check4error(true))
            {
                return;
            }
            //We assign random number to card number for new customer
            Random rand = new Random();
            int x = rand.Next(1000000,8000000);
            DialogResult ans;
            ans=MessageBox.Show("You are Registered in our bank"+"\n"+"Your card Number is : "+x,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            sql.Param("@CardNumber", x);
            //create a query string to insert data into our table
            sql.query("insert into tbl_Customer (UserName,FirstName,LastName,Age,PhoneNumber,Gender,Password,Job,CardNumber) values (@UserName,@FirstName,@LastName,@Age,@PhoneNumber,@Gender,@Password,@Job,@CardNumber)");
            
            if (DialogResult.OK == ans)
            {
                Main m = new Main(textBox_UserName.Text);
                Hide();
                m.Show();
            }
        }

        private void button_register2_Click(object sender, EventArgs e)
        {
            // We will put register Class here 
            register();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
