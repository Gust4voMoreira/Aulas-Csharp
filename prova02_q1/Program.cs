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
            int[] vetor = new int[2];

            var notP1 = fVetor(2);
       
            //var vetMaior = fMaior(notP1);
        }

        static int[] fVetor(int vet1)
        {
            int[] vetor = new int[vet1];

            for (int i = 0; i < vet1; i++)
            {
                Console.WriteLine($"Digite a nota da prova parcial do {i+1}° aluno: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            return vetor;
        }

        // static int[] fMaior(int [] vet)
        // {
        //     int maior = vet[0];

        //     for (int i = 0; i < 2; i++)
        //     {
        //         if (vet[i] > maior)
        //         {
        //             maior = vet[i];
        //         }
        //     }
        //     return maior;
        // }

        static void imprimir(int vetM)
        {
            Console.WriteLine($"Maior: {vetM}");
        }
        //aula13 ex: 5
    }
}
