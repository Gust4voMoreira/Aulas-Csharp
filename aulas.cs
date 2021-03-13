
using System;

namespace Aulas_Csharp
{
    class aulas
    {
        static void Main(string[] args)
        {
            //1]
            // Console.Write("nome: ");
            // string nome = Console.ReadLine();
            // Console.Write("primeira nota: ");
            // float notaUM = float.Parse(Console.ReadLine());
            // Console.Write("segunda nota: ");
            // float notaDois = float.Parse(Console.ReadLine());
            // float m = (notaUM + notaDois)/2;
            // Console.Write("O aluno "+nome+" tem a média: "+m);

            //2]
            Console.Write("Digite o valor do seu Salário: ");
            double salario = double.Parse(Console.ReadLine());
            double p = salario * 0.25;
            double nsalario = salario - p;
            Console.Write("seu salário com 25% de desconto é "+nsalario);
        }
    }
}
