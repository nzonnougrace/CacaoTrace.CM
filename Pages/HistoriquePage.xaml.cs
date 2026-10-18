using CacaoTrace.CM.Controls;

namespace CacaoTrace.CM.Pages;

public partial class HistoriquePage : ContentPage
{
    public HistoriquePage() => InitializeComponent();

    private void OnChip(object sender, EventArgs e) => ChipGroup.Select(Chips, (Chip)sender);
}
