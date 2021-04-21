using System;

namespace aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 20/04/2021
            
            int num = 1, soma = 0;

            while (num <= 10)
            {
                Console.WriteLine(num + soma);
                soma = num + soma;
                num ++;

            //55
            }
        }
    }
}
