using ProductoApp1.Services;

namespace ProductoApp1
{
    public partial class MainPage : ContentPage
    {
        private readonly APIService _APIService;
        

        public MainPage(APIService aPIService)
        {
            InitializeComponent();
            _APIService = aPIService;
            
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {

            await App.Current.MainPage.Navigation.PushAsync(new ProductoPage(_APIService));

        }


    }
}