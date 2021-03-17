using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Digite o valor do seu Salário: ");
            var salario = double.Parse(Console.ReadLine());
            var p = salario * 0.25;
            var nsalario = salario + p;
            Console.Write("seu salário com 25% de desconto é "+nsalario);
        }
    }
}
