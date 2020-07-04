using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eProdaja.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : TabbedPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            //if (APIService.IsVozac)
            //{
            //    this.Children.Add(new PassengerProfilePage { Title = "Početna", IconImageSource = "icons8-home-50.png" });
            //    this.Children.Add(new PassengerProfilePage { Title = "Profil", IconImageSource = "icons8-user-male-50.png" });
            //    this.Children.Add(new AutomobiliPage { Title = "Automobili", IconImageSource = "icons8-car-50.png" });
            //    this.Children.Add(new NewsPage { Title = "Obavijesti", IconImageSource = "icons8-news-50.png" });
            //    this.Children.Add(new RidePage { Title = "Voznje", IconImageSource = "icons8-vanpool-50.png" });
            //}
            //else
            //{
            //    this.Children.Add(new PassengerProfilePage { Title = "Početna", IconImageSource = "icons8-home-50.png" });
            //    this.Children.Add(new PassengerProfilePage { Title = "Profil", IconImageSource = "icons8-user-male-50.png" });
            //    this.Children.Add(new NewsPage { Title = "Obavijesti", IconImageSource = "icons8-news-50.png" });
            //    this.Children.Add(new RidePage { Title = "Voznje", IconImageSource = "icons8-vanpool-50.png" });
            //}
        }
    }
}