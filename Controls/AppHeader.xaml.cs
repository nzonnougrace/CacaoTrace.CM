namespace CacaoTrace.CM.Controls;

/// <summary>Barre d'en-tête marron : ← retour, titre, avatar « AF » ou menu ⋮.</summary>
public partial class AppHeader : ContentView
{
    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(AppHeader), string.Empty);
    public static readonly BindableProperty ShowBackProperty =
        BindableProperty.Create(nameof(ShowBack), typeof(bool), typeof(AppHeader), false);
    public static readonly BindableProperty ShowAvatarProperty =
        BindableProperty.Create(nameof(ShowAvatar), typeof(bool), typeof(AppHeader), false);
    public static readonly BindableProperty ShowMenuProperty =
        BindableProperty.Create(nameof(ShowMenu), typeof(bool), typeof(AppHeader), false);
    public static readonly BindableProperty BackRouteProperty =
        BindableProperty.Create(nameof(BackRoute), typeof(string), typeof(AppHeader), "..");

    public string Title { get => (string)GetValue(TitleProperty); set => SetValue(TitleProperty, value); }
    public bool ShowBack { get => (bool)GetValue(ShowBackProperty); set => SetValue(ShowBackProperty, value); }
    public bool ShowAvatar { get => (bool)GetValue(ShowAvatarProperty); set => SetValue(ShowAvatarProperty, value); }
    public bool ShowMenu { get => (bool)GetValue(ShowMenuProperty); set => SetValue(ShowMenuProperty, value); }
    public string BackRoute { get => (string)GetValue(BackRouteProperty); set => SetValue(BackRouteProperty, value); }

    public event EventHandler MenuClicked;

    public AppHeader() => InitializeComponent();

    private async void OnBackTapped(object sender, TappedEventArgs e) =>
        await Shell.Current.GoToAsync(string.IsNullOrEmpty(BackRoute) ? ".." : BackRoute);

    private async void OnAvatarTapped(object sender, TappedEventArgs e) =>
        await Shell.Current.GoToAsync("profil");

    private void OnMenuTapped(object sender, TappedEventArgs e) =>
        MenuClicked?.Invoke(this, EventArgs.Empty);
}
