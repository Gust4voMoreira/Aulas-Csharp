using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            //data: 16/03/2021
            //1]
            /*Console.Write("Digite seu Salário: ");
            var deposito = decimal.Parse(Console.ReadLine());
            Console.Write("Jurus: ");
            var jurus = decimal.Parse(Console.ReadLine());

            var rendimento = (deposito * jurus)/100;
            var valorFinal = deposito + rendimento;

            Console.WriteLine("Redimento: "+rendimento);
            Console.Write("Novo salario: "+valorFinal);
            //ou
            decimal deposito, taxaDeJuros, rendimento, valorFinal;

            Console.Write("Digite o valor do déposito: ");
            deposito = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o valor da taxa de juros: ");
            taxaDeJuros = decimal.Parse(Console.ReadLine());

            rendimento = (deposito * taxaDeJuros)/100;
            valorFinal = deposito + rendimento;

            Console.WriteLine("O valor do rendimento é "+rendimento);
            Console.WriteLine("O valor final com rendimento é: "+valorFinal);
            */
            //2]
            Console.Write("Digite o valor da base em (cm): ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura em (cm): ");
            var b = double.Parse(Console.ReadLine());
            var area = a * b / 2;
            Console.Write("área é: "+area+"cm²");
        }
    }
}
