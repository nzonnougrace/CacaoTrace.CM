using System.Collections;

namespace CacaoTrace.CM.Controls;

/// <summary>Liste déroulante avec libellé et cadre arrondi (Région, Campagne, Variété…).</summary>
public partial class PickerField : ContentView
{
    public static readonly BindableProperty CaptionProperty = BindableProperty.Create(
        nameof(Caption), typeof(string), typeof(PickerField), string.Empty,
        propertyChanged: (b, o, n) => ((PickerField)b).Cap.Text = (string)n);

    public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create(
        nameof(ItemsSource), typeof(IList), typeof(PickerField), null,
        propertyChanged: (b, o, n) =>
        {
            var f = (PickerField)b;
            f.Pk.ItemsSource = (IList)n;
            f.Sync();
        });

    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(
        nameof(SelectedItem), typeof(object), typeof(PickerField), null, BindingMode.TwoWay,
        propertyChanged: (b, o, n) => ((PickerField)b).Sync());

    public string Caption { get => (string)GetValue(CaptionProperty); set => SetValue(CaptionProperty, value); }
    public IList ItemsSource { get => (IList)GetValue(ItemsSourceProperty); set => SetValue(ItemsSourceProperty, value); }
    public object SelectedItem { get => GetValue(SelectedItemProperty); set => SetValue(SelectedItemProperty, value); }

    public PickerField() => InitializeComponent();

    private void Sync()
    {
        if (SelectedItem != null && Pk.ItemsSource != null)
            Pk.SelectedItem = SelectedItem;
    }

    private void OnChanged(object sender, EventArgs e)
    {
        if (Pk.SelectedItem != null)
            SelectedItem = Pk.SelectedItem;
    }
}
