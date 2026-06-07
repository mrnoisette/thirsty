using CommunityToolkit.Mvvm.ComponentModel;

namespace thirsty {
    public partial class Preferences : ObservableObject {

        [ObservableProperty]
        private int _rayonMax;

        [ObservableProperty]
        private TypeIntention _intention;

        [ObservableProperty]
        private int _ageMin;

        [ObservableProperty]
        private int _ageMax;

        [ObservableProperty]
        private TypeSexe _sexe;

    }
}
