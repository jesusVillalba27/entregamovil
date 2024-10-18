namespace proyecto5
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigateToAnuarPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnuarPage());
        }
    }

}
