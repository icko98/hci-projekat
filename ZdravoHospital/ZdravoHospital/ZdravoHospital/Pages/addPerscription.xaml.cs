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
    /// Interaction logic for addPerscription.xaml
    /// </summary>
    public partial class addPerscription : Page
    {
        public ObservableCollection<Medication> nMeds;
        public static Medication selectedMed;
        public addPerscription(ObservableCollection<Medication> meds)
        {
            InitializeComponent();
            nMeds = meds;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
