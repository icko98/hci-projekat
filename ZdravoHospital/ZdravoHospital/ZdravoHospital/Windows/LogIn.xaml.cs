using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if(pass.Password != "" && username.Text != "")
            {
                if(pass.Password == "1234" && username.Text == "Manager")
                {
                    ManagerOptions managerOptions = ManagerOptions.GetManagerOptions();
                    managerOptions.Show();
                }
                else if(pass.Password == "1234" && username.Text == "Secretary")
                {
                    SecretaryWindow secretaryWindow = SecretaryWindow.GetSecretaryWindow();
                    secretaryWindow.Show();
                }
                else if(pass.Password == "1234" && username.Text == "Doctor")
                {
                    DoctorWindow doctorWindow = DoctorWindow.GetDoctorWindow();
                    doctorWindow.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect!", "Try again!");
                }
            }
        }

        private static LogIn windowInstance;
        public static LogIn GetLogInWindow()
        {
            if (windowInstance == null)
            {
                windowInstance = new LogIn();
            }
            return windowInstance;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            windowInstance = null;
        }
    }
}
