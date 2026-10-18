namespace CacaoTrace.CM.Pages;

public partial class ChangePasswordPage : ContentPage
{
    public ChangePasswordPage() => InitializeComponent();

    private async void OnBack(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");
}
