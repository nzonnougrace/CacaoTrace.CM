using CacaoTrace.CM.Controls;

namespace CacaoTrace.CM.Pages;

public partial class LotsPage : ContentPage
{
    public LotsPage() => InitializeComponent();

    private void OnChip(object sender, EventArgs e) => ChipGroup.Select(Chips, (Chip)sender);
}
