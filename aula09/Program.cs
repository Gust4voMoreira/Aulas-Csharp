﻿using System;

namespace aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 20/04/2021
            /*
            1)
            int num = 1, soma = 0;

            while (num <= 10)
            {
                Console.WriteLine(num + soma);
                soma += num;
                num ++;

            //55
            }
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
            4)
            int numIni, numFim,soma = 0;

            Console.Write("Digite o número inicial: ");
            numIni = int.Parse(Console.ReadLine());
            Console.Write("Digite o número final: ");
            numFim = int.Parse(Console.ReadLine());

            while (numIni >= numFim)
            {
                Console.WriteLine("O némero inicial é menor que o número final");
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
            Console.WriteLine(soma);
            */

            int num,quantidade,media,soma = 0;

            Console.Write("Digite o número inicial: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Digite o quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            while (num >= quantidade && quantidade != 0)
            {
                Console.WriteLine("Digite o número inicial: ");
                num = int.Parse(Console.ReadLine());
                soma += num;
                num++;
            }
        }
    }
}