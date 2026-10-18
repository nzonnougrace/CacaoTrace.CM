namespace CacaoTrace.CM.Pages;

public partial class ConstitutionLotPage : ContentPage
{
    public ConstitutionLotPage() => InitializeComponent();

    private async void OnBack(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");
}
