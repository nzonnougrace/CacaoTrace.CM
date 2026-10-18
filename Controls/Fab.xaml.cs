namespace CacaoTrace.CM.Controls;

/// <summary>Bouton d'action flottant « + ». Route : page ouverte au clic.</summary>
public partial class Fab : ContentView
{
    public static readonly BindableProperty RouteProperty =
        BindableProperty.Create(nameof(Route), typeof(string), typeof(Fab), "actions");

    public string Route { get => (string)GetValue(RouteProperty); set => SetValue(RouteProperty, value); }

    public Fab() => InitializeComponent();

    private async void OnTapped(object sender, TappedEventArgs e) =>
        await Shell.Current.GoToAsync(Route);
}
