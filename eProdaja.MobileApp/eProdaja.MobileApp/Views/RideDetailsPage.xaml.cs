using eProdaja.MobileApp.ViewModels;
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
    public partial class RideDetailsPage : ContentPage
    {
        private RideDetailsViewModel model = null;
        private int? VoznjaID;
        public RideDetailsPage(int? voznjaId)
        {
            InitializeComponent();
            BindingContext = model = new RideDetailsViewModel();
            VoznjaID = voznjaId;
        }

        protected async override void OnAppearing()
        {
            await model.Init((int)VoznjaID);
            await model.LoadOcjene();
        }

        private async void RouteCityReservation(object sender, SelectedItemChangedEventArgs e)
        {
            await model.RouteCityReservation(((Carpool.Model.Grad)e.SelectedItem).GradID);
        }
    }
}