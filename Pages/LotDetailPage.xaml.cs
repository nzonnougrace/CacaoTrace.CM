namespace CacaoTrace.CM.Pages;

public partial class LotDetailPage : ContentPage
{
    public LotDetailPage() => InitializeComponent();

    private async void OnSell(object sender, EventArgs e) => await Shell.Current.GoToAsync("vente");

    private async void OnMenu(object sender, EventArgs e)
    {
        string choix = await DisplayActionSheetAsync("Lot L-2026-014", "Annuler", null,
            "Voir la preuve de traçabilité", "Mettre en vente");
        if (choix == "Voir la preuve de traçabilité") await Shell.Current.GoToAsync("evenement");
        else if (choix == "Mettre en vente") await Shell.Current.GoToAsync("vente");
    }
}
