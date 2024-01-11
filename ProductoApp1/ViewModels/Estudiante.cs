using CommunityToolkit.Mvvm.ComponentModel;
using ProductoApp1.Models;
using ProductoApp1.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp1.ViewModels
{
    public partial class Estudiante : ObservableObject
    {
        private APIService _APIService;

        [ObservableProperty]
        public ObservableCollection<Producto> listaProductos;

        public Estudiante()
        {

        }
        public void SetAPIService(APIService apiService)
        {
            _APIService = apiService;
        }

    }
}
