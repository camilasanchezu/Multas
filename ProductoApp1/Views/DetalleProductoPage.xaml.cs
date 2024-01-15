using CommunityToolkit.Maui.Core;
using ProductoApp1.Models;
using ProductoApp1.Services;
using ProductoApp1.ViewModels;

namespace ProductoApp1;

public partial class DetalleProductoPage : ContentPage
{
    private Producto _producto;
    private readonly APIService _APIService;
    private DetalleViewModel _viewModel;

    public DetalleProductoPage(APIService apiservice,Producto producto)
	{
		InitializeComponent();
        _APIService = apiservice;
        _viewModel = new DetalleViewModel(_APIService);
        BindingContext= _viewModel;
        _viewModel.Initialize(producto);

    }

   


    private async void OnClickBorrar(object sender, EventArgs e)
    {
        //Utils.Utils.ListaProductos.Remove(_producto);
        await _APIService.DeleteProducto(_producto.IdProducto);
        await Navigation.PopAsync();
    }

    private async void OnClickEditar(object sender, EventArgs e)
    {
        var toast = CommunityToolkit.Maui.Alerts.Toast.Make(_producto.Nombre, ToastDuration.Short, 14);

        await toast.Show();
        await Navigation.PushAsync(new NuevoProductoPage(_APIService) { 
            BindingContext = _producto,
       });
    }


}