using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProductoApp1.Models;
using ProductoApp1.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductoApp1.ViewModels
{
    public partial class ProductoViewModel : ObservableObject
    {
        private APIService _APIService;

        public ObservableCollection<Producto> Productos { get; private set; }

        [ObservableProperty]
        public ObservableCollection<Producto> listaProductos;


        public ICommand OpenDetailsCommand => new Command<Producto>(async (producto) => await OpenDetailsAsync(producto));
        public ICommand ActualizarListaCommand => new AsyncRelayCommand(ActualizarLista);

        private async Task OpenDetailsAsync (Producto producto)
        {
            await App.Current.MainPage.Navigation.PushAsync(new DetalleProductoPage(_APIService, producto));
        }

        private async Task ActualizarLista()
        {
            List<Producto> listaProductos = await _APIService.GetProductos();
            Productos = new ObservableCollection<Producto>(listaProductos);
            OnPropertyChanged(nameof(Productos));
        }

        public ProductoViewModel()
        {

        }
        public ProductoViewModel(APIService apiservice)
        {
            _APIService = apiservice;
            Productos = new ObservableCollection<Producto>();
            

        }
        public void SetAPIService(APIService apiService)
        {
            _APIService = apiService;
        }

    }
}
