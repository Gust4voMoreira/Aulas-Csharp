using System;

namespace aula15._2
{
    class Program
    {
        //Data: 29/05/2021 // 01/06/2021
        /*
        3) Faça um programa em c# que tenha uma função que calcule e retorne a distância
        entre dois pontos ( x1, y1) e (x2, y2). Todos os números e valores de retorno devem ser 
        do tipo float
        */
        static void Main(string[] args)
        {
            float x1, x2, y1, y2;

            Console.WriteLine("digite: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite: ");
            num2 = int.Parse(Console.ReadLine());

            menor = retMenor(num1, num2);
            maior = retMaior(num1, num2);
        }

        static float calcDist(float x1, float y1, float x2, float y2)
        {
            return 0;
        }
    }
}
