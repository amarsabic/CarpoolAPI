using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.MobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Automobili
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
