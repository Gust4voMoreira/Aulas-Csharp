using System;

namespace aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 15/06/2021
            var vetNumeros = PreencherVetor(5);

            Imprimir(vetNumeros);
        }

        static int[] PreencherVetor(int qtd)
        {
            var vet = new int[qtd];

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }
            return vet;
        }

        static void Imprimir(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"| {vet[i]} ");
            }
        }
    }
}