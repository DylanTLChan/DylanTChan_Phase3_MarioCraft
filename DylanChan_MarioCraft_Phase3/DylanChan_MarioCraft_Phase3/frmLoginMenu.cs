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
        //GAMEUSER gu = new GAMEUSER();
        Model1 context = new Model1();

        public frmLoginMenu()
        {
            InitializeComponent();
        }

        public frmLoginMenu(frmRegisterMenu frmRegisterMenu)
        {
            // TODO: Complete member initialization
            this.frmRegisterMenu = frmRegisterMenu;
        }

        private void frmLoginMenu_Load(object sender, EventArgs e)
        {

          
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

                try
                {
                    var gameUser = from u in context.GAMEUSERs where u.USEREMAIL == txtEmail.Text select u;

                    if (txtEmail.Text != gameUser.First().USEREMAIL)
                    {
                        MessageBox.Show("We cannot find an account with that Email address", "Incorrect Email",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Focus();
                        return;


                    }

                    else
                    {
                        MessageBox.Show("Successful Login", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



                //Reset Textbox
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmRegisterMenu back = new frmRegisterMenu(this);

            this.Close();
            back.Show();
        }
    }
}
