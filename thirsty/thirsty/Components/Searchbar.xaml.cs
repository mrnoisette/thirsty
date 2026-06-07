using CommunityToolkit.Maui.Extensions;

namespace thirsty.Components;

public partial class Searchbar : ContentView {

    public event EventHandler event_AfficherCarte;
    public event EventHandler event_AfficherListe;

    public Searchbar() { 
        InitializeComponent();
    }

    private async void Ajout_Clicked(object sender, TappedEventArgs e) {
        var mainPage = Application.Current.MainPage;
        await mainPage.ShowPopupAsync(new AjoutBar());
    }

    private async void Filtre_Clicked(object sender, TappedEventArgs e) {
        var mainPage = Application.Current.MainPage;
        await mainPage.ShowPopupAsync(new FiltreBar());
    }

    private void AfficherCarte_Clicked(object sender, EventArgs e) {
        this.borderBtnCarte.Background = Color.FromArgb("#db353a");
        this.borderBtnListe.Background = Colors.Transparent;

        this.btnCarte.TextColor = Colors.White;
        this.btnListe.TextColor = Colors.Grey;

        event_AfficherCarte?.Invoke(this, e);
    }

    private void AfficherListe_Clicked(object sender, EventArgs e) {
        this.borderBtnCarte.Background = Colors.Transparent;
        this.borderBtnListe.Background = Color.FromArgb("#db353a");

        this.btnCarte.TextColor = Colors.Grey;
        this.btnListe.TextColor = Colors.White;

        event_AfficherListe?.Invoke(this, e);
    }
}