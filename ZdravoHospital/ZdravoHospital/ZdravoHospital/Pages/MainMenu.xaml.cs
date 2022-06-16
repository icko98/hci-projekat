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
            aTBAmedication = new ObservableCollection<Medication>();
            aTBAmedication.Add(new Medication("1", "Brufen"));
            aTBAmedication.Add(new Medication("2", "Insulin"));
            aTBAmedication.Add(new Medication("3", "Andol"));
            aTBAmedication.Add(new Medication("4", "Bromazepam"));


            aCMedication = new ObservableCollection<Medication>();
            aCMedication.Add(new Medication("1", "Nesto"));
            aCMedication.Add(new Medication("2", "Lek"));
            aCMedication.Add(new Medication("3", "Patozin"));
            aCMedication.Add(new Medication("4", "Smetorin"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoctorWindow.frejm.Content = new DocMenu(DoctorWindow);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DoctorWindow.frejm.Content = new Meds(aTBAmedication, aCMedication);
        }
    }
}
