namespace thirsty.Components;

public partial class Navbar : ContentView {

    public event EventHandler event_CarteClicked;
    public event EventHandler event_MeetClicked;

    private readonly Color colorActiveBubble = Color.FromArgb("#FFDDDD"); // rouge clair
    private readonly Color colorActiveLabel = Color.FromArgb("#FF0000");
    private readonly Color colorInactive = Color.FromArgb("#999999");

    public Navbar() {
        InitializeComponent();
        SetSelected("bar");
    }

    private void OnCarteClicked(object sender, TappedEventArgs e) {
        SetSelected("bar");
        event_CarteClicked?.Invoke(this, EventArgs.Empty);
    }

    private void OnMeetClicked(object sender, TappedEventArgs e) {
        SetSelected("meet");
        event_MeetClicked?.Invoke(this, EventArgs.Empty);
    }

    private void SetSelected(string selected) {
        border_carte.Background = selected == "bar" ? colorActiveBubble : Colors.Transparent;
        border_meet.Background = selected == "meet" ? colorActiveBubble : Colors.Transparent;

        label_carte.TextColor = selected == "bar" ? colorActiveLabel : colorInactive;
        label_meet.TextColor = selected == "meet" ? colorActiveLabel : colorInactive;
    }

}