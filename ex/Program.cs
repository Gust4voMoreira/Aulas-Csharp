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
            var imprimir = preVet1(tamanho);
            
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

        
    }
}
