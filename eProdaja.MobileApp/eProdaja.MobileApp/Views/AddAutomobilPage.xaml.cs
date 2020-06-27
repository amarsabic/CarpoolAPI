using eProdaja.MobileApp.Services;
using eProdaja.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eProdaja.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAutomobilPage : ContentPage
    {
        private AddAutomobilViewModel model = null;
        private readonly int? AutomobilID;
        public AddAutomobilPage(int? automobilID)
        {
            InitializeComponent();
            AutomobilID = automobilID;
            BindingContext = model = new AddAutomobilViewModel();
        }

        async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;

            Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            if (stream != null)
            {
                byte[] slika = null;
                // image.Source = ImageSource.FromStream(() => stream);
                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    slika = ms.ToArray();
                    model.Slika = slika;
                    model.SlikaThumb = slika;
                }
            }

             (sender as Button).IsEnabled = true;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if (AutomobilID != null)
            {
                await model.Init((int)AutomobilID);
            }
        }

    }
}