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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZdravoHospital.Windows;

namespace ZdravoHospital.Pages
{
    /// <summary>
    /// Interaction logic for xd.xaml
    /// </summary>
    public partial class xd : Page
    {
        public DoctorWindow dww;
        public xd(DoctorWindow dw)
        {
            InitializeComponent();
            dww = dw;
            dww.windowLabel.Content = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenu(dww));
        }
    }
}
