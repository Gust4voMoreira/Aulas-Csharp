using System;

namespace aula14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 25/05/2021
            /*
            1) Faça um programa que tenha as seguintes funções e procedimentos, ou seja, método com retorno e sem retorno.   
            * Uma função (método com retorno) que preencha um vetor de números inteiros cujo número de posições será informado pelo usuário;   
            * Uma função que retorne a somatória dos números do vetor;   
            * Uma função que retorne o maior número do vetor;   
            * Uma função que retorne o menor número do vetor;   
            * Uma função que tetorne o total de números pares do vetor;   
            * Uma função que retorne o total de números impares do vetor;   
            * Um procedimento (método void) que imprima o valor inteiro que irá receber como parâmetro, ou seja, um inteiro.	 
            Obs: Esse método será utilizado para imprimir todos retornos das funções;
            */

            Console.WriteLine("Digite a quatidade de números do vetor: ");
            int qtd = int.Parse(Console.ReadLine()); 
            var vetor1 = pVetor(qtd);

            Console.WriteLine("////////////////////");
            Console.WriteLine("Números do vetor: ");
            imprimir(vetor1);
            Console.WriteLine("////////////////////");
            Console.WriteLine("Soma dos números do vetor: ");
            //float vetor2 = SomaVetor(pVetor(qtd));
            //imprimir();
        }
        static float[] pVetor(int qtd)
        {
            float [] Vetfloat = new float [qtd];
            for (int i = 0; i < Vetfloat.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° valor: ");
                Vetfloat[i] = float.Parse(Console.ReadLine());
            }
            return Vetfloat;
        }

        static void imprimir(float[] pVetor)
        {
            for (int i = 0; i < pVetor.Length; i++)
            {
                Console.Write($" {pVetor[i]} |");
            }
            Console.WriteLine();
        }

        
    }
}
