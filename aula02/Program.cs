using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {   
            //erro/////////////////
            // Console.Write("Digite seu Salário: ");
            // var salario = double.Parse(Console.ReadLine());
            // Console.Write("Jurus: ");
            // var jurus = double.Parse(Console.ReadLine());
            // var j = jurus/100;
            // var p = salario * j;
            // var nsalario = p + salario;
            // Console.WriteLine("salario: "+salario);
            // Console.Write("Novo salario: "+nsalario);

            Console.Write("Digite o valor da base em (cm): ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura em (cm): ");
            var b = double.Parse(Console.ReadLine());
            var area = a * b / 2;
            Console.Write("área é: "+area+"cm²");
        }
    }
}
