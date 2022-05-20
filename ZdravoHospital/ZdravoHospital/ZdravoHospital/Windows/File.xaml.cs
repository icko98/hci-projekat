using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for File.xaml
    /// </summary>
    public partial class File : Window
    {
        public static ReportController repController = new ReportController();
        public static PatientController patController = new PatientController();
        public ObservableCollection<Report> Xreps { get; set; }
        public static Report SelectedReport { get; set; }
        Model.Patient xpat = new Model.Patient();

        public File()
        {
            InitializeComponent();
            this.DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            xpat = patController.GetById(DoctorWindow.SelectedApp.PatientID);
            tb1.Text = xpat.jmbg;
            tb2.Text = xpat.name;
            tb3.Text = xpat.surname;
            tb4.Text = xpat.dateOfBirth;
            Xreps = new ObservableCollection<Report>(repController.GetAllById(xpat.jmbg));
            
            Show();

            
        }
        private static File windowInst;
        public static File GetPatientFile()
        {
            if (windowInst == null)
            {
                windowInst = new File();
            }
            return windowInst;
        }

        public void refreshRepTable()
        {
            repTable.ItemsSource = null;
            repTable.ItemsSource = repController.GetAllById(xpat.jmbg);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            windowInst = null;
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            CreateReport cr = new CreateReport();
            cr.Show();
        }
        private void Button_Click_Change(object sender, RoutedEventArgs e)
        {
            EditReport er = new EditReport();
            er.Show();
        }
        

        private void appTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
