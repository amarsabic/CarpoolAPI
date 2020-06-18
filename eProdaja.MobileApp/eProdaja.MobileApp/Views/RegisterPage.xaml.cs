﻿using eProdaja.MobileApp.ViewModels;
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
    public partial class RegisterPage : ContentPage
    {
        private RegisterViewModel model = null;
        public RegisterPage()
        {
            InitializeComponent();

            BindingContext = model = new RegisterViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Register();
        }
    }
}