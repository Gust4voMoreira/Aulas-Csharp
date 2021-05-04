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

            /*
            2) - Faça um programa em C# capaz de calcular a sequência de Fibonacci sendo 
            que:
            • O primeiro número é sempre 0.
            • O segundo número é sempre 1.
            • Os próximos números são o resultado da soma de seus dois 
            predecessores.
            Exemplo:
            0,1,1,2,3,5,8,13,21,34,55,89...
            O algoritmo deve calcular e mostrar a sequência de Fibonacci até que o último 
            número calculado seja maior ou igual a um limite que será informado pelo 
            usuário.

            int num, soma;

            Console.WriteLine("Digite: ");
            num = int.Parse(Console.ReadLine());

            int i = 1, ultimo = 1, penultimo = 1;
            while (i <= num)
            {
                
                soma = ultimo + penultimo;
                penultimo = ultimo;
                ultimo = soma;
                i += 1;
                Console.WriteLine(soma);
            } 
            */

            /*
            3) - Faça um algoritmo capaz de determinar o maior número de uma sequência 
            de 10 números que deverão ser digitados pelo usuário, e apresente o resultado 
            ao final do processamento.
            */
            // int num;

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine($"Digite o {i}°: ");
            //     num = int.Parse(Console.ReadLine());
            // }
            /*
            int num1, num2, num3, num4;

            Console.WriteLine("Digite o 1° número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3° número: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 4° número: ");
            num4 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3 && num1 > num4)
            {
                Console.WriteLine($"maior número: {num1}");
            }
            else if(num2 > num3 && num2 > num4)
            {
                Console.WriteLine($"maior número: {num2}");
            }
            else if (num3 > num4)
            {
                Console.WriteLine($"maior número: {num3}");
            }
            else
            {
                Console.WriteLine($"maior número: {num4}");
            }
            */

            /*
            4) Faça um programa em C# que leia um número não determinado de valores, 
            calcule e escreva a média aritmética dos valores lidos, a quantidade de valores 
            positivos, a quantidade de valores negativos. O usuário que determinará o 
            término do programa.
            */
            
            /*
            5) Faça um programa em C# que leia uma quantidade desconhecida de números 
            e conte quantos deles estão nos seguintes intervalos: 0-25, 26-50, 51-75 e 76-
            100. A entrada de dados deve terminar quando for lido um número negativo.
            */

            /*
            6) Faça um programa em C# que leia uma quantidade não determinada de 
            números positivos. Calcule a quantidade de números pares e ímpares, a média 
            de valores pares e a média geral dos números lidos. O número que encerrará a 
            leitura será zero.
            */
        }
    }
}
