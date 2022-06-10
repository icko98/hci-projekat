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

namespace ZdravoHospital.Pages
{
    /// <summary>
    /// Interaction logic for changeReport.xaml
    /// </summary>
    public partial class changeReport : Page
    {
        string str1;
        string str2;
        File df;

        public changeReport(File fajl)
        {
            InitializeComponent();
            this.DataContext = this;
            df = fajl;
            Model.Report xrep = File.SelectedReport;
            str1 = xrep.Jmbg;
            str2 = xrep.Id.ToString();
            nzm.SelectedDate = xrep.Dt;
            Desc.Text = xrep.Desc;
        }

        private void Button_Doc_N(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Button_Doc_Y(object sender, RoutedEventArgs e)
        {
            File.repController.Update(new Model.Report(str2, nzm.SelectedDate.Value, Desc.Text, str1));
            df.refreshRepTable();
            this.NavigationService.GoBack();
        }
    }
}
