using Microsoft.Extensions.Logging;

namespace CacaoTrace.CM;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();

        RemoveNativeBorders();

#if DEBUG
        // AddDebug() requires the Microsoft.Extensions.Logging.Debug package.
        // Uncomment after adding the package reference if needed.
#endif
        return builder.Build();
    }

    /// <summary>
    /// Supprime les bordures/soulignements natifs des Entry et Picker :
    /// le cadre arrondi est dessiné par le Border des contrôles FormField / PickerField.
    /// </summary>
    private static void RemoveNativeBorders()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.Background = null;
#elif WINDOWS
            handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
            handler.PlatformView.Resources["TextControlBorderThemeThicknessFocused"] = new Microsoft.UI.Xaml.Thickness(0);
#endif
        });

        Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.Background = null;
#elif WINDOWS
            handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
            handler.PlatformView.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Transparent);
#endif
        });
    }
}
