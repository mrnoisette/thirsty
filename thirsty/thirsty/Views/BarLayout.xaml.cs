using thirsty.Components;

namespace thirsty.Views;

public partial class BarLayout : ContentView {

    public BarLayout() {
        InitializeComponent();

        // Events
        searchbar.event_AfficherCarte += AfficherCarte;
        searchbar.event_AfficherListe += AfficherListe;

        this.carte.IsVisible = true;
        this.listeBar.IsVisible = false;
    }

    private void AfficherCarte(object sender, EventArgs e) {
        this.carte.IsVisible = true;
        this.listeBar.IsVisible = false;
    }

    private void AfficherListe(object sender, EventArgs e) {
        this.carte.IsVisible = false;
        this.listeBar.IsVisible = true;
    }

}