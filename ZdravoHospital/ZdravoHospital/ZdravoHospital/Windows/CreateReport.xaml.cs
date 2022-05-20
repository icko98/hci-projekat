using Controller;
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
    /// Interaction logic for CreateReport.xaml
    /// </summary>
    public partial class CreateReport : Window
    {
        public static PatientController patController = new PatientController();
        Model.Patient xpat = new Model.Patient();
        public CreateReport()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.DataContext = this;
            xpat = patController.GetById(DoctorWindow.SelectedApp.PatientID);
            Show();
        }
        private void Button_Doc_N(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_Doc_Y(object sender, RoutedEventArgs e)
        {
            File.repController.Create(new Model.Report(nzm.SelectedDate.Value, Desc.Text, xpat.jmbg));
            
            File.GetPatientFile().refreshRepTable();
            Close();
        }
    }
}
