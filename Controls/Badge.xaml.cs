namespace CacaoTrace.CM.Controls;

/// <summary>Pastille de statut. Kind : green | amber | red | grey</summary>
public partial class Badge : ContentView
{
    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text), typeof(string), typeof(Badge), string.Empty,
        propertyChanged: (b, o, n) => ((Badge)b).Lbl.Text = (string)n);

    public static readonly BindableProperty KindProperty = BindableProperty.Create(
        nameof(Kind), typeof(string), typeof(Badge), "green",
        propertyChanged: (b, o, n) => ((Badge)b).Apply((string)n));

    public string Text { get => (string)GetValue(TextProperty); set => SetValue(TextProperty, value); }
    public string Kind { get => (string)GetValue(KindProperty); set => SetValue(KindProperty, value); }

    public Badge()
    {
        InitializeComponent();
        Apply("green");
    }

    private void Apply(string kind)
    {
        (string bg, string fg) = kind switch
        {
            "amber" => ("#FFF8E1", "#F9A825"),
            "red"   => ("#FFEBEE", "#D32F2F"),
            "grey"  => ("#EEEEEE", "#757575"),
            _       => ("#E8F5E9", "#2E7D32"),
        };
        Box.BackgroundColor = Color.FromArgb(bg);
        Lbl.TextColor = Color.FromArgb(fg);
    }
}
