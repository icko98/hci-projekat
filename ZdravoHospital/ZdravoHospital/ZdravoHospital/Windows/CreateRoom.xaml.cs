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
    /// Interaction logic for CreateRoom.xaml
    /// </summary>
    public partial class CreateRoom : Window
    {
        private string idTest;
        public string IdTest
        {
            get
            {
                return idTest;
            }
            set
            {
                idTest = value;
                OnPropertyChanged("IdTest");
            }
        }
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

        public CreateRoom()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = this;
            Type.ItemsSource = Enum.GetValues(typeof(RoomType)).Cast<RoomType>();
            ButtonYes.IsEnabled = false;
            MinMaxFloorValidationRule.noError = true;

            Show();
            
        }

        private void Button_Click_No(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_Yes(object sender, RoutedEventArgs e)
        {
            ManagerWindow.roomController.CreateRoom(new Room(Id.Text, Name.Text, Description.Text, int.Parse(Floor.Text), (RoomType)Type.SelectedItem));
            ManagerWindow.GetManagerWindow().refreshRoomTable();
            Close();
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(Id.Text) || string.IsNullOrEmpty(Name.Text) || string.IsNullOrEmpty(Description.Text) || string.IsNullOrEmpty(Floor.Text))
            {
               
                ButtonYes.IsEnabled = false;
                
            }
            else
            {
                if (RoomIdValidationRule.noError && MinMaxFloorValidationRule.noError)
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
}
