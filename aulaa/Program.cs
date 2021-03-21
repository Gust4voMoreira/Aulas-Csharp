using System;

namespace aulaa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 20/03/2021
            /*
            int x, y;
            Console.Write("Digite o primeiro número: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            y = int.Parse(Console.ReadLine());

            if (x == y)
            {
                //Console.Write("o número x: "+x+" e o y: "+y+" são iguais");
                Console.Write($"o número x:{x} e o y:{y} são iguais");
            }
            else if (x > y)
            {
                //Console.Write("O maior número é x: " + x);
                Console.Write($"O número {x} é o maoir");
            }
            else
            {
                //Console.Write("O maior número é y: " + y);
                Console.Write($"O número {y} é o maoir");
            }
            */

            Console.WriteLine("Introduza x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza y: ");
            int z = int.Parse(Console.ReadLine());

            /*
            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine("O maior é x: " + x);
                }
                else
                {
                    Console.WriteLine("O maior é z: " + z);
                }
            }
            else
            {
                if (y > z)
                {
                    Console.WriteLine("O maior é y: " + y);
                }
                else
                {
                    Console.WriteLine("O maior é z: " + z);
                }
            }
            */
            //maior e menor
            if (x == y && y == z)
            {
                Console.WriteLine("O x e y e z são iguais");
            }
            else if (x > y && x > z)
            {
                Console.WriteLine($"O maior é x: {x}");
            }
            else if (y > x && y > z)
            {
                Console.WriteLine($"O maior é y: {y}");
            }
            else
            {
                Console.WriteLine($"O maior é z: {z}");
            }
            
            if (x < y && x < z)
            {
                Console.WriteLine($"O menor é x: {x}");
            }
            else if (y < x && y < z)
            {
                Console.WriteLine($"O menor é y: {y}");
            }
            else
            {
                Console.WriteLine($"O menor é z: {z}");
            }
        }
    }
}
