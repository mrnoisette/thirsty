using Mapsui;
using Mapsui.Limiting;
using Mapsui.Projections;

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
    }

}