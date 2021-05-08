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
            número calculado seja menor ou igual a um limite que será informado pelo 
            usuário.

            int num_lit, pri_num = 0, seg_num = 1, ter_num = 1;

            Console.WriteLine("Digite o limite: ");
            num_lit = int.Parse(Console.ReadLine());

            Console.Write("0, 1, 1, ");

            while (ter_num <= num_lit)
            {
                pri_num = seg_num;
                seg_num = ter_num;
                ter_num = pri_num + seg_num;

                Console.Write($"{ter_num}, ");
            }
            */

            /*
            3) - Faça um algoritmo capaz de determinar o maior número de uma sequência 
            de 10 números que deverão ser digitados pelo usuário, e apresente o resultado 
            ao final do processamento.
            
            int num, maior = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Digite o {i}° número: ");
                num = int.Parse(Console.ReadLine());

                if (num > maior)
                {
                    maior = num;
                }
            }
            Console.WriteLine($"Maior: {maior}");
            */

            /*
            4) Faça um programa em C# que leia um número não determinado de valores, 
            calcule e escreva a média aritmética dos valores lidos, a quantidade de valores 
            positivos, a quantidade de valores negativos. O usuário que determinará o 
            término do programa.

            int num, soma = 0, cont = 0, negativo = 0, positivo = 0;
            double media;
            char continuar;

            do
            {
                Console.WriteLine("digite um número: ");
                num = int.Parse(Console.ReadLine());

                cont ++;
                soma = soma + num;
                if (num < 0)
                {
                    negativo += +1;
                }
                else
                {
                    positivo += +1;
                }

                Console.WriteLine("Para continuar digite (s) ou (S): ");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar == 's' || continuar == 'S');

            media = soma / cont;

            Console.WriteLine($"Media: {media}");
            Console.WriteLine($"Positivo: {positivo}");
            Console.WriteLine($"Negativo: {negativo}");
            */

            /*
            5) Faça um programa em C# que leia uma quantidade desconhecida de números 
            e conte quantos deles estão nos seguintes intervalos: 0-25, 26-50, 51-75 e 76-
            100. A entrada de dados deve terminar quando for lido um número negativo.

            int num, interUm = 0, interDois = 0, interTres = 0, interQuatro = 0;
            Console.WriteLine("digite números positivos, digite um negativo para terminar: ");
            
            do
            {
                num = int.Parse(Console.ReadLine());
                if (num >= 0 && num <= 25)
                {
                    interUm++;
                } 
                else if (num >= 26 && num <= 50)
                {
                    interDois++;
                }
                else if (num >= 51 && num <= 75)
                {
                    interTres++;
                }
                else if (num >= 76 && num <= 100)
                {
                    interQuatro++;
                }
            } while (num >= 0);

            Console.WriteLine($"Quantidade de n° no primeiro intervalo: {interUm}");
            Console.WriteLine($"Quantidade de n° no segundo intervalo: {interDois}");
            Console.WriteLine($"Quantidade de n° no terceiro intervalo: {interTres}");
            Console.WriteLine($"Quantidade de n° no quarto intervalo: {interQuatro}");
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
