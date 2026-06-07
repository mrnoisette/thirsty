using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace thirsty {
    partial class Carte_VM : ObservableObject {

        [ObservableProperty]
        private ObservableCollection<Bar> _listeBar = new();

    }
}
