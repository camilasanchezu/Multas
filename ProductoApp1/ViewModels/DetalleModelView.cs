using ProductoApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp1.ViewModels
{
    public class DetalleModelView
    {



        public DetalleModelView() { 
        
        }

        public void SetAPIService(APIService apiService)
        {
            _ApiService = apiService;
        }


    }
}
