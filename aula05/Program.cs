using System;

namespace aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            //data: 16/03/2021
            /*
            1) Faça um algoritmo que leia o ano de nascimento de uma pessoa e o ano atual, 
            calcule e mostre: 
            a. A idade da pessoa; 
            b. Quantos anos essa pessoa terá em 2025; 
            
            int ano, nascimento, idade, idadeN;

            ano = DateTime.Now.Year;
            Console.WriteLine("Digite o seu ano de Nascimento:");
            nascimento = int.Parse(Console.ReadLine());
            idade = ano - nascimento;
            idadeN = idade + 4;
            Console.WriteLine($"Você tem {idade} anos, em 2025 terá {idadeN} anos");
            */

            /*
            2) Faça um algoritmo que leia o número de horas trabalhadas e o valor do salário 
            mínimo. Calcule e mostre o salário a receber seguindo as seguintes regras: 
            a. A hora trabalhada vale R$120,00; 
            b. O salário bruto equivale ao número de horas trabalhadas multiplicada pelo 
            valor da hora trabalhada; 
            c. O imposto equivale a 3% do salário bruto; 
            d. O salário a receber equivale ao salário bruto menos o imposto. 

            int hTrabalhada;
            double hora = 120.00;
            double salarioB, salarioR;

            Console.WriteLine("Horas de trabalho:");
            hTrabalhada = int.Parse(Console.ReadLine());
            salarioB = hora * hTrabalhada;
            Console.WriteLine($"Salário bruto: R${salarioB} reais");
            salarioR = salarioB - (salarioB * 0.03);
            Console.WriteLine($"O salário a receber é: R${salarioR} reais");
            */

            /*
            3) João recebeu seu salário e precisa pagar duas contas que estão atrasadas. A 
            conta de Energia e a conta de água. Como as contas estão atrasadas, João terá 
            que pagar multa de 2% sobre cada conta. Faça um algoritmo que calcule e mostre 
            quanto restará do salário de João.
            */

            double salario, rSalario, energia, agua, multaE, multaA;
            double percentual = 2.0 / 100.0;

            Console.WriteLine("Digite seu Salário: ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da conta de Energia:");
            energia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da conta de Água:");
            agua = double.Parse(Console.ReadLine());

            multaE = energia+(energia * percentual);
            multaA = agua+(agua * percentual);
            rSalario = salario - (multaE+multaA);

            Console.WriteLine("O salário a receber é: "+rSalario.ToString("C2")+" reais");
        }
    }
}
