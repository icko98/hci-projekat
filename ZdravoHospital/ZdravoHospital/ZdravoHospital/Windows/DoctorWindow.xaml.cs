using Controller;
using System.Collections.ObjectModel;
using System.Windows;
using System.ComponentModel;
using ZdravoHospital.Pages;

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for DoctorWindow.xaml
    /// </summary>
    public partial class DoctorWindow : Window
    {
        public static AppController appController = new AppController();
        public ObservableCollection<Model.App> Xapps { get; set; }

        public static Model.App SelectedApp { get; set; }
        public DoctorWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            frejm.Content = new MainMenu(this);
            


        }
        private static DoctorWindow windowInst;

        public static DoctorWindow GetDoctorWindow()
        {
            if (windowInst == null)
            {
                windowInst = new DoctorWindow();
            }
            return windowInst;
        }
        public void getTitle(string str1)
        {
            this.windowLabel.Content = str1;
        }
        public void refresh()
        {
            //frejm.Content = new DocMenu();
        }

        
        protected override void OnClosing(CancelEventArgs e)
        {
            windowInst = null;
        }
        
        

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (frejm.NavigationService.CanGoBack)
            {
                frejm.NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("No entries in back navigation history.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frejm.Content = new xd(this);
        }
    }
}
