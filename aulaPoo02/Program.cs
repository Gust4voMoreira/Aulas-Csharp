using System;

namespace aulaPoo02
{
    class Program
    {
        static void Main(string[] args)
        {
            double profundidade, larg, alt, porta, janela = 0;
            var opcao = "s";
            
            Console.WriteLine("\nResponda as seguintes perguntas para prosseguir:");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Qual a largura?");
            larg = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a altura?");
            alt = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Qual o tamanho da porta em metros?");
            porta = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Nesse cômodo tem janela? S ou N:");
			opcao = Console.ReadLine();
            Console.Clear();
            
            if (opcao.ToLower() == "s")
            {
                Console.WriteLine("Qual o tamanho da janela em metros?");
                janela = double.Parse(Console.ReadLine());
                Console.Clear();
            }

            double desc = janela + porta;
            double areaP = alt * (larg + profundidade) * 2 - desc;
            double areaT = larg * alt;
            double litragem = Math.Round((areaP + areaT) / 2,9);

            Console.WriteLine("---------------RESULTADO---------------");
            Console.WriteLine($"Quantidade de tinta: {litragem} litros");
        }
    }
}
