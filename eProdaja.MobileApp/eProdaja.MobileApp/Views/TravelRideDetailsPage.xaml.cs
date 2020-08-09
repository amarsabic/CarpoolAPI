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
    public partial class TravelRideDetailsPage : ContentPage
    {
        private TravelRideDetailsViewModel model = null;
        private int RezervacijaID;

        public TravelRideDetailsPage(int rezervacijaId)
        {
            InitializeComponent();
            BindingContext = model = new TravelRideDetailsViewModel();
            RezervacijaID = rezervacijaId;
        }

        protected async override void OnAppearing()
        {
            await model.Init((int)RezervacijaID);
        }
    }
}