using CacaoTrace.CM.Controls;

namespace CacaoTrace.CM.Pages;

public partial class RecoltesPage : ContentPage
{
    public RecoltesPage() => InitializeComponent();

    private void OnChip(object sender, EventArgs e) => ChipGroup.Select(Chips, (Chip)sender);
}
