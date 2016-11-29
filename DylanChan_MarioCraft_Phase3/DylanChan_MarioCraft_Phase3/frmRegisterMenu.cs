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

            //Confirmation Message
            MessageBox.Show("Successfully registred", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLoginMenu frmNext = new frmLoginMenu(this);
            this.Close();
            frmNext.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
