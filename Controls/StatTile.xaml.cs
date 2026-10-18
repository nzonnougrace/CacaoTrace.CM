namespace CacaoTrace.CM.Controls;

/// <summary>Petite carte « libellé / valeur » (fiches parcelle et lot).</summary>
public partial class StatTile : ContentView
{
    public static readonly BindableProperty CaptionProperty =
        BindableProperty.Create(nameof(Caption), typeof(string), typeof(StatTile), string.Empty);
    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create(nameof(Value), typeof(string), typeof(StatTile), string.Empty);

    public string Caption { get => (string)GetValue(CaptionProperty); set => SetValue(CaptionProperty, value); }
    public string Value { get => (string)GetValue(ValueProperty); set => SetValue(ValueProperty, value); }

    public StatTile() => InitializeComponent();
}
