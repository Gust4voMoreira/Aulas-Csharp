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
            int resp = 100;
            while(resp!=0)
            {
                resp = Menu();
                if (resp==1)
                {
                    pokedex.ListarPokemons();
                }
                Console.ReadKey();
                Console.Clear();
            }
            
        }

        static int Menu()
        {
            Console.WriteLine("Pokedex------Agenda Pokemon");
            Console.WriteLine("0 - Sair da Pokedex");
            Console.WriteLine("1 - Listar todos os Pokemon");
            Console.Write("O que deseja fazer: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;

        }
    }
}
