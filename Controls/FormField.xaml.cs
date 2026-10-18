namespace CacaoTrace.CM.Controls;

/// <summary>Champ de saisie : libellé + cadre arrondi + Entry (option : œil mot de passe).</summary>
public partial class FormField : ContentView
{
    public static readonly BindableProperty CaptionProperty =
        BindableProperty.Create(nameof(Caption), typeof(string), typeof(FormField), string.Empty);
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(FormField), string.Empty, BindingMode.TwoWay);
    public static readonly BindableProperty PlaceholderProperty =
        BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(FormField), string.Empty);
    public static readonly BindableProperty IsPasswordProperty =
        BindableProperty.Create(nameof(IsPassword), typeof(bool), typeof(FormField), false);
    public static readonly BindableProperty ShowToggleProperty =
        BindableProperty.Create(nameof(ShowToggle), typeof(bool), typeof(FormField), false);
    public static readonly BindableProperty KeyboardProperty =
        BindableProperty.Create(nameof(Keyboard), typeof(Keyboard), typeof(FormField), Keyboard.Default);

    public string Caption { get => (string)GetValue(CaptionProperty); set => SetValue(CaptionProperty, value); }
    public string Text { get => (string)GetValue(TextProperty); set => SetValue(TextProperty, value); }
    public string Placeholder { get => (string)GetValue(PlaceholderProperty); set => SetValue(PlaceholderProperty, value); }
    public bool IsPassword { get => (bool)GetValue(IsPasswordProperty); set => SetValue(IsPasswordProperty, value); }
    public bool ShowToggle { get => (bool)GetValue(ShowToggleProperty); set => SetValue(ShowToggleProperty, value); }
    public Keyboard Keyboard { get => (Keyboard)GetValue(KeyboardProperty); set => SetValue(KeyboardProperty, value); }

    public FormField() => InitializeComponent();

    private void OnFocused(object sender, FocusEventArgs e) =>
        Box.Stroke = new SolidColorBrush(Color.FromArgb("#5D4037"));

    private void OnUnfocused(object sender, FocusEventArgs e) =>
        Box.Stroke = new SolidColorBrush(Color.FromArgb("#E0E0E0"));

    private void OnToggle(object sender, TappedEventArgs e) =>
        Input.IsPassword = !Input.IsPassword;
}
