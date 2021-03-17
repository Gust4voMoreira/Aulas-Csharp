using System;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nome do aluno: ");
            string nomeAluno = Console.ReadLine();
            Console.Write("primeira nota: ");
            float notaUM = float.Parse(Console.ReadLine());
            Console.Write("segunda nota: ");
            float notaDois = float.Parse(Console.ReadLine());
            float m = (notaUM + notaDois)/2;
            Console.Write("O aluno "+nomeAluno+" tem a média: "+m);

        }
    }
}
