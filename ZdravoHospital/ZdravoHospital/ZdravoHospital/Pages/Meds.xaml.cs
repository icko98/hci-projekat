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


        public Meds(ObservableCollection<Medication> meds1, ObservableCollection<Medication> meds2)
        {
            InitializeComponent();
            this.DataContext = this;
            TBAmedication = meds1;
            CMedication = meds2;

            refreshTables();
        }
        
        private void appTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void refreshTables()
        {
            TBAmeds.ItemsSource = null;
            CMeds.ItemsSource = null;
            TBAmeds.ItemsSource = TBAmedication.ToList();
            CMeds.ItemsSource = CMedication.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CMedication.Add(SelectedMed);
            TBAmedication.Remove(SelectedMed);
            refreshTables();
        }
    }
}
