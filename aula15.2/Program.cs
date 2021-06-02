using System;

namespace aula15._2
{
    class Program
    {
        //Data: 29/05/2021 // 01/06/2021
        /*
        3) Faça um programa em c# que tenha uma função que calcule e retorne a distância
        entre dois pontos ( x1, y1) e (x2, y2). Todos os números e valores de retorno devem ser 
        do tipo float.
        */
        static void Main(string[] args)
        {
            float x1, x2, y1, y2, distancia;

            Console.WriteLine("digite o x1: ");
            x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o x2: ");
            x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o y1: ");
            y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o y2: ");
            y2 = float.Parse(Console.ReadLine());

            distancia = calcDist(x1, x2, y1, y2);

            Console.WriteLine($"Distância: {distancia}");
        }

        static float calcDist(float x1, float x2, float y1, float y2)
        {
            float a, b, c, d;
            a = x2 - x1;
            b = y2 - y1;
            c = (a * a) + (b * b);
            d = (float)Math.Sqrt(c);

            return d;
        }
    }
}
