using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            //data: 09/03/2021 
            /*
            Faça um algoritmo que leia o salário base de um funcionário, calcule e mostre o salário
            a receber, sabendo-se que esse funcionário tem gratificação de 5% sobre o salário base e paga
            imposto de 7% sobre o salário base.
            */
            /*
            decimal salarioBase, salarioReceber, totalImposto, totalGratificacao;
            Console.WriteLine("Digite seu salário: ");
            salarioBase = decimal.Parse(Console.ReadLine());
            totalImposto = salarioBase * 0.02;
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
