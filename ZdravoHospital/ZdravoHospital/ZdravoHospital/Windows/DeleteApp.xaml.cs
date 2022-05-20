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
using System.Windows.Shapes;
using ZdravoHospital.Pages;

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for DeleteApp.xaml
    /// </summary>
    public partial class DeleteApp : Window
    {
        public DeleteApp()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }
        private void Button_Click_N(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_Click_Y(object sender, RoutedEventArgs e)
        {
            DocMenu.appController.DeleteById(DocMenu.SelectedApp.Id);
            DocMenu.GetDoctorWindow().refreshAppTable();
            Close();
        }
    }
}
