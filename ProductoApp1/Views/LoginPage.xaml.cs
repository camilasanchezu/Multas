using Android.Net;
using ProductoApp1.Services;
using ProductoApp1.ViewModels;

namespace ProductoApp1.Views;

public partial class LoginPage : ContentPage
{
    private readonly APIService _ApiService;
    private readonly LoginViewModel _viewModel;
    public LoginPage(APIService apiservice)
	{
		InitializeComponent();
        _ApiService = apiservice;
        _viewModel = new LoginViewModel();
        _viewModel.SetAPIService(apiservice);
        BindingContext = _viewModel;
    }

    private async void OnClickIniciarSesion(object sender, EventArgs e)
    {
        int resultado = await _viewModel.OnClickIniciarSesion();
        if (resultado == 1)
        {
            await Navigation.PushAsync(new ProductoPage(_ApiService));
            await DisplayAlert("�xito", $"Bienvenida/o", "OK");
        }
        else
        {
            await DisplayAlert("Ooh! :(", "Campos incompletos o Usuario/Contrase�a Incorrectas", "OK");
        }
    }
   
 }

