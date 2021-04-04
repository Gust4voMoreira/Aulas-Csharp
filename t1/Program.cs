using System;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salarioBase, salarioReceber, totalImposto;
            Console.WriteLine("Digite seu salário: ");
            salarioBase = decimal.Parse(Console.ReadLine());
            totalImposto = (salarioBase * 2) / 100;
            salarioReceber = salarioBase - totalImposto;
            Console.WriteLine("Salário a receber é: "+ salarioReceber);
        }
    }
}
