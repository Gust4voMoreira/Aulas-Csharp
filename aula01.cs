
using System;

namespace Aulas_Csharp
{
    class aula01
    {
        static void Main(string[] args)
        {
            Console.Write("nome: ");
            string nome = Console.ReadLine();
            Console.Write("primeira nota: ");
            float notaUM = float.Parse(Console.ReadLine());
            Console.Write("segunda nota: ");
            float notaDois = float.Parse(Console.ReadLine());
            float m = (notaUM + notaDois)/2;
            Console.Write("O aluno "+nome+" tem a média: "+m);
        }
    }
}
