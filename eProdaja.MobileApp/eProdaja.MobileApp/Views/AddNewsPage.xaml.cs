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
    public partial class AddNewsPage : ContentPage
    {
        private AddNewsViewModel model = null;
        private int? ObavijestiID;
        public AddNewsPage(int? obavijestiID)
        {
            InitializeComponent();
            ObavijestiID = obavijestiID;

            BindingContext = model = new AddNewsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.LoadTipovi();

            if (ObavijestiID != null)
            {
                await model.Init((int)ObavijestiID);
            }
        }
    }
}