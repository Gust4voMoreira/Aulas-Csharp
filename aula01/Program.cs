using System;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //data: 09/03/2021
            /*
            1)
            Console.Write("nome do aluno: ");
            string nomeAluno = Console.ReadLine();
            Console.Write("primeira nota: ");
            float notaUM = float.Parse(Console.ReadLine());
            Console.Write("segunda nota: ");
            float notaDois = float.Parse(Console.ReadLine());
            float m = (notaUM + notaDois)/2;
            Console.Write("O aluno "+nomeAluno+" tem a média: "+m);
            */

            /*
            2) Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o novo salário, sabendo que este sofreu um aumento de 25% .

            Console.Write("Digite o valor do seu Salário: ");
            var salario = double.Parse(Console.ReadLine());
            var p = salario * 0.25;
            var nsalario = salario + p;
            Console.Write("seu salário com 25% de aumento é "+nsalario);
            //ou
            double salario, aumento, porcentagem;
            Console.Write("Qual é o seu salario?");
            salario = double.Parse(Console.ReadLine());
            porcentagem = 25.0 / 100;
            aumento = salario + (porcentagem*salario);
            Console.WriteLine("O seu salário com aumento de 25% foi de "+aumento);
            */

            /*
            3) Faça um algoritmo que leia o salário base de um funcionário, calcule e mostre o salário
            a receber, sabendo-se que esse funcionário tem gratificação de 5% sobre o salário base e paga
            imposto de 7% sobre o salário base.
            */
            /*
            decimal salarioBase, salarioReceber, totalImposto;
            Console.WriteLine("Digite seu salário: ");
            salarioBase = decimal.Parse(Console.ReadLine());
            totalImposto = (salarioBase * 2) / 100;
            salarioReceber = salarioBase - totalImposto;
            Console.WriteLine("Salário a receber é: "+ salarioReceber);
            */
            //ou
            decimal salarioBase, salarioReceber, totalImposto, totalGratificacao;
            const int imposto = 7;
            const int gratificacao = 5;

            Console.Write("Digite o salário base: ");
            salarioBase = decimal.Parse(Console.ReadLine());
            totalGratificacao = (salarioBase * gratificacao) / 100;
            totalImposto = (salarioBase * imposto) / 100;
            salarioReceber = salarioBase + totalGratificacao - totalImposto;

            Console.WriteLine("O valor da gratificação é: " + totalGratificacao);
            Console.WriteLine("O valor d o imposto é: " + totalImposto);
            Console.WriteLine("O salário a receber é: " + salarioReceber);

        }
    }
}
