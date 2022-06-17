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
    /// Interaction logic for Meds.xaml
    /// </summary>
    public partial class Meds : Page
    {
        public ObservableCollection<Medication> TBAmedication { get; set; }
        public ObservableCollection<Medication> CMedication { get; set; }
        public static Medication SelectedMed { get; set; }
        public static Medication SelectedMed2 { get; set; }

        private DoctorWindow dww;
        public Meds(DoctorWindow dw)
        {
            InitializeComponent();
            this.DataContext = this;
            TBAmedication = Medlists.Instance.getTBAmedication();
            CMedication = Medlists.Instance.getCmedication();
            dww = dw;
            dww.windowLabel.Content = "Medication";

            refreshTables();
        }
        
        private void appTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void refreshTables()
        {
            TBAmeds.ItemsSource = null;
            CMeds.ItemsSource = null;
            TBAmedication = Medlists.Instance.getTBAmedication();
            CMedication = Medlists.Instance.getCmedication();
            TBAmeds.ItemsSource = TBAmedication.ToList();
            CMeds.ItemsSource = CMedication.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Medlists.Instance.AddToCmedication(SelectedMed);
            Medlists.Instance.RemoveFromTBA(SelectedMed);
            refreshTables();
        }
    }
}
