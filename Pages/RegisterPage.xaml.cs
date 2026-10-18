namespace CacaoTrace.CM.Pages;

public partial class RegisterPage : ContentPage
{
    public RegisterPage() => InitializeComponent();

    private async void OnRegister(object sender, EventArgs e) => await Shell.Current.GoToAsync("//Dashboard");
    private async void OnLogin(object sender, TappedEventArgs e) => await Shell.Current.GoToAsync("//Login");
}
