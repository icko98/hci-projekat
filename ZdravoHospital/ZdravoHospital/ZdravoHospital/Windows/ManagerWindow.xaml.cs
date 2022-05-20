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
using Controller;
using Model;

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public static RoomController roomController = new RoomController();
        public ObservableCollection<Room> Rooms { get; set; }

        public static Room SelectedRoom { get; set; }

        public ManagerWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            Rooms = new ObservableCollection<Room>(roomController.GetRooms());
        }

        private static ManagerWindow windowInstance;
        public static ManagerWindow GetManagerWindow()
        {
            if (windowInstance == null)
            {
                windowInstance = new ManagerWindow();

            }
            return windowInstance;
        }

        public void refreshRoomTable()
        {

            roomsTable.ItemsSource = null;
            roomsTable.ItemsSource = roomController.GetRooms();
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            windowInstance = null;
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            
            CreateRoom createRoom = new CreateRoom();
            createRoom.Show();
        }

        private void Button_Click_Edit(object sender, RoutedEventArgs e)
        {
            if (SelectedRoom == null)
            {
                return;
            }
            EditRoom editRoom = new EditRoom();
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            if (SelectedRoom == null)
            {
                return;
            }
            DeleteRoom deleteRoom = new DeleteRoom();
            deleteRoom.Show();
        }
    }
}
