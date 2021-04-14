using System;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1)

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());

            if(idade >= 10 && idade <= 12)
            {
                if(altura >= 1.20 && altura <= 1.40)
                {
                    Console.WriteLine("ALFA");
                }
                else
                {
                    Console.WriteLine("ERRO");
                }
            }
            else if(idade >= 13 && idade <= 15)
            {
                if(altura >= 1.40 && altura <= 1.60)
                {
                    Console.WriteLine("BETA");
                }
                else
                {
                    Console.WriteLine("ERRO");
                }
            }
            else if(idade >= 16 && idade <= 18)
            {
                if(altura >= 1.50 && altura <= 1.70)
                {
                    Console.WriteLine("GAMA");
                }
                else
                {
                    Console.WriteLine("ERRO");
                }
            }
            else
            {
                Console.WriteLine("ERRO");
            }
            */

            /*
            2)
            int ano_atual = DateTime.Now.Year;

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu ano de nascimento: ");
            int ano_nascimento = int.Parse(Console.ReadLine());
            Console.Write("Digite seu CPF: ");
            long CPF = long.Parse(Console.ReadLine());

            int idade = ano_atual - ano_nascimento;

            if(idade >= 0 && idade <= 3)
            {
                Console.WriteLine($"Idade: {idade}, Meses de vacinação: Outubro, novembro e dezembro");
            }
            else if (idade >= 4 && idade < 18)
            {
                Console.WriteLine($"Idade: {idade}, Meses de vacinação: Julho, agosto e setembro ");
            }
            else if (idade >= 18 && idade <= 64)
            {
                Console.WriteLine($"Idade: {idade}, Meses de vacinação: Abril, maio e junho");
            }
            else if (idade >= 65)
            {
                Console.WriteLine($"Idade: {idade}, Meses de vacinação: Janeiro, fevereiro e março");
            }
            else
            {
                Console.WriteLine("ERRO");
            }
            */

            /*
            3)

            double valor_pago, produto;
            int escolha;

            Console.WriteLine("Digite o valor do Produto: ");
            produto = double.Parse(Console.ReadLine());
            Console.Write("\n(1) - À vista em dinheiro, recebe 25% de desconto.\n(2) - À vista no cartão de crédito, recebe 15% de desconto.\n(3) - Em duas vezes, recebe 10% de desconto.\n(4) - Em três vezes, recebe 5% de desconto.\n(5) - Em dês vezes, preço normal.\n");
            Console.WriteLine("\nEscolha a forma de pagamento: ");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1) 
            {
                Console.WriteLine("À vista em dinheiro, recebe 25% de desconto.");
                valor_pago = produto - ((produto * 25) / 100);
                Console.WriteLine($"Valor: R$ {Math.Round(valor_pago, 2)} reais");
            } 
            else if (escolha == 2) 
            {
                Console.WriteLine("À vista no cartão de crédito, recebe 15% de desconto.");
                valor_pago = produto - ((produto * 15) / 100);
                Console.WriteLine($"Valor: R$ {Math.Round(valor_pago, 2)} reais");
            } 
            else if (escolha == 3) 
            {
                Console.WriteLine("Em duas vezes, recebe 10% de desconto.");
                valor_pago = produto - ((produto * 10) / 100);
                Console.WriteLine($"Valor por parcela: R$ {Math.Round(valor_pago/2, 2)} reais");
                Console.WriteLine($"Valor: R$ {Math.Round(valor_pago, 2)} reais");
            } 
            else if (escolha == 4) 
            {
                Console.WriteLine("Em três vezes, recebe 5% de desconto.");
                valor_pago = produto - ((produto * 5)/100);
                Console.WriteLine($"Valor por parcela: R$ {Math.Round(valor_pago/3, 2)} reais");
                Console.WriteLine($"Valor total: R$ {Math.Round(valor_pago, 2)} reais");
            } 
            else if (escolha == 5) 
            {
                Console.WriteLine("Em dês vezes, preço normal.");
                valor_pago = produto;
                Console.WriteLine($"Valor por parcela: R$ {Math.Round(valor_pago/10, 2)} reais");
                Console.WriteLine($"Valor total: R$ {Math.Round(valor_pago, 2)} reais");
            } 
            else 
            {
                Console.Write("ERRO");
            }
            */

            /*
            4)
            */
            
            Console.Write("Digite a distancia entre as duas cidades em (km): ");
            int distancia = int.Parse(Console.ReadLine());
            Console.Write("Digite o tempo do percurso do PRIMEIRO ônibus em (minutos): ");
            int tempo1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o tempo do percurso do SEGUNDO ônibus em (minutos): ");
            int tempo2 = int.Parse(Console.ReadLine());


        }
    }
}
