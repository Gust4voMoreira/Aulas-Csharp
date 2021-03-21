using System;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //data: 09/03/2021
            /*1]
            Console.Write("nome do aluno: ");
            string nomeAluno = Console.ReadLine();
            Console.Write("primeira nota: ");
            float notaUM = float.Parse(Console.ReadLine());
            Console.Write("segunda nota: ");
            float notaDois = float.Parse(Console.ReadLine());
            float m = (notaUM + notaDois)/2;
            Console.Write("O aluno "+nomeAluno+" tem a média: "+m);
            */

            //2]
            //Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o novo salário,
            //sabendo que este sofreu um aumento de 25% .

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
