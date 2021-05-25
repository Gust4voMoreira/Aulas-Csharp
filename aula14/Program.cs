using System;

namespace aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 25/05/2021
            for (int i = 0; i <= 10; i++)
            {
                for (int u = 0; u < 11; u++)
                {
                    Console.WriteLine($"{i} x {u} = {Mult(i,2)}");
                }
            }
        }

        static int Mult(int x, int y)
        {
            return x * y;
        }
    }
}
