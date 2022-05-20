using Model;
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
    /// Interaction logic for RelocateWindow.xaml
    /// </summary>
    public partial class RelocateWindow : Window
    {
        public RelocateWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = this;
            ButtonYes.IsEnabled = true;
            //treba dugme na false al nesto zeza

            Show();
        }

        private void Button_Click_No(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_yes(object sender, RoutedEventArgs e)
        {
            RelocationWIndow.relocateEquipmentController.Relocate(new RelocateEquipment(Id.Text, int.Parse(Quantity.Text), NextRoomId.Text, Date.SelectedDate.Value));
            RelocationWIndow.GetRelocationWindow().refreshRelocateEquipmentTable();
            Close();
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Id.Text) || string.IsNullOrEmpty(NextRoomId.Text))
            {
                ButtonYes.IsEnabled = false;
            }
            else
            {
                ButtonYes.IsEnabled = true;
            }
        }

        private static RelocateWindow windowInstance;

        public static RelocateWindow GetRelocateWindow()
        {
            if (windowInstance == null)
            {
                windowInstance = new RelocateWindow();
            }
            return windowInstance;
        }
    }
}
