using System;

namespace aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 10/04/2021
            /*
            1)Faça um algoritmo em C# que leia um número inteiro entre 1 e 12 e escrever o mês 
            correspondente. Caso o usuário digite um número fora desse intervalo, deverá 
            aparecer uma mensagem informando que não existe mês com este número.
            
            Console.Write("Digite um Número: ");
            int mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("JANEIRO");
                    break;
                case 2:
                    Console.WriteLine("FEVEREIRO");
                    break;
                case 3:
                    Console.WriteLine("MARÇO");
                    break;
                case 4:
                    Console.WriteLine("ABRIL");
                    break;
                case 5:
                    Console.WriteLine("MAIO");
                    break;
                case 6:
                    Console.WriteLine("JUNHO");
                    break;
                case 7:
                    Console.WriteLine("JULHO");
                    break;
                case 8:
                    Console.WriteLine("AGOSTO");
                    break;
                case 9:
                    Console.WriteLine("SETEMBRO");
                    break;
                case 10:
                    Console.WriteLine("OUTUBRO");
                    break;
                case 11:
                    Console.WriteLine("NOVEMBRO");
                    break;
                case 12:
                    Console.WriteLine("DEZEMBRO");
                    break;
                default:
                    Console.WriteLine("Mês Inválido");
                    break;  
            }
            */

            /*
            2) Faça um algoritmo em PORTUGOL que leia um número e informe se ele é ou não 
            divisível por 5.

            Console.Write("Digite um Número: ");
            int num = int.Parse(Console.ReadLine());

            if((num % 5)== 0)
            {
                Console.WriteLine("Número divisível por 5");
            }
            else
            {
                Console.WriteLine("Número não divisível por 5");
            }
            */

            /*
            3) Escreva um algoritmo em C# para determinar se um número A é divisível por um 
            outro número B. Esses valores devem ser fornecidos pelo usuário. 

            Console.Write("Número A: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Número B: ");
            int num2 = int.Parse(Console.ReadLine());

            if ((num1 % num2) == 0)
            {
                Console.WriteLine($"o número A: {num1} é divisível pelo número B: {num2}");
            }
            else
            {
                Console.WriteLine($"o número A: {num1} NÃO é divisível pelo número B: {num2}");
            }
            */

            /*
            4) A prefeitura de Porto Velho abriu uma linha de crédito para os professores. O valor 
            máximo da prestação não poderá ultrapassar 30% do salário bruto. Fazer um 
            algoritmo que permita entrar com o salário bruto e o valor da prestação, e informar 
            e o empréstimo pode ou não ser concedido. 
            */

            decimal salario_Bruto, prestacao, porcentagem;

            Console.Write("Digite o valor do salário: ");
            salario_Bruto = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o valor da prestação: ");
            prestacao = decimal.Parse(Console.ReadLine());

            porcentagem = salario_Bruto * (30/100);
            
            if (prestacao <= porcentagem)
            {
                Console.WriteLine("O emprestimo pode ser concedido");
            }
            else
            {
                Console.WriteLine("O emprestimo NÃO pode ser concedido");
            }
        }
    }
}
