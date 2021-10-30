using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaPoo04
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }
        
        private List<Pokemon> pokemons;
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            this.pokemons = new List<Pokemon>();

            Pokemon p = new Pokemon("Pichu", "Pokemon tipo eletrico");
            this.pokemons.Add(p);
            p = new Pokemon("Pikachu", "Pokemon tipo eletrico");
            this.pokemons.Add(p);
            p = new Pokemon("Mew", "Lendario psiquico");
            this.pokemons.Add(p);
            p = new Pokemon("Mewtwo", "Lendario psiquico");
            this.pokemons.Add(p);
            p = new Pokemon("Muk", "Pokemon tipo metal");
            this.pokemons.Add(p);
        }
        
    }
}