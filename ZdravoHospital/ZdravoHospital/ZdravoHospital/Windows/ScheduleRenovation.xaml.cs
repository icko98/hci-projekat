using System;
using System.Collections.Generic;
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
    /// Interaction logic for ScheduleRenovation.xaml
    /// </summary>
    public partial class ScheduleRenovation : Window
    {
        public ScheduleRenovation()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = this;
            ButtonYes.IsEnabled = false;

            Show();
        }

        private void Button_Click_No(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_Yes(object sender, RoutedEventArgs e)
        {
            BasicRenovationWindow.basicRenovationController.ScheduleRenovation(new Model.BasicRenovation(RoomId.Text, StartDate.SelectedDate.Value, EndDate.SelectedDate.Value, Description.Text));
            BasicRenovationWindow.GetBasicRenovationWindow().refershBasicRenovationTable();
            Close();
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(RoomId.Text) || string.IsNullOrEmpty(Description.Text))
            {
                ButtonYes.IsEnabled = false;
            }
            else
            {
                ButtonYes.IsEnabled = true;

            }
        }

        private static ScheduleRenovation windowInstance;
        public static ScheduleRenovation GetScheduleRenovation()
        {
            if (windowInstance == null)
            {
                windowInstance = new ScheduleRenovation();
            }
            return windowInstance;
        }
    }
}
