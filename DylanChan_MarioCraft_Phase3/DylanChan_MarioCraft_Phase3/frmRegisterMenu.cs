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
    public partial class frmRegisterMenu : Form
    {
        private frmLoginMenu loginMenu;

       public frmRegisterMenu()
        {
            InitializeComponent();
           
        }

        public frmRegisterMenu(frmLoginMenu loginMenu)
       {
           InitializeComponent();
           this.loginMenu = loginMenu;
       }

        private void frmRegisterMenu_Load(object sender, EventArgs e)
        {
         
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            /*Model1 ctx = new Model1();
           var result = from gameUser in ctx.GAMEUSERs
                         where gameUser.USEREMAIL == "Khussey@gmail.com"
                         select gameUser;
            this.txtEmail.Text = result.First().USEREMAIL;

            var result1 = from gameUser in ctx.GAMEUSERs
                          where gameUser.USERPASSWORD == "K83hussey"
                          select gameUser;
            this.txtPassword.Text = result1.First().USERPASSWORD;*/

            if(txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Please Enter in a Email", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please Enter in a Password", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            using(var context = new Model1())
            {
                GAMEUSER newRegUser = new GAMEUSER()
                {
                    USEREMAIL = txtEmail.Text,
                    USERPASSWORD = txtPassword.Text
                };

                try
                {
                    var result = context.GAMEUSERs.Add(newRegUser);
                    context.SaveChanges();
                    MessageBox.Show(newRegUser.USEREMAIL + " " + newRegUser.USERPASSWORD +
                        "You have Successfully Registered","Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            
            //Confirmation Message
           // MessageBox.Show("Successfully registred", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Resets Textbox
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLoginMenu frmNext = new frmLoginMenu();
            this.Close();
            frmNext.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
