using System;

namespace aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 27/04/2021
            /*
            1)  Faça um programa em C# capaz de calcular o fatorial de um número inteiro
            positivo informado pelo usuário, sendo que:
            O número para o cálculo deve ser informado pelo usuário
            O algoritmo deve informar o fatorial deste número de acordo com as regras
            abaixo:
            • d fatorial de números negativos não existe
            • O fatorial de 0 é 1
            • O fatorial de 1 é 1
            */
            int num, fatorial;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num == 0 || num == 1)
            {
                Console.Write($"Fatorial de {num} é 1");
            }
            else
            {
                for (int  i = 0;  i > num; i--)
                {
                    fatorial = num * i;
                    Console.WriteLine($"Fatorial de {num} é {fatorial}");
                }
                Console.WriteLine($"Fatorial de {num} é {fatorial}");
            }
            
        }
    }
}
