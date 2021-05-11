using System;

namespace aula13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 11/05/2021
            //1) Ler números inteiros com vetor.
            int[] vetNum = new int[10];

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.WriteLine($"Digite um número na posição {i} do vetor:");
                vetNum[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O VETOR PREENCHIDO");

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.Write($"{vetNum[i]}|");
            }
        }
    }
}
