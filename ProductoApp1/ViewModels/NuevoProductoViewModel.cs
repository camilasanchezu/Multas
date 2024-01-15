using ProductoApp1.Models;
using ProductoApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductoApp1.ViewModels
{
    public class NuevoProductoViewModel
    {
        private readonly APIService _APIService;
        private readonly Producto _producto;

        public string Nombre{ get; set; }
        public string Descripcion { get; set; }
        public int cantidad{ get; set; }
        public NuevoProductoViewModel(Producto producto)
        {
            _APIService = new APIService();
            _producto = producto;
            Nombre=producto.Nombre;
            Descripcion = producto.Descripcion;
            cantidad = producto.cantidad;
        }
        public ICommand Nuevoproducto =>
            new Command(async () =>
            {


                await _APIService.PostProducto(_producto);
                    
                    await App.Current.MainPage.Navigation.PopAsync();
                
            });

    }
}
