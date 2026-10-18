using CacaoTrace.CM.Pages;

namespace CacaoTrace.CM;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Écrans secondaires (navigation par pile, bouton ← pour revenir)
        Routing.RegisterRoute("forgot",       typeof(ForgotPasswordPage));
        Routing.RegisterRoute("actions",      typeof(ActionsPage));
        Routing.RegisterRoute("parcelle",     typeof(ParcelleDetailPage));
        Routing.RegisterRoute("parcelleform", typeof(ParcelleFormPage));
        Routing.RegisterRoute("recoltes",     typeof(RecoltesPage));
        Routing.RegisterRoute("recolteform",  typeof(RecolteFormPage));
        Routing.RegisterRoute("lotdetail",    typeof(LotDetailPage));
        Routing.RegisterRoute("constitution", typeof(ConstitutionLotPage));
        Routing.RegisterRoute("vente",        typeof(VenteConfirmationPage));
        Routing.RegisterRoute("evenement",    typeof(EvenementDetailPage));
        Routing.RegisterRoute("profil",       typeof(ProfilPage));
        Routing.RegisterRoute("profiledit",   typeof(ProfilEditPage));
        Routing.RegisterRoute("motdepasse",   typeof(ChangePasswordPage));
    }
}
