using Model;
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
    /// Interaction logic for EditPatient.xaml
    /// </summary>
    public partial class EditPatient : Window
    {
        public EditPatient()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.DataContext = this;
            Model.Patient xpat = SecretaryWindow.SelectedPatient;
            jmbgg.Text = xpat.jmbg;
            Namee.Text = xpat.name;
            Surnamee.Text = xpat.surname;
            Addres.Text = xpat.address;
            Phonee.Text = xpat.phoneNumber;
            datee.Text = xpat.dateOfBirth;
            recordd.Text = xpat.recordNumber;
            genderr.ItemsSource = Enum.GetValues(typeof(Gender)).Cast<Gender>();
            genderr.SelectedItem = xpat.gender;
            Show();

            //Type.ItemsSource = Enum.GetValues(typeof(RoomType)).Cast<RoomType>();
            //Type.SelectedItem = r.RoomType;
        }
        private void Button_N(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_D(object sender, RoutedEventArgs e)
        {
            SecretaryWindow.patientController.EditPatient(new Model.Patient(jmbgg.Text, Namee.Text, Surnamee.Text, Addres.Text, Phonee.Text, datee.Text, recordd.Text, (Gender)genderr.SelectedItem));
            SecretaryWindow.GetSecretaryWindow().refreshPatientTable();
            
            Close();
        }

        private void Button_Sec_N(object sender, RoutedEventArgs e)
        {

        }
    }
}
