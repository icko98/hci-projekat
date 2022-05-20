using System;
using System.Collections.Generic;
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
    /// Interaction logic for ManagerOptions.xaml
    /// </summary>
    public partial class ManagerOptions : Window
    {
        public ManagerOptions()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private static ManagerOptions windowInstance;
        public static ManagerOptions GetManagerOptions()
        {
            if(windowInstance == null)
            {
                windowInstance = new ManagerOptions();
            }
            return windowInstance;
        }

        private void Rooms_Click(object sender, RoutedEventArgs e)
        {
            
            
                ManagerWindow managerWindow = ManagerWindow.GetManagerWindow();
                managerWindow.Show();

            
        }

        private void Equipment_Click(object sender, RoutedEventArgs e)
        {
            EquipmentWindow equipmentWindow = EquipmentWindow.GetEquipmentWindow();
            equipmentWindow.Show();
        }

        private void BasicRenovation_Click(object sender, RoutedEventArgs e)
        {
            BasicRenovationWindow basicRenovationWindow = BasicRenovationWindow.GetBasicRenovationWindow();
            basicRenovationWindow.Show();
        }

        private void RelocateEquipment_Click(object sender, RoutedEventArgs e)
        {
            RelocationWIndow relocationWindow = RelocationWIndow.GetRelocationWindow();
                relocationWindow.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            windowInstance = null;
        }
    }
}
