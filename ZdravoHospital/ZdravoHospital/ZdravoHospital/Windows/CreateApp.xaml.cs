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
using Model;
using ZdravoHospital.Pages;

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for CreateApp.xaml
    /// </summary>
    public partial class CreateApp : Window
    {
        public CreateApp()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = this;
            Show();
        }
        private void Button_Doc_N(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_Doc_Y(object sender, RoutedEventArgs e)
        {
            DocMenu.appController.Create(new Model.App(PId.Text, nzm.SelectedDate.Value, Int32.Parse(Duration.Text)));
           // DocMenu.GetDoctorWindow().refreshAppTable();
            Close();

        }
    }

    
}
