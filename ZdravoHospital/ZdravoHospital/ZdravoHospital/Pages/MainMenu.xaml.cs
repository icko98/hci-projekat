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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        private DoctorWindow DoctorWindow;
        public ObservableCollection<Medication> aTBAmedication { get; set; }
        public ObservableCollection<Medication> aCMedication { get; set; }
        public MainMenu(DoctorWindow WINDOW)
        {
            InitializeComponent();
            DoctorWindow = WINDOW;

            Medlists.Instance.AddToTBAmedication(new Medication("1", "Brufen"));
            Medlists.Instance.AddToTBAmedication(new Medication("2", "Insulin"));
            Medlists.Instance.AddToTBAmedication(new Medication("3", "Andol"));
            Medlists.Instance.AddToTBAmedication(new Medication("4", "Bromazepam"));
           

            Medlists.Instance.AddToCmedication(new Medication("1", "Nesto"));
            Medlists.Instance.AddToCmedication(new Medication("2", "Lek"));
            Medlists.Instance.AddToCmedication(new Medication("3", "Patozin"));
            Medlists.Instance.AddToCmedication(new Medication("4", "Smetorin"));
            DoctorWindow.windowLabel.Content = "Menu";




            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoctorWindow.frejm.Content = new DocMenu(DoctorWindow);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DoctorWindow.frejm.Content = new Meds(DoctorWindow);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Vac(DoctorWindow));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new File("2182246932", DoctorWindow));
        }
    }
}
