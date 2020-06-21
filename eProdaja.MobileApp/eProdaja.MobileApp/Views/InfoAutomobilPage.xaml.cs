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
    public partial class InfoAutomobilPage : ContentPage
    {
        private readonly int automobilId;
        InfoAutomobilViewModel model = null;
        public InfoAutomobilPage(int AutomobilID)
        {
            InitializeComponent();
            automobilId = AutomobilID;

            BindingContext = model = new InfoAutomobilViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init(automobilId);
        }
    }
}