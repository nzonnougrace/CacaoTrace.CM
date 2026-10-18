namespace CacaoTrace.CM.Pages;

public partial class ForgotPasswordPage : ContentPage
{
    public ForgotPasswordPage() => InitializeComponent();

    private async void OnBack(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");

    private async void OnSend(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Lien envoyé", "Vérifiez votre boîte de réception.", "OK");
        await Shell.Current.GoToAsync("..");
    }
}
