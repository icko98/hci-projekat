using Controller;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZdravoHospital.Pages
{
    /// <summary>
    /// Interaction logic for Vac.xaml
    /// </summary>
    public partial class Vac : Page
    {
        private VacController vc = new VacController();
        public Model.Vac vac;
        public Vac()
        {
            InitializeComponent();
            this.DataContext = this;
            vac = vc.GetById(User.UserName);
            if (vac != null)
            {
                name.Text = User.UserName;
                duration.Text = vac.NumOfDays.ToString();
                if (vac.IsReviewed == true)
                {
                    if (vac.IsAccepted == true)
                    {
                        status.Text = "Accepted";

                    }
                    else
                    {
                        status.Text = "Denied";
                    }
                }
                nzm.SelectedDate = vac.StartDate;


            }
        }

        private void Button_Doc_Y(object sender, RoutedEventArgs e)
        {
            vc.Create(new Model.Vac(name.Text, Int32.Parse(duration.Text), false, false, nzm.SelectedDate.Value));
            this.NavigationService.GoBack();
        }

        private void Button_Doc_N(object sender, RoutedEventArgs e)
        {
            vac = vc.GetById(name.Text);
            if (vac != null)
            {
                duration.Text = vac.NumOfDays.ToString();
                if(vac.IsReviewed==true)
                {
                    if(vac.IsAccepted==true)
                    {
                        status.Text = "Accepted";

                    }
                    else
                    {
                        status.Text = "Denied";
                    }
                }
                nzm.SelectedDate = vac.StartDate;

               
            }
        }
    }
}
