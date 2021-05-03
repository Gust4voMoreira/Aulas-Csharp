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
            • o fatorial de números negativos não existe
            • O fatorial de 0 é 1
            • O fatorial de 1 é 1
    
            int num, fat;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num == 0 || num == 1)
            {
                Console.WriteLine($"Fatorial de {num} é 1");
            }
            else if (num < 0)
            {
                Console.WriteLine($"o fatorial de números negativos não existe.");
            }
            else
            {
                // for (fat = 1; num > 1; num = num - 1)
                // {
                //     fat = fat * num;
                // }
                // Console.WriteLine(fat);
                //ou
                fat = 1;
                while (num > 1)
                {
                    fat = fat * num; 
                    num = num -1;
                }
                Console.WriteLine(fat);
            }
            */
            
        }
    }
}
