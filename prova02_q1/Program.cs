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
            int[] vetNum = new int[10];

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.Write($"\nDigite o {i + 1}º Numéro: ");
                vetNum[i] = int.Parse(Console.ReadLine());

                if (vetNum[i] <= 0)
                {
                    Console.Write("\nDigite números maiores que 0. ");

                    i = i - 1;
                }
            }
            var vetMaior = Maior(vetNum);
            var vetMedia = Media(vetNum);
        }

        static int[] Maior(int[] vetNum)
        {
            int maior = 0;
            for (int i = 0; i < vetNum.Length; i++)
            {
                if (vetNum[i] > maior)
                {
                    maior = vetNum[i];
                }
            }
            Console.Write($"\nMaior número: {maior} ");

            return vetNum;
        }

        static int[] Media(int[] vetNum)
        {
            float media = 0, soma = 0, cont = 0;
            for (int i = 0; i < vetNum.Length; i++)
            {
                soma = (float)soma + vetNum[i];
                cont++;
            }

            media = (float)soma / cont;

            Console.Write($"\nMédia dos números: {media} ");

            return vetNum;
        }
    }
}
