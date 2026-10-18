namespace CacaoTrace.CM;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = new Window(new AppShell()) { Title = "CacaoTrace CM" };
#if WINDOWS
        // Taille « téléphone » pour retrouver les proportions de la maquette
        window.Width = 430;
        window.Height = 880;
#endif
        return window;
    }
}
