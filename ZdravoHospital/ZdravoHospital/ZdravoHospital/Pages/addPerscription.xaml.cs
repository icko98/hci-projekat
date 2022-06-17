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
    /// Interaction logic for addPerscription.xaml
    /// </summary>
    public partial class addPerscription : Page
    {
        public ObservableCollection<Medication> nMeds;
        public static Medication selectedMed { get; set; }
        private addRep adr;
        private DoctorWindow dww;
        public addPerscription(addRep addrep, DoctorWindow dw)
        {
            InitializeComponent();
            this.DataContext = this;
            nMeds = Medlists.Instance.getCmedication();
            adr = addrep;
            dww = dw;
            dww.windowLabel.Content = "Add medication";
            
            medsTable.ItemsSource = null;
            medsTable.ItemsSource = nMeds.ToList();
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            adr.Xpers.Add(selectedMed);
            adr.refreshTables();
            this.NavigationService.GoBack();
        }
    }
}
