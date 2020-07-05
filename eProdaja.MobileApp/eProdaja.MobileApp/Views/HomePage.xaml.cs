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
    public partial class HomePage : ContentPage
    {
        private RidePageViewModel model = null;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = model = new RidePageViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Last5();
        }

        private async void VoznjaClicked(object sender, SelectedItemChangedEventArgs e)
        {
           await Navigation.PushAsync(new RideDetailsPage(((Carpool.Model.Voznja)e.SelectedItem).VoznjaID));
        }
    }
}