using System;

namespace aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            //data: 16/03/2021
            Console.Write("Digite o valor da base em (cm): ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura em (cm): ");
            var b = double.Parse(Console.ReadLine());
            var area = a * b / 2;
            Console.Write("área é: "+area+"cm²");
        }
    }
}
