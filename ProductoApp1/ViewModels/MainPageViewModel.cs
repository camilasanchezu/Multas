
using ProductoApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductoApp1.ViewModels
{

    public class MainPageViewModel
    {
        private readonly APIService _APIService;

        public ICommand Productoview =>
            new Command(async () =>
    {
        await App.Current.MainPage.Navigation.PushAsync(new ProductoPage(_APIService));
    });
    }
}
