using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using ProductoApp1.Models;
using ProductoApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp1.ViewModels
{
    public class DetalleViewModel : ObservableRecipient
    {
        private readonly APIService _APIService;
        private Producto _producto;
        public string Nombre => _producto?.Nombre;
        public int Cantidad => _producto?.cantidad?? 0;
        public string Descripcion => _producto?.Descripcion;
        public DetalleViewModel()
        {
            
        }

        public DetalleViewModel(APIService aPIService) 
        {
            _APIService = aPIService;
        }

        public async Task Initialize (Producto producto)
        {
            _producto = producto;
            OnPropertyChanged (nameof(Nombre));
            OnPropertyChanged (nameof(Cantidad));
            OnPropertyChanged(nameof(Descripcion));
        }


    }
}
