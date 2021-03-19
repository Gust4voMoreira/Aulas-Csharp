using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*
            Console.Write("Digite o valor do seu Salário: ");
            var salario = double.Parse(Console.ReadLine());
            var p = salario * 0.25;
            var nsalario = salario + p;
            Console.Write("seu salário com 25% de aumento é "+nsalario);
            */
            //ou
            
            double salario, aumento, porcentagem;
            Console.Write("Qual é o seu salario?");
            salario = double.Parse(Console.ReadLine());
            porcentagem = 25.0 / 100;
            aumento = salario + (porcentagem*salario);
            Console.WriteLine("O seu salário com aumento de 25% foi de "+aumento);
            
        }
    }
}
