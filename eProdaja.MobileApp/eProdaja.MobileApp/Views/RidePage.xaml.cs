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
    public partial class RidePage : ContentPage
    {
        private RidePageViewModel model = null;
        public RidePage()
        {
            InitializeComponent();
            BindingContext = model = new RidePageViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Load();
        }

        private async void VoznjaClicked(object sender, SelectedItemChangedEventArgs e)
        {
            if (model.MojeVoznjeBool)
            {
                await Navigation.PushAsync(new AddRidePage(((Carpool.Model.Voznja)e.SelectedItem).VoznjaID));
            }
            else if (model.SveVoznjeBool)
            {
                await Navigation.PushAsync(new RideDetailsPage(((Carpool.Model.Voznja)e.SelectedItem).VoznjaID));
            }
            else
            {
                await Navigation.PushAsync(new RideDetailsPage(((Carpool.Model.Voznja)e.SelectedItem).VoznjaID));
            }
        }
    }
}