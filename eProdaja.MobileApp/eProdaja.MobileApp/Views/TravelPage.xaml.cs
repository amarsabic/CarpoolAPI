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
    public partial class TravelPage : ContentPage
    {
        private TravelPageViewModel model = null;
        public TravelPage()
        {
            InitializeComponent();
            BindingContext = model = new TravelPageViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Load();
        }

        private async void RezervacijaClicked(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new TravelRideDetailsPage(((Carpool.Model.Rezervacija)e.SelectedItem).RezervacijaID));
        }
    }
}