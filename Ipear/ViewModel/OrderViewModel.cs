using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ipear.ViewModel
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            MenuList = GetMenu();
        }
        public List<Pick> MenuList { get; set; }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "IPhone 11 pink", Image = "phone1.png", Description = "128 Gb ", Price = "$560" },
                new Pick { Title = "IPhone 12 red", Image = "phone2.png", Description = "256 Gb", Price = "$720" },
                new Pick { Title = "IPhone 12 blue", Image = "phone3.png", Description = "64 Gb", Price = "$650" },
                new Pick { Title = "Iphone 14 Gold", Image = "phone4.png", Description = "512 Gb", Price = "$1200" },
                new Pick { Title = "IPhone 14 Black Pinck", Image = "phone5.png", Description = "1 Tb", Price = "$1300" }
            };
        }
    }
}
