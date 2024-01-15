
using Microsoft.Maui;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using System.Collections.ObjectModel;
using ProductoApp1.Models;
using ProductoApp1.Services;
using ProductoApp1.ViewModels;

namespace ProductoApp1;

public partial class ProductoPage : ContentPage
{
    private readonly APIService _APIService;
    private ProductoViewModel _viewModel;
	public ProductoPage(APIService apiservice)
    {
        InitializeComponent();
        _APIService = apiservice;
        _viewModel = new ProductoViewModel(_APIService);
        BindingContext = _viewModel;
        _viewModel.ActualizarListaCommand.Execute(null);
       
    }

    /*protected override async void OnAppearing()
    {
        base.OnAppearing();
        List<Producto> ListaProducto = await _APIService.GetProductos();
        var productos = new ObservableCollection<Producto>(ListaProducto);
        listaProductos.ItemsSource = productos;
    }*/

    private async void OnClickNuevoProducto(object sender, EventArgs e)
    {
        //var toast = Toast.Make("Click en nuevo producto", ToastDuration.Short, 14);

        //await toast.Show();

       await Navigation.PushAsync(new NuevoProductoPage(_APIService));
    }

    private  void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
    {
        Producto producto= e.SelectedItem as Producto;
        ((ProductoViewModel)BindingContext).OpenDetailsCommand.Execute(producto);

        /*if(e.SelectedItem is Producto producto)
        {
            (BindingContext as ProductoViewModel)?.OnClickShowDetails.Execute(producto);
        }*/
    }
}