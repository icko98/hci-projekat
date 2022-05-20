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
using Model;

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for DeleteRoom.xaml
    /// </summary>
    public partial class DeleteRoom : Window
    {
        public DeleteRoom()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click_No(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_Yes(object sender, RoutedEventArgs e)
        {
            ManagerWindow.roomController.DeleteRoom(ManagerWindow.SelectedRoom);
            ManagerWindow.GetManagerWindow().refreshRoomTable();
            Close();
        }
    }
}
