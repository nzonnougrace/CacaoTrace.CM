namespace CacaoTrace.CM.Pages;

public partial class EvenementDetailPage : ContentPage
{
    public EvenementDetailPage() => InitializeComponent();

    private async void OnBack(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");
}
