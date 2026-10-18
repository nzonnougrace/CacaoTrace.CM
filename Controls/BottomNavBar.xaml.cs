namespace CacaoTrace.CM.Controls;

/// <summary>Barre de navigation à 4 onglets. ActiveTab : Accueil | Parcelles | Lots | Historique</summary>
public partial class BottomNavBar : ContentView
{
    public static readonly BindableProperty ActiveTabProperty = BindableProperty.Create(
        nameof(ActiveTab), typeof(string), typeof(BottomNavBar), "Accueil",
        propertyChanged: (b, o, n) => ((BottomNavBar)b).Apply((string)n));

    public string ActiveTab { get => (string)GetValue(ActiveTabProperty); set => SetValue(ActiveTabProperty, value); }

    public BottomNavBar()
    {
        InitializeComponent();
        Apply("Accueil");
    }

    private void Apply(string tab)
    {
        Style(TabAccueil, tab == "Accueil");
        Style(TabParcelles, tab == "Parcelles");
        Style(TabLots, tab == "Lots");
        Style(TabHistorique, tab == "Historique");
    }

    private static void Style(Label label, bool active)
    {
        label.TextColor = Color.FromArgb(active ? "#5D4037" : "#757575");
        label.FontAttributes = active ? FontAttributes.Bold : FontAttributes.None;
    }

    private async void OnTab(object sender, TappedEventArgs e) =>
        await Shell.Current.GoToAsync((string)e.Parameter);
}
