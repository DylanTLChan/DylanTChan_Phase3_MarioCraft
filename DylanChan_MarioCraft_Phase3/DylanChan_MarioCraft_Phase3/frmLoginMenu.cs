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

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmRegisterMenu back = new frmRegisterMenu(this);

            this.Close();
            back.Show();
        }
    }
}
