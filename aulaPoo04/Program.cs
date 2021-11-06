using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaPoo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            pokedex.ListarPokemons();
            Console.ReadKey();
        }
    }
}
