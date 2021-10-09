using System;

namespace aulaPoo03
{
    class Program
    {
        //DESAFIO 06
        //Calcular a area de um retângulo

        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Calcular a area de um retângulo");

            Console.WriteLine("Informe a altura: ");
            retangulo.Altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a base: ");
            retangulo.Base = float.Parse(Console.ReadLine());

            retangulo.ExibeDados();
        }
    }
}
