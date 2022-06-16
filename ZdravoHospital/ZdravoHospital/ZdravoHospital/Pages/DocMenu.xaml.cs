using Controller;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZdravoHospital.Windows;

namespace ZdravoHospital.Pages
{
    /// <summary>
    /// Interaction logic for DocMenu.xaml
    /// </summary>
    public partial class DocMenu : Page
    {
        private DoctorWindow doctorWindow;
        public DocMenu(DoctorWindow WINDOW)
        {
            InitializeComponent();
            doctorWindow = WINDOW;
            this.DataContext = this;
            Xapps = new ObservableCollection<Model.App>(appController.GetAll());
            refreshAppTable();
        }
        public static AppController appController = new AppController();
        public ObservableCollection<Model.App> Xapps { get; set; }

        public static Model.App SelectedApp { get; set; }
        
        private static DocMenu windowInst;

        public static DocMenu GetDoctorWindow()
        {
            if (windowInst == null)
            {
                //windowInst = new DocMenu();
            }
            return windowInst;
        }

        public void refreshAppTable()
        {
            appTable.ItemsSource = null;
            appTable.ItemsSource = appController.GetAll();
        }

        
        private void Button_Click_DAdd(object sender, RoutedEventArgs e)
        {
            addApp addapp = new addApp(this, doctorWindow);
            doctorWindow.frejm.Content = addapp;
            
        }
        private void Button_Click_DDelete(object sender, RoutedEventArgs e)
        {
            if (SelectedApp == null)
            {
                return;
            }
            DelApp deleteApp = new DelApp(this, doctorWindow);
            //deleteApp.Show();
            doctorWindow.frejm.Content = deleteApp;
            
        }
        private void Button_Click_DEdit(object sender, RoutedEventArgs e)
        {
            if (SelectedApp == null)
            {
                return;

            }
            changeApp changeapp = new changeApp(this, doctorWindow);
            doctorWindow.frejm.Content = changeapp;
        }
        private void Button_Click_File(object sender, RoutedEventArgs e)
        {
            if (SelectedApp == null)
            {
                return;

            }
            File patFile = new File(SelectedApp.PatientID, doctorWindow);
            doctorWindow.frejm.Content = patFile;
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Vac vac = new Vac();
            doctorWindow.frejm.Content = vac;
        }

        private void Button_Click_meds(object sender, RoutedEventArgs e)
        {
            //Meds meds = new Meds();
            //doctorWindow.frejm.Content = meds;
        }
    }
}

