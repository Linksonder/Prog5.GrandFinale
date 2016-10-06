using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GrandFinale.WPF.ViewModel
{
    public class AddPokemonVM
    {
        private MainViewModel main;

        public PokemonVM Pokemon { get; set; }

        public ICommand SavePokemonCommand { get; set; }

        public AddPokemonVM(MainViewModel main)
        {
            this.main = main;
            Pokemon = new PokemonVM();
            SavePokemonCommand = new RelayCommand<AddPokemonWindow>(SavePokemon);
        }

        private void SavePokemon(AddPokemonWindow window)
        {
            //Zien we zo wel.
            Pokemon.Pokindex = -1;
            main.Pokemons.Add(Pokemon);
            window.Close();
           
        }
    }
}
