using System;

namespace aula03
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
            
            int hora_Trabalhada;
            double hora = 120;
            double salario_Bruto, salario_Receber;

            Console.WriteLine("Horas de trabalho:");
            hora_Trabalhada = int.Parse(Console.ReadLine());

            salario_Bruto = hora * hora_Trabalhada;
            salario_Receber = salario_Bruto - (salario_Bruto * 0.03);

            Console.WriteLine("Salário bruto: "+salario_Bruto.ToString("C2")+" reais");
            Console.WriteLine("O salário a receber é: "+salario_Receber.ToString("C2")+" reais");
            */

            /*
            3) João recebeu seu salário e precisa pagar duas contas que estão atrasadas. A 
            conta de Energia e a conta de água. Como as contas estão atrasadas, João terá 
            que pagar multa de 2% sobre cada conta. Faça um algoritmo que calcule e mostre 
            quanto restará do salário de João.
            
            double salario, resto_Salario, energia, agua, multa_Energia, multa_Agua;

            Console.WriteLine("Digite seu Salário: ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da conta de Energia:");
            energia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da conta de Água:");
            agua = double.Parse(Console.ReadLine());

            multa_Energia = energia + (energia * 0.02);
            multa_Agua = agua + (agua * 0.02);
            resto_Salario = salario - (multa_Energia + multa_Agua);

            Console.WriteLine("O salário a receber é: "+resto_Salario.ToString("C2")+" reais");
            */
        }
    }
}
