namespace CacaoTrace.CM.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage() => InitializeComponent();

    private async void OnLogin(object sender, EventArgs e) => await Shell.Current.GoToAsync("//Dashboard");
    private async void OnRegister(object sender, EventArgs e) => await Shell.Current.GoToAsync("//Register");
    private async void OnForgot(object sender, TappedEventArgs e) => await Shell.Current.GoToAsync("forgot");
}
