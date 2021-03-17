using System;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1]
            //Console.Write("nome do aluno: ");
            //string nomeAluno = Console.ReadLine();
            //Console.Write("primeira nota: ");
            //float notaUM = float.Parse(Console.ReadLine());
            //Console.Write("segunda nota: ");
            //float notaDois = float.Parse(Console.ReadLine());
            //float m = (notaUM + notaDois)/2;
            //Console.Write("O aluno "+nomeAluno+" tem a média: "+m);

            Console.Write("Digite o valor do seu Salário: ");
            var salario = double.Parse(Console.ReadLine());
            var p = salario * 0.25;
            var nsalario = salario + p;
            Console.Write("seu salário com 25% de desconto é "+nsalario);
        }
    }
}
