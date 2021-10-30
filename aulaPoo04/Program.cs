using System;

namespace aulaPoo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon("Bulbasauro", "Bulbasauro é um pokémon do tipo planta..");
            Pokemon p1 = new Pokemon();
            
            Console.WriteLine("Digite o nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a descrição: ");
            p1.Descricao = Console.ReadLine();
            Console.Clear();

            p.ExibirDadosPokemon();
            Console.WriteLine("///////////////////////");
            p1.ExibirDadosPokemon();
            Console.ReadKey();
        }
    }
}
