using eProdaja.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _korisnik = new APIService("Korisnik");
  
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            GoRegisterPageCommand = new Command(async () => await GoRegisterPage());
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand GoRegisterPageCommand { get; set; }

        async Task GoRegisterPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RegisterPage()); 
        }
        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                await _korisnik.Get<dynamic>(null);
                Application.Current.MainPage = new NavigationPage(new WelcomePage());
            }
            catch (Exception)
            {

            }
        }
    }
}
