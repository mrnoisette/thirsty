using CommunityToolkit.Mvvm.ComponentModel;

namespace thirsty {
    partial class Bar : ObservableObject {

        [ObservableProperty]
        private string _nom;

        [ObservableProperty]
        private TypeBar _type;

        [ObservableProperty]
        private int _note;

        [ObservableProperty]
        private string _adresse;

        [ObservableProperty]
        private string _ville;

        [ObservableProperty]
        private string _postalCode;

        // Permet de savoir si l'admin à approuvé le bar (visible ou non en conséquence)
        [ObservableProperty]
        private bool _approved;

    }
}
