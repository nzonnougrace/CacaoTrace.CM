namespace CacaoTrace.CM.Pages;

public partial class ProfilEditPage : ContentPage
{
    public ProfilEditPage() => InitializeComponent();

    private async void OnBack(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");
    private async void OnPassword(object sender, EventArgs e) => await Shell.Current.GoToAsync("motdepasse");
}
