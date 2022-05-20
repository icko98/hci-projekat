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
using ZdravoHospital.Pages;

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for EditApp.xaml
    /// </summary>
    public partial class EditApp : Window
    {
        public EditApp()
        {
            InitializeComponent();
            WindowStartupLocation= WindowStartupLocation.CenterScreen;
            this.DataContext = this;
            Model.App xap = DoctorWindow.SelectedApp;
            PId.Text = xap.PatientID;
            Duration.Text = xap.Duration.ToString();
            Id.Text = xap.Id.ToString();
            Show();
            


        }
        private void Button_Doc_N(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_Doc_Y(object sender, RoutedEventArgs e)
        {
            DocMenu.appController.Update(new Model.App(Id.Text,PId.Text, nzm.SelectedDate.Value, Int32.Parse(Duration.Text)));
            DocMenu.GetDoctorWindow().refreshAppTable();
            Close();
        }
    }
}
