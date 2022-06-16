using Controller;
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
    /// Interaction logic for addRep.xaml
    /// </summary>
    public partial class addRep : Page
    {
        public static PatientController patController = new PatientController();
        Patient xpat = new Patient();
        File dfjl;
        public ObservableCollection<Medication> Xpers;
        public static Medication SelectedMed { get; set; }
        public addRep(Patient modpat, File fajl)
        {
            InitializeComponent();
            this.DataContext = this;
            xpat = modpat;
            dfjl = fajl;
            Xpers = new ObservableCollection<Medication>();
            refreshTables();


        }
        public void refreshTables()
        {
            persTable.ItemsSource = null;
            persTable.ItemsSource = Xpers.ToList();
            
        }
        private void Button_Doc_N(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Button_Doc_Y(object sender, RoutedEventArgs e)
        {
            File.repController.Create(new Report(nzm.SelectedDate.Value, Desc.Text, xpat.jmbg));
            dfjl.refreshRepTable();
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("No entries in back navigation history.");
            }
        }

        private void Button_Doc_add(object sender, RoutedEventArgs e)
        {
           addPerscription addper = new addPerscription(this);
           this.NavigationService.Navigate(addper);
        }
    }
}
