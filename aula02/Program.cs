using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {  /*
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
           totalGratificacao = (salarioBase * gratificacao)/100;
           totalImposto = (salarioBase * imposto)/100;
           salarioReceber = salarioBase + totalGratificacao - totalImposto;

           Console.WriteLine("O valor da gratificação é: "+totalGratificacao);
           Console.WriteLine("O valor d o imposto é: "+totalImposto);
           Console.WriteLine("O salário a receber é: "+salarioReceber);
        }
    }
}
