namespace CacaoTrace.CM.Pages;

public partial class ParcelleDetailPage : ContentPage
{
    public ParcelleDetailPage() => InitializeComponent();

    private async void OnEdit(object sender, EventArgs e) => await Shell.Current.GoToAsync("parcelleform");
    private async void OnAddHarvest(object sender, EventArgs e) => await Shell.Current.GoToAsync("recolteform");
    private async void OnHistory(object sender, EventArgs e) => await Shell.Current.GoToAsync("//Historique");

    private async void OnMenu(object sender, EventArgs e)
    {
        string choix = await DisplayActionSheetAsync("Parcelle Ekona", "Annuler", null,
            "Modifier la parcelle", "Ajouter une récolte", "Voir l'historique");
        switch (choix)
        {
            case "Modifier la parcelle": await Shell.Current.GoToAsync("parcelleform"); break;
            case "Ajouter une récolte": await Shell.Current.GoToAsync("recolteform"); break;
            case "Voir l'historique": await Shell.Current.GoToAsync("//Historique"); break;
        }
    }
}
