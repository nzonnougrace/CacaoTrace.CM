namespace CacaoTrace.CM.Controls;

/// <summary>Carte de liste : titre, pastille de statut, ligne d'infos. Route : page ouverte au clic.</summary>
public partial class ListCard : ContentView
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title), typeof(string), typeof(ListCard), string.Empty,
        propertyChanged: (b, o, n) => ((ListCard)b).TitleLbl.Text = (string)n);

    public static readonly BindableProperty SubtitleProperty = BindableProperty.Create(
        nameof(Subtitle), typeof(string), typeof(ListCard), string.Empty,
        propertyChanged: (b, o, n) =>
        {
            var c = (ListCard)b;
            c.SubLbl.Text = (string)n;
            c.SubLbl.IsVisible = !string.IsNullOrEmpty((string)n);
        });

    public static readonly BindableProperty BadgeTextProperty = BindableProperty.Create(
        nameof(BadgeText), typeof(string), typeof(ListCard), string.Empty,
        propertyChanged: (b, o, n) =>
        {
            var c = (ListCard)b;
            c.Bdg.Text = (string)n;
            c.Bdg.IsVisible = !string.IsNullOrEmpty((string)n);
        });

    public static readonly BindableProperty BadgeKindProperty = BindableProperty.Create(
        nameof(BadgeKind), typeof(string), typeof(ListCard), "green",
        propertyChanged: (b, o, n) => ((ListCard)b).Bdg.Kind = (string)n);

    public static readonly BindableProperty RouteProperty =
        BindableProperty.Create(nameof(Route), typeof(string), typeof(ListCard), string.Empty);

    public string Title { get => (string)GetValue(TitleProperty); set => SetValue(TitleProperty, value); }
    public string Subtitle { get => (string)GetValue(SubtitleProperty); set => SetValue(SubtitleProperty, value); }
    public string BadgeText { get => (string)GetValue(BadgeTextProperty); set => SetValue(BadgeTextProperty, value); }
    public string BadgeKind { get => (string)GetValue(BadgeKindProperty); set => SetValue(BadgeKindProperty, value); }
    public string Route { get => (string)GetValue(RouteProperty); set => SetValue(RouteProperty, value); }

    public ListCard() => InitializeComponent();

    private async void OnTapped(object sender, TappedEventArgs e)
    {
        if (!string.IsNullOrEmpty(Route))
            await Shell.Current.GoToAsync(Route);
    }
}
