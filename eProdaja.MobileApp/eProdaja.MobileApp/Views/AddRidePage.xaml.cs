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
    public partial class AddRidePage : ContentPage
    {
        private AddRideViewModel model = null;
        public AddRidePage()
        {
            InitializeComponent();
            BindingContext = model = new AddRideViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.LoadAutomobili();
            await model.LoadGradovi();
        }

        private async void UsputniClicked(object sender, SelectedItemChangedEventArgs e)
        {
             await model.DeleteUsputni(((Carpool.Model.Grad)e.SelectedItem).GradID);
        }
    }
}