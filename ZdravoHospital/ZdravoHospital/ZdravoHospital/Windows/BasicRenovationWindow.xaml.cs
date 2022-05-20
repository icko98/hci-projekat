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
    /// Interaction logic for BasicRenovationWindow.xaml
    /// </summary>
    public partial class BasicRenovationWindow : Window
    {

        public static BasicRenovationController basicRenovationController = new BasicRenovationController();
        public static ObservableCollection<BasicRenovation> BasicRenovation { get; set; }
        public BasicRenovationWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            BasicRenovation = new ObservableCollection<BasicRenovation>(basicRenovationController.GetScheduledRenovations());
        }

        private static BasicRenovationWindow windowInstance;

        public static BasicRenovationWindow GetBasicRenovationWindow()
        {
            if (windowInstance == null)
            {
                windowInstance = new BasicRenovationWindow();
            }
            return windowInstance;
        }

        public void refershBasicRenovationTable()
        {
            basicRenovationTable.ItemsSource = null;
            basicRenovationTable.ItemsSource = basicRenovationController.GetScheduledRenovations();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            windowInstance = null;
        }

        private void ScheduleRenovation_Click(object sender, RoutedEventArgs e)
        {
            ScheduleRenovation scheduleREnovation = new ScheduleRenovation();
            scheduleREnovation.Show();
        }
    }
}
