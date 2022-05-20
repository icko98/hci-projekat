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

namespace ZdravoHospital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click_Manager(object sender, RoutedEventArgs e)
        {
            //ManagerWindow managerWindow = ManagerWindow.GetManagerWindow();
            //managerWindow.Show();

            ManagerOptions managerOptions = ManagerOptions.GetManagerOptions();
            managerOptions.Show();
            
        }
        private void Button_Click_Doctor(object sender, RoutedEventArgs e)
        {
            DoctorWindow doctorWindow = DoctorWindow.GetDoctorWindow();
            doctorWindow.Show();
        }

        private void Button_Click_Secretary(object sender, RoutedEventArgs e)
        {
            SecretaryWindow secretaryWindow = SecretaryWindow.GetSecretaryWindow();
            secretaryWindow.Show();
        }

        private void Button_Click_LogIn(object sender, RoutedEventArgs e)
        {
            LogIn logIn = LogIn.GetLogInWindow();
            logIn.Show();
        }
    }
}
