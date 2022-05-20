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
    /// Interaction logic for EditReport.xaml
    /// </summary>
    public partial class EditReport : Window
    {
        string tes;
        string tts;
        public EditReport()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.DataContext = this;
            Model.Report xrep = File.SelectedReport;
            tes = xrep.Jmbg;
            tts = xrep.Id.ToString();
            nzm.SelectedDate = xrep.Dt;
            Desc.Text = xrep.Desc;
            Show();
        }
        private void Button_Doc_N(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_Doc_Y(object sender, RoutedEventArgs e)
        {
            File.repController.Update(new Model.Report(tts, nzm.SelectedDate.Value, Desc.Text, tes));

            File.GetPatientFile().refreshRepTable();
            Close();
        }
    }
}
