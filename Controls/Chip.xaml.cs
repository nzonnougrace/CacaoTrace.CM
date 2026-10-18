namespace CacaoTrace.CM.Controls;

/// <summary>Filtre « pilule » sélectionnable.</summary>
public partial class Chip : ContentView
{
    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text), typeof(string), typeof(Chip), string.Empty,
        propertyChanged: (b, o, n) => ((Chip)b).Lbl.Text = (string)n);

    public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create(
        nameof(IsSelected), typeof(bool), typeof(Chip), false,
        propertyChanged: (b, o, n) => ((Chip)b).Apply((bool)n));

    public string Text { get => (string)GetValue(TextProperty); set => SetValue(TextProperty, value); }
    public bool IsSelected { get => (bool)GetValue(IsSelectedProperty); set => SetValue(IsSelectedProperty, value); }

    public event EventHandler Tapped;

    public Chip() => InitializeComponent();

    private void Apply(bool selected)
    {
        Box.BackgroundColor = selected ? Color.FromArgb("#5D4037") : Colors.White;
        Box.Stroke = new SolidColorBrush(selected ? Color.FromArgb("#5D4037") : Color.FromArgb("#E0E0E0"));
        Lbl.TextColor = selected ? Colors.White : Color.FromArgb("#757575");
    }

    private void OnTapped(object sender, TappedEventArgs e) => Tapped?.Invoke(this, EventArgs.Empty);
}

public static class ChipGroup
{
    /// <summary>Sélectionne un chip et désélectionne les autres de la même rangée.</summary>
    public static void Select(Layout row, Chip selected)
    {
        foreach (var chip in row.Children.OfType<Chip>())
            chip.IsSelected = chip == selected;
    }
}
