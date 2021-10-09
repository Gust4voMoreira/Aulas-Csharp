using System;

namespace aulaPoo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon();
            //tenta fazer um que o usuario coloque os dados.
            p.Nome = "Bulbasauro";
            p.Descricao = "Bulbasauro é um pokémon do tipo planta..";
            p.ExibirDadosPokemon();
            Console.ReadKey();
        }
    }
}
