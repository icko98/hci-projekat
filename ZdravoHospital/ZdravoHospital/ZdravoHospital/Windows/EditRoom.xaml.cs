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
using Model;
using ZdravoHospital.Validation;

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for EditRoom.xaml
    /// </summary>
    public partial class EditRoom : Window
    {
        private int floorTest;
        public int FloorTest
        {
            get
            {
                return floorTest;
            }
            set
            {
                floorTest = value;
                OnPropertyChanged("FloorTest");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public EditRoom()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.DataContext = this;
            Room r = ManagerWindow.SelectedRoom;
            Id.Text = r.Id;
            Name.Text = r.Name;
            Description.Text = r.Description;
            FloorTest = r.Floor;
            Type.ItemsSource = Enum.GetValues(typeof(RoomType)).Cast<RoomType>();
            Type.SelectedItem = r.RoomType;
            MinMaxFloorValidationRule.noError = true;

            Show();
        }

        private void Button_Click_No(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_Yes(object sender, RoutedEventArgs e)
        {
            ManagerWindow.roomController.EditRoom(new Room(Id.Text, Name.Text, Description.Text, int.Parse(Floor.Text), (RoomType)Type.SelectedItem));
            ManagerWindow.GetManagerWindow().refreshRoomTable();
            Close();
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if (MinMaxFloorValidationRule.noError)
            {
                ButtonYes.IsEnabled = true;
            }
            else
            {
                ButtonYes.IsEnabled = false;
            }
        }
    }
}
