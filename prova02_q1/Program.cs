using System;

namespace prova02_q1
{
    class Program
    {
            /*
            1)Faça um programa que leia um vetor de 10 posições com números inteiros positivos. Esse programa 
            deverá ter uma função que retorne o maior número do vetor e outra função que retorne a média dos 
            números do vetor.
            Obs.: Não permitir a entrada de números menor ou igual a zero.
            */
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i+1}° número: ");
                vetor[i] = int.Parse(Console.ReadLine());  
            }
        }

        //aula13 ex: 5
    }
}
