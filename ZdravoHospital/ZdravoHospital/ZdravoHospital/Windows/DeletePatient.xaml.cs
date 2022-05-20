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

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for DeletePatient.xaml
    /// </summary>
    public partial class DeletePatient : Window
    {
        public DeletePatient()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_N(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_Y(object sender, RoutedEventArgs e)
        {
            SecretaryWindow.patientController.DeletePatient(SecretaryWindow.SelectedPatient);
            SecretaryWindow.GetSecretaryWindow().refreshPatientTable();
            Close();
        }
    }
}
