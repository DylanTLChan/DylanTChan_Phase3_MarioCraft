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
        GAMEUSER gu = new GAMEUSER();

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

          /*if(txtEmail.Text.Equals(gu.USEREMAIL) && txtPassword.Text.Equals(gu.USERPASSWORD))
           {
               MessageBox.Show("Successful Login", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
           }*/

            if(!txtEmail.Text.Equals(gu.USEREMAIL) && !txtPassword.Text.Equals(gu.USERPASSWORD))
            {
                MessageBox.Show("Please enter correct email and password ", "Incorrect Details",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            else
            {
                MessageBox.Show("Successful Login", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
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
