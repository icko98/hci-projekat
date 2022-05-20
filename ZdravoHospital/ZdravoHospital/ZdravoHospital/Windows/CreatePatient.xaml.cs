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

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for CreateApp.xaml
    /// </summary>
    public partial class CreatePatient : Window
    {
        public CreatePatient()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = this;
            genderr.ItemsSource = Enum.GetValues(typeof(Gender)).Cast<Gender>();
            Show();
        }
        private void Button_Sec_N(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_Sec_Y(object sender, RoutedEventArgs e)
        {
            SecretaryWindow.patientController.CreatePatient(new Model.Patient(jmbgg.Text, Namee.Text, Surnamee.Text, Addres.Text, Phonee.Text, datee.Text, recordd.Text, (Gender)genderr.SelectedItem));
            SecretaryWindow.GetSecretaryWindow().refreshPatientTable();
            Close();

        }
    }

    
}
