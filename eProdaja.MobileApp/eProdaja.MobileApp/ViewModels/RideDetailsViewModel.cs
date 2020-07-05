using Carpool.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class RideDetailsViewModel
    {
        private readonly APIService _automobili = new APIService("Automobil");
        private readonly APIService _voznja = new APIService("Voznja");
        public RideDetailsViewModel()
        {
            InitCommand = new Command(async (param) => await Init((int)param));
        }

        public ICommand InitCommand { get; set; }

        public async Task Init(int voznjaId)
        {
            try
            {
                var v = await _voznja.GetById<Voznja>(voznjaId);

            }
            catch (Exception)
            {

            }
        }

    }
}
