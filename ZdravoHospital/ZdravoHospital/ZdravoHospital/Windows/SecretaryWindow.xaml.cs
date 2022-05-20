using Controller;
using System.Collections.ObjectModel;
using System.Windows;
using System.ComponentModel;
namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for DoctorWindow.xaml
    /// </summary>
    public partial class SecretaryWindow : Window
    {
        public static PatientController patientController = new PatientController();
        public ObservableCollection<Model.Patient> Xpatients { get; set; }

        public static Model.Patient SelectedPatient { get; set; }
        public SecretaryWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;

            Xpatients = new ObservableCollection<Model.Patient>(patientController.GetPatients());
        }
        private static SecretaryWindow windowInst;

        public static SecretaryWindow GetSecretaryWindow()
        {
            if (windowInst == null)
            {
                windowInst = new SecretaryWindow();
            }
            return windowInst;
        }

        public void refreshPatientTable()
        {
            patientTable.ItemsSource = null;
            patientTable.ItemsSource = patientController.GetPatients();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            windowInst = null;
        }
        private void Button_Click_SAdd(object sender, RoutedEventArgs e)
        {

            CreatePatient createPatient = new CreatePatient();
            createPatient.Show();
        }

        private void Button_Click_SEdit(object sender, RoutedEventArgs e)
        {
            if (SelectedPatient == null)
            {
                return;

            }
            EditPatient editPatient = new EditPatient();
        }

        private void Button_Click_SDelete(object sender, RoutedEventArgs e)
        {

            if (SelectedPatient == null)
            {
                return;
            }
            DeletePatient deletePatient = new DeletePatient();
            deletePatient.Show();
        }
    }
}
