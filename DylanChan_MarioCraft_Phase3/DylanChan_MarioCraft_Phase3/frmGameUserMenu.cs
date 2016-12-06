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
   
    public partial class frmGameUserMenu : Form
    {
        private frmLoginMenu frmLoginMenu;
        public frmGameUserMenu()
        {
            InitializeComponent();
        }

        private void GameUserMenu_Load(object sender, EventArgs e)
        {

        }

         public frmGameUserMenu(frmLoginMenu frmLoginMenu)
        {

            this.frmLoginMenu = frmLoginMenu;
 
        }


        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            //Retrieve 
            Model1 ctx = new Model1();
           var result = from gameUser in ctx.GAMEUSERs
                         where gameUser.USEREMAIL == "DylanChan@gmail.com"
                         select gameUser;
            this.txtEmail.Text = result.First().USEREMAIL;

            var result1 = from gameUser in ctx.GAMEUSERs
                          where gameUser.USERPASSWORD == "Dcqwer123"
                          select gameUser;
            this.txtPassword.Text = result1.First().USERPASSWORD;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLogOut_Click(object sender, EventArgs e)
        {

            frmLoginMenu logout = new frmLoginMenu();
            this.Close();
            logout.Show();
        }
    }
}
