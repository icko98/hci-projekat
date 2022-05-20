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
            frejm.Content = new DocMenu(this);


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
            frejm.Content = new DocMenu(this);
        }
    }
}
