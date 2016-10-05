using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;

namespace GrandFinale.WPF.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private AddPokemonWindow _window;

        public ICommand AddPokemonCommand { get; set; }

        public ObservableCollection<PokemonVM> Pokemons { get; set; }

        public MainViewModel()
        {
            AddPokemonCommand = new RelayCommand(AddPokemon);

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

        internal void AddPokemon(PokemonVM pokemon)
        {
            //View hiden
            _window.Close();
        }

    }
}