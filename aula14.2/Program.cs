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

            int qtd;

            Console.WriteLine("Digite a quatidade de números do vetor: ");
            qtd = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Números do vetor:");
            var qtdN = pVetor(qtd);
            imprimir(qtdN);
            
           
        }

        static int[] pVetor(int qtd)
        {
            int[] vetQtd = new int[qtd];

            for (int i = 0; i < vetQtd.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° número: ");
                vetQtd[i] = int.Parse(Console.ReadLine());
            }
            return vetQtd;
        }

        static void imprimir(int[] qtdN)
        {
            for (int i = 0; i < qtdN.Length; i++)
            {
                Console.Write($" {qtdN[i]} |");
            }
            Console.WriteLine();
        }
    }
}
