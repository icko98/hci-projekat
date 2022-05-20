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
    /// Interaction logic for EquipmentWindow.xaml
    /// </summary>
    public partial class EquipmentWindow : Window
    {

        public static EquipmentController equipmentController = new EquipmentController();
        public ObservableCollection<Equipment> Equipment { get; set; }

        public static Equipment SelectedEquipment { get; set; }


        public EquipmentWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;


            Equipment = new ObservableCollection<Equipment>(equipmentController.GetEquipment());
        }

        private static EquipmentWindow windowInstance;
        public static EquipmentWindow GetEquipmentWindow()
        {
            if(windowInstance == null)
            {
                windowInstance = new EquipmentWindow();
            }
            return windowInstance;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            windowInstance = null;
        }
    }
}
