using thirsty.Views;

namespace thirsty;

public partial class MainLayout : ContentPage {

    private BarLayout _bar = new BarLayout();
    private Meet _meet = new Meet();

    public MainLayout() {
        InitializeComponent();

        // Abonnement events
        navbar.event_CarteClicked += ShowCarte;
        navbar.event_MeetClicked += ShowMeet;

        // Par défaut au démarrage
        pageContent.Content = _bar;
    }
    
    public void ShowCarte(object sender, EventArgs e) {
        pageContent.Content = _bar;
    }

    public void ShowMeet(object sender, EventArgs e) {
        pageContent.Content = _meet;
    }

}