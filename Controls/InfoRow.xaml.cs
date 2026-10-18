namespace CacaoTrace.CM.Controls;

/// <summary>Ligne « libellé ........ valeur » dans une carte.</summary>
public partial class InfoRow : ContentView
{
    public static readonly BindableProperty CaptionProperty =
        BindableProperty.Create(nameof(Caption), typeof(string), typeof(InfoRow), string.Empty);
    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create(nameof(Value), typeof(string), typeof(InfoRow), string.Empty);

    public string Caption { get => (string)GetValue(CaptionProperty); set => SetValue(CaptionProperty, value); }
    public string Value { get => (string)GetValue(ValueProperty); set => SetValue(ValueProperty, value); }

    public InfoRow() => InitializeComponent();
}
