using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for File.xaml
    /// </summary>
    public partial class File : Page
    {
        public static ReportController repController = new ReportController();
        public static PatientController patientController = new PatientController();
        public ObservableCollection<Report> Xreps { get; set; }

        public static Report SelectedReport { get; set; }
        Patient xpat = new Patient();
        private DoctorWindow mainWin;
        public File(string prepat, DoctorWindow dw)
        {
            InitializeComponent();
            this.DataContext = this;
            mainWin = dw;
            xpat = patientController.GetById(prepat);
            tb1.Text = xpat.jmbg;
            tb2.Text = xpat.name;
            tb3.Text = xpat.surname;
            tb4.Text = xpat.dateOfBirth;
            Xreps = new ObservableCollection<Report>(repController.GetAllById(xpat.jmbg));
            
        }
        public void refreshRepTable()
        {
            repTable.ItemsSource = null;
            repTable.ItemsSource = repController.GetAllById(xpat.jmbg);
        }

        private void appTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_Change(object sender, RoutedEventArgs e)
        {
            changeReport cr = new changeReport(this);
            mainWin.frejm.Content = cr;
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            addRep ar = new addRep(xpat, this);
            mainWin.frejm.Content = ar;
            

        }
    }
}
