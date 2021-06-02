using System;

namespace aula15._3
{
    class Program
    {
        //Data: 29/05/2021 // 01/06/2021
        /*
        4) Faça um programa em c# que tenha uma função potencia(base, expoente) que,
        quando chamada, retorna baseexpoente. Por exemplo, potencia(3, 4) deve retornar
        81. Assuma que expoente é um inteiro maior ou igual a 1
        */
        static void Main(string[] args)
        {
            int num, exp, potencia;

            Console.WriteLine("Digite o número base: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente: ");
            exp = int.Parse(Console.ReadLine());

            potencia = Potencia(num, exp);

            Console.WriteLine($"A potencia de base: {num} com expoente: {exp} é {potencia}");
        }

        static int Potencia(int numBase, int expoente)
        {
            int pot = 1;

            for (int i = 1; i <= expoente; i++)
            {
                pot = pot * numBase;
            }
            return pot;
        }
    }
}
