using System;

namespace aula15._4
{
    class Program
    {
        //Data: 29/05/2021 // 01/06/2021
        /*
        5) Faça um programa em c# que leia 5 números inteiros positivos (utilize uma função que 
        leia esse número e verifique se ele é positivo). Para cada número informado escrever a 
        soma de seus divisores (exceto ele mesmo). 
        Utilize a função SomaDivisores para obter a soma.
        */
        static void Main(string[] args)
        {
            int numero, total;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° número");
                numero = int.Parse(Console.ReadLine());
                total = somaDiv(numero);
                Console.WriteLine($"A soma dos divisores de {numero} é {total}");
                Console.WriteLine();
            } 
        }

        static int somaDiv(int num)
        {
            int soma = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    soma += i;
                }
            }
            return soma;
        }
    }
}
