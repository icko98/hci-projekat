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
using ZdravoHospital.Windows;

namespace ZdravoHospital.Pages
{
    /// <summary>
    /// Interaction logic for changeApp.xaml
    /// </summary>
    public partial class changeApp : Page
    {
        private object returnWindow;
        private DoctorWindow mainWin;
        public changeApp(DocMenu returnWindow, DoctorWindow main)
        {
            this.returnWindow = returnWindow;
            this.mainWin = main;
            InitializeComponent();
            this.DataContext = this;
            Model.App xap = DocMenu.SelectedApp;
            mainWin.windowLabel.Content = "Update an appointment";
            PId.Text = xap.PatientID;
            Duration.Text = xap.Duration.ToString();
            Id.Text = xap.Id.ToString();
        }
        private void Button_Doc_N(object sender, RoutedEventArgs e)
        {
            mainWin.frejm.Content = returnWindow;
        }
        private void Button_Doc_Y(object sender, RoutedEventArgs e)
        {
            DocMenu.appController.Update(new Model.App(Id.Text, PId.Text, nzm.SelectedDate.Value, Int32.Parse(Duration.Text)));
            //DocMenu.GetDoctorWindow().refreshAppTable();
            returnWindow = new DocMenu(mainWin);
            mainWin.frejm.Content = returnWindow;
        }
    }
}
