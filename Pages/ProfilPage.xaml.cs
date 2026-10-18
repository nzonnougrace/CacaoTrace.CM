namespace CacaoTrace.CM.Pages;

public partial class ProfilPage : ContentPage
{
    public ProfilPage() => InitializeComponent();

    private async void OnEdit(object sender, EventArgs e) => await Shell.Current.GoToAsync("profiledit");

    private async void OnLogout(object sender, EventArgs e)
    {
        bool confirme = await DisplayAlertAsync("Déconnexion",
            "Voulez-vous vraiment vous déconnecter ?", "Se déconnecter", "Annuler");
        if (confirme)
            await Shell.Current.GoToAsync("//Login");
    }
}
