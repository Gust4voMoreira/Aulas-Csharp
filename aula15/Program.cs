using System;

namespace aula15
{
    class Program
    {
        //Data: 29/05/2021 // 01/06/2021
        /*
        1) Faça um programa em c# que tenha uma função que receba dois números inteiros 
        retorne o menor número.

        2) Faça um programa em c# que tenha uma função que receba dois números inteiros 
        retorne o maior número.
        */
        static void Main(string[] args)
        {
            int menor, maior, num1, num2;

            Console.WriteLine("digite: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite: ");
            num2 = int.Parse(Console.ReadLine());

            menor = retMenor(num1, num2);
            maior = retMaior(num1, num2);

            Console.WriteLine($"Maior: {maior}, Menor: {menor}");
        }

        static int retMenor(int num1, int num2)
        {
            if (num1 < num2)
                return num1;
            else
                return num2;
        }

        static int retMaior(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }
    }
}
