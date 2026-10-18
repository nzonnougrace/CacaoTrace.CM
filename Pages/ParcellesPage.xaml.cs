using CacaoTrace.CM.Controls;

namespace CacaoTrace.CM.Pages;

public partial class ParcellesPage : ContentPage
{
    public ParcellesPage() => InitializeComponent();

    private void OnChip(object sender, EventArgs e) => ChipGroup.Select(Chips, (Chip)sender);
}
