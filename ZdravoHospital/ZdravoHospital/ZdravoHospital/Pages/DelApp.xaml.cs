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
using ZdravoHospital.Windows;

namespace ZdravoHospital.Pages
{
    /// <summary>
    /// Interaction logic for DelApp.xaml
    /// </summary>
    public partial class DelApp : Page
    {
        private object returnWindow;
        private DoctorWindow mainWin;
        public DelApp(object returnWindow, DoctorWindow main)
        {
            this.returnWindow = returnWindow;
            this.mainWin = main;
            InitializeComponent();
        }
        private void Button_Click_N(object sender, RoutedEventArgs e)
        {
            mainWin.frejm.Content = returnWindow;
        }
        private void Button_Click_Y(object sender, RoutedEventArgs e)
        {
            DocMenu.appController.DeleteById(DocMenu.SelectedApp.Id);
            //DocMenu.GetDoctorWindow().refreshAppTable();
            returnWindow = new DocMenu(mainWin);
            mainWin.frejm.Content = returnWindow;

        }
    }
}
