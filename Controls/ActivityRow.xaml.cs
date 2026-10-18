namespace CacaoTrace.CM.Controls;

/// <summary>Ligne d'activité (tableau de bord et historique).</summary>
public partial class ActivityRow : ContentView
{
    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(ActivityRow), string.Empty);
    public static readonly BindableProperty SubtitleProperty =
        BindableProperty.Create(nameof(Subtitle), typeof(string), typeof(ActivityRow), string.Empty);
    public static readonly BindableProperty RouteProperty =
        BindableProperty.Create(nameof(Route), typeof(string), typeof(ActivityRow), "evenement");

    public string Title { get => (string)GetValue(TitleProperty); set => SetValue(TitleProperty, value); }
    public string Subtitle { get => (string)GetValue(SubtitleProperty); set => SetValue(SubtitleProperty, value); }
    public string Route { get => (string)GetValue(RouteProperty); set => SetValue(RouteProperty, value); }

    public ActivityRow() => InitializeComponent();

    private async void OnTapped(object sender, TappedEventArgs e)
    {
        if (!string.IsNullOrEmpty(Route))
            await Shell.Current.GoToAsync(Route);
    }
}
