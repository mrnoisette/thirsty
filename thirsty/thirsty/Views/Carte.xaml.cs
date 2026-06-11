using Mapsui;
using Mapsui.Limiting;
using Mapsui.Projections;
using Mapsui.UI.Maui;

namespace thirsty.Views;

public partial class Carte : ContentView {

    private Carte_VM ViewModel {
        get { return this.BindingContext as Carte_VM; }
    }

    public Carte() {
        InitializeComponent();

        this.map.Map?.Layers.Add(
            Mapsui.Tiling.OpenStreetMap.CreateTileLayer()
        );

        // Limites France 
        var (minX, minY) = SphericalMercator.FromLonLat(-5.1, 41.3);
        var (maxX, maxY) = SphericalMercator.FromLonLat(9.6, 51.1);
        var limites = new MRect(minX, minY, maxX, maxY);
        this.map.Map.Navigator.Limiter = new ViewportLimiterKeepWithinExtent();
        this.map.Map.Navigator.RotationLock = true;
        this.map.Map.Navigator.OverridePanBounds = limites;

        // Ajout pin test
        this.map.Pins.Add(new Pin() {
            Position = new Position(48.8566, 2.3522),
            Type = PinType.Pin,
        });

        this.map.PinClicked += OnPinClicked;
    }

    private async void OnPinClicked(object sender, PinClickedEventArgs e) {
        // TODO : Afficher une popup avec des informations sur le pin
    }

}