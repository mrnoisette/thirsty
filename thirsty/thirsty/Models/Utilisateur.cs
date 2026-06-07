using CommunityToolkit.Mvvm.ComponentModel;

namespace thirsty {
    public partial class Utilisateur : ObservableObject {

        [ObservableProperty]
        private string _nom;

        [ObservableProperty]
        private string _prenom;

        [ObservableProperty]
        private TypeSexe _sexe;

        [ObservableProperty]
        private int _age;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _telephone;

        [ObservableProperty]
        private string _bio;

        //[ObservableProperty]
        //private List<Bar> _listeBarFavoris;

        [ObservableProperty]
        private Preferences _preferences;

    }
}