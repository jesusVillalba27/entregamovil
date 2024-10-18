namespace proyecto5
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            // Acción al hacer clic en el botón
            await DisplayAlert("Información", "Ronaldo es conocido como 'El Fenómeno' por su increíble habilidad en el fútbol.", "OK");
        }
    }

}
