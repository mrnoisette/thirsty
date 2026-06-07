using CommunityToolkit.Maui.Views;

namespace thirsty.Components;

public partial class AjoutBar : Popup {
    public AjoutBar() {
        InitializeComponent();

        VerticalOptions = LayoutOptions.End;
        HorizontalOptions = LayoutOptions.Fill;
        CanBeDismissedByTappingOutsideOfPopup = true;

        this.DesiredSize = new Size(DeviceDisplay.MainDisplayInfo.Width /
                        DeviceDisplay.MainDisplayInfo.Density,
                        DeviceDisplay.MainDisplayInfo.Height /
                        DeviceDisplay.MainDisplayInfo.Density / 2);
    }

    private void Ajouter_Clicked(object sender, EventArgs e) {
        this.CloseAsync();
    }

}