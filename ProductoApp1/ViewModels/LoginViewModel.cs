using CommunityToolkit.Mvvm.ComponentModel;
using ProductoApp1.Models;
using ProductoApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp1.ViewModels
{

    public partial class LoginViewModel : ObservableObject
    {
        private APIService _APIService;
        [ObservableProperty]
       
        public int IdProducto;

        public LoginViewModel()
        {

        }
        public void SetAPIService(APIService apiService)
        {
            _APIService = apiService;
        }

        public async Task<int> OnClickIniciarSesion()
        {
            Producto producto = await _APIService.GetProducto(IdProducto);
            if (producto != null)
            {
                return 1;
            }
            else
            {

                return 0;
            }
        }

    }
}
