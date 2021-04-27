using System;

namespace aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 20/04/2021
            //2° Semestre
            /*
            1) Faça um algoritmo para calcular a somatória dos número de 1 até 10;
            int num = 1, soma = 0;

            while (num <= 10)
            {
                // soma = soma + num; //acumulador
                soma += num; //acumulador
                //  num = num + 1; //incremento
                num++; //incremento
            }
            Console.WriteLine(soma);
            */

            /*
            2)
            int numIni, numFim,soma = 0;

            Console.Write("Digite o número inicial: ");
            numIni = int.Parse(Console.ReadLine());
            Console.Write("Digite o número final: ");
            numFim = int.Parse(Console.ReadLine());

            while (numIni <= numFim)
            {
                soma += numIni;
                numIni++;
            }
            Console.WriteLine(soma);
            */

            /*
            3)
            char continuar = 's';
            int cont = 1;

            while(continuar == 's')
            {
                Console.WriteLine($"{cont}° volta no laço.");
                cont ++;

                Console.WriteLine($"Deseja repetir (s) ou (n)");
                continuar = char.Parse(Console.ReadLine());
            }
            */

            /*
            4) Faça um algoritmo para somar todos os números inteiros compreendidos entre 2 
            números, sendo que:
            - Os dois números serão informados pelo usuário
            - O número inicial não poderá ser maior ou igual ao número final

            int numIni, numFim,soma = 0;

            Console.Write("Digite o número inicial: ");
            numIni = int.Parse(Console.ReadLine());
            Console.Write("Digite o número final: ");
            numFim = int.Parse(Console.ReadLine());

            while (numIni >= numFim)
            {
                Console.WriteLine("O número inicial tem que ser menor que o final!");
                Console.WriteLine("Digite o número inicial: ");
                numIni = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número final: ");
                numFim = int.Parse(Console.ReadLine());
            }
            while (numIni <= numFim)
            {
                soma += numIni;
                numIni++;
            }
            Console.WriteLine($"A somatória entre os númeroes é {soma}");
            */

            /*
            5) Desenvolver um algoritmo capaz de calcular a média aritmética simples de uma série 
            de números, sendo que:
            - O usuário deve informar a quantidade de números da série.
            - Se a quantidade for zero ou negativa o algoritmo não deve aceita-la.
            - O usuário deve informar um por um todos os números da série.
            - O algoritmo deve mostrar como resultado a média aritmética simples calculada 
            através da formula:
            MEDIA = (X + X1 + X2+...XN) / N.
            */
            int qtdSerie, cont = 1;
            float numero, soma = 0, media;

            Console.Write("Digite a quantidade de números que será informado: ");
            qtdSerie = int.Parse(Console.ReadLine());

            while (qtdSerie <= 0)
            {
                Console.WriteLine("Quantidade inválida! Não pode ser negativo nem igual a zero");

                Console.Write("Digite a quantidade de números que será informado: ");
                qtdSerie = int.Parse(Console.ReadLine());
            }

            while (cont <= qtdSerie)
            {
                Console.Write($"Digite o {cont}º número: ");
                numero = float.Parse(Console.ReadLine());
                soma += numero;

                cont ++;
            }

            media = soma / qtdSerie;

            Console.Write($"A média dos números é: {media}");

        }
    }
}
