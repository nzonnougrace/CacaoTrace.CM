namespace CacaoTrace.CM.Pages;

public partial class DashboardPage : ContentPage
{
    public DashboardPage() => InitializeComponent();

    private async void OnNav(object sender, TappedEventArgs e) =>
        await Shell.Current.GoToAsync((string)e.Parameter);
}
