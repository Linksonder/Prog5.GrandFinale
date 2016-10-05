using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace GrandFinale.WPF.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<PokemonVM> Pokemons { get; set; }

        public MainViewModel()
        {
            Pokemons = new ObservableCollection<PokemonVM>();
            Pokemons.Add(new ViewModel.PokemonVM()
            {
                Name = "pIKACHUUU",
                Pokindex = 25,
                IsShiny = true,
            });
            Pokemons.Add(new ViewModel.PokemonVM()
            {
                Name = "Psyyduuck",
                Pokindex = 54,
                IsShiny = false,
            });

        }
    }
}