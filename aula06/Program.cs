using System;

namespace aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 27/03/2021
            /*
            1) Faça um programa que leia duas notas parciais obtidas por um aluno em uma 
            disciplina, e calcule a sua média. Na faculdade que esse aluno estuda, é atribuído um 
            conceito A, B, C, D ou E de acordo com a sua média, conforme tabela a baixo: 
            Média Conceito 
            Entre 9,0 e 10 A 
            Entre 7,5 e 9,0 B 
            Entre 6,0 e 7,5 C 
            Entre 4,0 e 6,0 D 
            Entre 4,0 e 0 E 
            O algoritmo deve mostrar na tela as notas, a média, o conceito correspondente e a 
            mensagem “APROVADO”, caso o Conceito seja A, B ou C ou “REPROVADO” caso seja C 
            ou D. 

            Console.Write("Digite a nota do primeiro bimestre: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota do segundo bimestre: ");
            float nota2 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é: {media} ");

            if (media >= 9 && media <= 10)
            {
                Console.WriteLine("A - APROVADO");
            }
            else if (media >= 7.5 && media < 9)
            {
                Console.WriteLine("B - APROVADO");
            }
            else if (media >= 6 && media < 7.5)
            {
                Console.WriteLine("C - APROVADO");
            }
            else if (media >= 4 && media < 6)
            {
                Console.WriteLine("D - REPROVADO");
            }
            else if (media >= 0 && media < 4)
            {
                Console.WriteLine("E - REPROVADO");
            }
            else
            {
                Console.WriteLine("ERRO");
            }
            */

            /*
            2) Um posto está vendendo combustível com a seguinte tabela de descontos: 
            Etanol 
            a) Até 20 litros, desconto de 3% por litro; 
            b) Acima de 20 litros, desconto de 5% por litro; 

            Gasolina 
            a) Até 20 litros, desconto de 4% por litro; 
            b) Acima de 20 litros, desconto de 6% por litro; 
            Faça um programa que leia o número de litros vendidos, o tipo de combustível (caso E 
            - Etanol – caso G – Gasolina), calcule e mostre o valor a ser pago pelo cliente sabe-se
            que o preço do litro da Gasolina é R$ 5,67 e do litro do Etanol é R$4,75.
            */
            char combustivel;
            int litros;
            double custo, desconto1, desconto2, desconto3, desconto4;

            Console.Write("Para Etanol digite (E) ou para Gasolina digite (G): ");
            combustivel = char.Parse(Console.ReadLine());

            if (combustivel == 'E')
            {
                Console.Write("Quantos Litros: ");
                litros = int.Parse(Console.ReadLine());
                custo = litros * 4.75;
                if (litros <= 20)
                {
                    desconto1 = (custo * 3) / 100;
                    Console.WriteLine($"O preço do Etanol por {litros} litros é: R${Math.Round(custo - desconto1, 2)} reais");
                }
                else
                {
                    desconto2 = (custo * 5) / 100;
                    Console.WriteLine($"O preço do Etanol por {litros} litros é: R${Math.Round(custo - desconto2, 2)} reais");
                }
            }
            else if (combustivel == 'G')
            {
                Console.Write("Quantos Litros: ");
                litros = int.Parse(Console.ReadLine());
                custo = litros * 5.67;
                if (litros <= 20)
                {
                    desconto3 = (custo * 4) / 100;
                    Console.WriteLine($"O preço do gasolina por {litros} litros é: R${Math.Round(custo - desconto3, 2)} reais");
                }
                else
                {
                    desconto4 = (custo * 6) / 100;
                    Console.WriteLine($"O preço do gasolina por {litros} litros é: R${Math.Round(custo - desconto4, 2)} reais");
                }
            }
            else
            {
                Console.WriteLine("ERRO");
            }
            
            /*
            3)
            
            Console.Write("Digite a nota do primeiro bimestre: ");
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
        }
    }
}
