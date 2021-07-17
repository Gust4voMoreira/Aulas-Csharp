using System;

namespace ex
{
    class Program
    {
        /*2)Faça um programa que tenha uma função que preenchera um vetor cujo tamanho seja informado 
            pelo usuário. O programa deverá solicitar o preenchimento de dois vetores. O programa deverá ter 
            um procedimento (método do tipo void) que irá imprimir o produto dos valores dos dois vetores.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho dos vetores:");
            int tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine("//////////////////////");
            var vet1 = preVet1(tamanho);
            var vet2 = preVet2(tamanho);
            var mult = produto(vet1, vet2, tamanho);

            Console.WriteLine("produto dos valores:");
            imprimir(mult, vet1, vet2);
        }

        static int[] preVet1(int tamanho)
        {
            int[] vetNum = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Digite o {i+1}° número do primeiro vetor:");
                vetNum[i] = int.Parse(Console.ReadLine());
            }
            return vetNum;
        }

        static int[] preVet2(int tamanho)
        {
            int[] vetNum = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Digite o {i+1}° número do segundo vetor:");
                vetNum[i] = int.Parse(Console.ReadLine());
            }
            return vetNum;
        }

        static int[] produto(int[] vetNum1,int[] vetNum2, int tamanho)
        {
            int[] mult = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                mult[i] = vetNum1[i] * vetNum2[i];
            }
            return mult;
        }

        static void imprimir(int[] mult, int[] vetNum1, int[] vetNum2)
        {
            for (int i = 0; i < mult.Length; i++)
            {
                Console.WriteLine($"{vetNum1[i]} X {vetNum2[i]} = {mult[i]}");
            }
        }
    }
}
