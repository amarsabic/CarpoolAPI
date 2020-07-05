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
    public partial class ReservationPage : ContentPage
    {
        private ReservationViewModel model = null;
        private int VoznjaID;
        public ReservationPage(int voznjaId)
        {
            InitializeComponent();
            BindingContext = model = new ReservationViewModel();
            VoznjaID = voznjaId;
        }
    }
}