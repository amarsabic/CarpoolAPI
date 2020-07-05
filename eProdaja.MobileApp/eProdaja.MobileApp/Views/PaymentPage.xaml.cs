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
    public partial class PaymentPage : ContentPage
    {
        private PaymentViewModel model = null;
        private int VoznjaID;
        public PaymentPage(int voznjaId)
        {
            InitializeComponent();
            BindingContext = model = new PaymentViewModel();
            VoznjaID = voznjaId;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init(VoznjaID);
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}