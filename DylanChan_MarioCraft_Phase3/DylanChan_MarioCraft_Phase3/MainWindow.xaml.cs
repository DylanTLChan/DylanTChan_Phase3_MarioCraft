using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DylanChan_MarioCraft_Phase3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Hides the MainWindow
            this.Hide();

            //Shows frmRegisterMenu GUI
            frmRegisterMenu regMenu = new frmRegisterMenu();
            regMenu.Show();

            //frmLoginMenu loginMenu = new frmLoginMenu();
            //loginMenu.Show();

         }
    }
}
