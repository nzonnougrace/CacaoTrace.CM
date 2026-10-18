namespace CacaoTrace.CM.Pages;

public partial class ParcelleFormPage : ContentPage
{
    public ParcelleFormPage() => InitializeComponent();

    private async void OnBack(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");
}
