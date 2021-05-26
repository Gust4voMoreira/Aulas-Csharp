using System;

namespace aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 25/05/2021
            //1)
            for (int i = 2; i <= 10; i++)
            {
               for (int y = 1; y <= 10; y++)
               {
                   Console.WriteLine($"{i} x {y} = {Mult(i,y)}");
               }
               Console.WriteLine();
            }
        }
        static int Mult(int x, int y)
        {
            return x * y;
        }
    }
}
