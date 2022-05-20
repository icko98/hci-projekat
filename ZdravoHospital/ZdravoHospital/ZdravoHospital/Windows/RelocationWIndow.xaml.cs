using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for RelocationWIndow.xaml
    /// </summary>
    public partial class RelocationWIndow : Window
    {

        public static RelocateEquipmentController relocateEquipmentController = new RelocateEquipmentController();
        public static ObservableCollection<RelocateEquipment> RelocateEquipment { get; set; }

        public RelocationWIndow()
        {
            InitializeComponent();
            this.DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            RelocateEquipment = new ObservableCollection<RelocateEquipment>(relocateEquipmentController.GetEquipment());
        }

        private static RelocationWIndow windowInstance;

        public static RelocationWIndow GetRelocationWindow()
        {
            if (windowInstance == null)
            {
                windowInstance = new RelocationWIndow();
            }
            return windowInstance;
        }

        public void refreshRelocateEquipmentTable()
        {
            relocateEquipmentTable.ItemsSource = null;
            relocateEquipmentTable.ItemsSource = relocateEquipmentController.GetEquipment();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            windowInstance = null;
        }

        private void Relocate_Click(object sender, RoutedEventArgs e)
        {
            RelocateWindow relocateWindow = new RelocateWindow();
            relocateWindow.Show();
        }
    }
}
