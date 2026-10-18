namespace CacaoTrace.CM.Pages;

public partial class VenteConfirmationPage : ContentPage
{
    public VenteConfirmationPage() => InitializeComponent();

    private async void OnLots(object sender, EventArgs e) => await Shell.Current.GoToAsync("//Lots");
    private async void OnHistory(object sender, EventArgs e) => await Shell.Current.GoToAsync("//Historique");
}
