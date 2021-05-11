using System;

namespace aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 04/05/2021

            char[] vetLetras = new char[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"índice - {i}:");
                vetLetras[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("O VETOR PREENCHIDO");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{vetLetras[i]}|");
            }
        }
    }
}
