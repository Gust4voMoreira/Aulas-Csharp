using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Digite seu Salário: ");
            var salario = double.Parse(Console.ReadLine());
            var p = salario * 0.25;
            Console.Write("aaaaa"+p);
        }
    }
}
