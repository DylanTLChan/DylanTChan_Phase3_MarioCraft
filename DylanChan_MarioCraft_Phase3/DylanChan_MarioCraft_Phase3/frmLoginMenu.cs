using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanChan_MarioCraft_Phase3
{
    public partial class frmLoginMenu : Form
    {
        private frmRegisterMenu frmRegisterMenu;
        Model1 context = new Model1();
        private frmGameUserMenu frmGameUserMenu;

        public frmLoginMenu()
        {
            InitializeComponent();
        }

        public frmLoginMenu(frmRegisterMenu frmRegisterMenu)
        {
       
            this.frmRegisterMenu = frmRegisterMenu;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        public frmLoginMenu(frmGameUserMenu frmGameUserMenu)
        {

            this.frmGameUserMenu = frmGameUserMenu;
 
        }
       
        private void frmLoginMenu_Load(object sender, EventArgs e)
        {
            //reference https://social.msdn.microsoft.com/Forums/vstudio/en-US/77a2ce66-65dd-4fb8-b252-7327b2e154be/hiding-the-password-in-a-textbox-with-c?forum=netfxbcl
            //hides password when user inputs in the password field.
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin(object sender, EventArgs e)
        {
           

            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Please enter Email", "Field Empty",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter password", "Field Empty",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

           
             var gameUser = from u in context.GAMEUSERs where u.USEREMAIL == txtEmail.Text select u;

             //This validates if gameuser's email is in the database
             var checkGameUser = gameUser.FirstOrDefault(a => a.USEREMAIL.Equals(txtEmail.Text));

             //if the email is not in the database 
             if (checkGameUser != null)
             {
                 //if the password is in the database  it will display successful dialog
                 if(checkGameUser.USERPASSWORD.Equals(txtPassword.Text))
                 {
                     MessageBox.Show("You have Successful logged in", "Login succesful",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                     //txtEmail.Text = "";
                    // txtPassword.Text = "";

                     frmGameUserMenu frmNext = new frmGameUserMenu(txtEmail.Text);//email that is inputed by user
                     this.Close();
                     frmNext.Show();

                 }

                 else
                 {    
                     //displays error message if password is not valid 
                     MessageBox.Show("Invalid Password,Please re-enter your password",
                                    "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                       txtPassword.Focus();
                                       return;
                 }
             }

             else
             {
                 //displays error message if Email is not valid 
                 MessageBox.Show("We cannot find an account with that Email address ,Please re-enter your Email ",
                 "Invalid Email address",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtEmail.Focus();
                 return;
             }



             txtPassword.UseSystemPasswordChar = true;
             
            }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmRegisterMenu back = new frmRegisterMenu(this);

            this.Close();
            back.Show();
        }

        private void radbtnShowPass_CheckedChanged(object sender, EventArgs e)
        {
           txtPassword.UseSystemPasswordChar = false;
        }

        private void radbtnHidePass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

       

       
    }
}
