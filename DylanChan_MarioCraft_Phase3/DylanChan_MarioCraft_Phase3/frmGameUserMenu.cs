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
        Model1 ctx = new Model1();
        private frmLoginMenu frmLoginMenu;
        private String email;
        
        public frmGameUserMenu()
        {
            InitializeComponent();
        }
        public frmGameUserMenu(String email)
        {
            InitializeComponent();
            this.email = email;
        }
     

        private void GameUserMenu_Load(object sender, EventArgs e)
        {
           
             //This line of code loads data into the 'dataSet1.GAMEUSERDETAILS' table.
            this.gAMEUSERDETAILSTableAdapter.FillBy(dataSet1.GAMEUSERDETAILS,email);
           
        }
        

         public frmGameUserMenu(frmLoginMenu frmLoginMenu)
        {

            this.frmLoginMenu = frmLoginMenu;
 
        }

        
            //Retrieve 
           /*Model1 ctx = new Model1();
  
            var retriveItem = from gameUser in ctx.RUCKSACKs
                          where gameUser.ITEMDESC == "Opal"
                          select gameUser;
            this.txtItem.Text = retriveItem.First().ITEMDESC;*/
        

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
