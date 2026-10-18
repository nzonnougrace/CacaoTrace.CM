namespace CacaoTrace.CM.Pages;

public partial class RecolteFormPage : ContentPage
{
    public RecolteFormPage() => InitializeComponent();

    private async void OnBack(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");
}
