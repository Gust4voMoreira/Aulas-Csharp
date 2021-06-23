using System;

namespace prova02_q2
{
    class Program
    {
            /*
            2)Faça um programa que tenha uma função que preenchera um vetor cujo tamanho seja informado 
            pelo usuário. O programa deverá solicitar o preenchimento de dois vetores. O programa deverá ter 
            um procedimento (método do tipo void) que irá imprimir o produto dos valores dos dois vetores.
            */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quatidade de números dos vetores: ");
            int qtd = int.Parse(Console.ReadLine());

            var vetor1 = fVetor1(qtd);
            var vetor2 = fVetor2(qtd);

            imprimir(vetor1);
            imprimir(vetor2);

            for (int i = 0; i < 3; i++)
            {
                media[i] = notP1[i] * notP2[i];
                Console.WriteLine($"A média do {i+1}° aluno é: {media[i]}");   
            }
        }

        static float[] fVetor1(int qtd)
        {
            float[] vetFloat1 = new float[qtd];
            Console.WriteLine("VETOR 1");
            for (int i = 0; i < vetFloat1.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° valor: ");
                vetFloat1[i] = float.Parse(Console.ReadLine());
            }
            return vetFloat1;
        }

        static float[] fVetor2(int qtd)
        {
            float[] vetFloat2 = new float[qtd];
            Console.WriteLine("VETOR 2");
            for (int i = 0; i < vetFloat2.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° valor: ");
                vetFloat2[i] = float.Parse(Console.ReadLine());
            }
            return vetFloat2;
        }

        static void imprimir(float[] pVetor)
        {
            for (int i = 0; i < pVetor.Length; i++)
            {
                Console.Write($" {pVetor[i]} |");
            }
        }
    }
}
