using System;

namespace cProva01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data:20/04/2021
            /*
            1)
            
            string nome;
            int idade;
            double altura;

            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite a idade do aluno: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite altura do aluno: ");
            altura = double.Parse(Console.ReadLine());

            if (idade >= 10 && idade <= 12 && altura >= 1.20 && altura <= 1.40)
            {
                Console.Write("Time ALFA");
            }
            else if (idade >= 13 && idade <= 15 && altura >= 1.40 && altura <= 1.60)
            {
                Console.Write("Time BETA");
            }
            else if (idade >= 16 && idade <= 18 && altura >= 1.50 && altura <= 1.70)
            {
                Console.Write("Time GAMA");
            }
            else
            {
                Console.Write("Não participará de nenhum time");
            }
            */

            /*
            2)
            string nome, cpf;
            int anoDeNascimento, idade;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o seu CPF: ");
            cpf = Console.ReadLine();
            Console.Write("Digite o ano de nascimento: ");
            anoDeNascimento = int.Parse(Console.ReadLine());

            idade = DateTime.Now.Year - anoDeNascimento;

            if (idade >= 65)
            {
                Console.Write("Vacinas nos meses de JANEIRO, FEVEREIRO E MARÇO");
            }
            else if (idade >= 18 && idade < 65)
            {
                Console.Write("Vacinas nos meses de ABRIL, MAIO E JUNHO");
            }
            else if (idade > 3 && idade < 18)
            {
                Console.Write("Vacinas nos meses de JULHO, AGOSTO E SETEMBRO");
            }
            else
            {
                Console.Write("Vacinas nos meses de OUTUBRO, NOVEMBRO E DEZEMBRO");
            }
            */

            /*
            3)
            
            int formaPagamento;
            decimal valorProduto, valorPago, parcela;

            Console.Write("Digite o valor do produto: ");
            valorProduto = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Forma de pagamento");
            Console.WriteLine("(1) À vista em dinheiro");
            Console.WriteLine("(2) À vista no cartão de crédito");
            Console.WriteLine("(3) Em duas vezes");
            Console.WriteLine("(4) Em três vezes");
            Console.WriteLine("(5) Em dês vezes");
            Console.WriteLine("Digite o número que corresponde a forma de pagamento: ");
            formaPagamento = int.Parse(Console.ReadLine());

            switch (formaPagamento)
            {
                case 1:
                    valorPago = valorProduto - (valorProduto * 25) / 100;
                    parcela = valorPago;
                    break;
                case 2:
                    valorPago = valorProduto - (valorProduto * 15) / 100;
                    parcela = valorPago;
                    break;
                case 3:
                    valorPago = valorProduto - (valorProduto * 10) / 100;
                    parcela = valorPago / 2;
                    break;
                case 4:
                    valorPago = valorProduto - (valorProduto * 5) / 100;
                    parcela = valorPago / 3;
                    break;
                case 5:
                    valorPago = valorProduto;
                    parcela = valorPago / 10;
                    break;
                default:
                    valorPago = 0;
                    parcela = 0;
                    Console.WriteLine("Forma de pagamento inválida!");
                    break;
            }

            if (valorPago != 0)
            {
                Console.WriteLine($"O valor a ser pago: {valorPago}");
                Console.WriteLine($"Valor da parcela: {parcela}");
            }
            */

            /*
            4)
            
            Console.Write("Digite a distancia entre as duas cidades em (km): ");
            double distancia = double.Parse(Console.ReadLine());
            Console.Write("Digite a hora de saída do PRIMEIRO ônibus em (horas): ");
            double saida1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a hora de chegada do PRIMEIRO ônibus em (horas): ");
            double chegada1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a hora de saída do SEGUNDO ônibus em (horas): ");
            double saida2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a hora de chegada do SEGUNDO ônibus em (horas): ");
            double chegada2 = double.Parse(Console.ReadLine());

            double tempo1 = saida1 + chegada1;
            double tempo2 = saida2 + chegada2;
            double vm1 = distancia/tempo1;
            double vm2 = distancia/tempo2;

            if(vm1 > vm2)
            {
                Console.WriteLine($"Velocidade: {vm1}km/h");
                Console.WriteLine("O PRIMEIRO ônibus é mais rapido.");
            }
            else
            {
                Console.WriteLine($"Velocidade: {vm2}km/h");
                Console.WriteLine("O SEGUNDO ônibus é mais rapido.");
            }
            */

            /*
            5)
            
            int destino;
            int percurso;

            Console.WriteLine("Informe o destino");
            Console.WriteLine("(1) Bahia");
            Console.WriteLine("(2) Rio de Janeiro");
            Console.WriteLine("(3) São Paulo");
            Console.WriteLine("(4) Brasília");
            destino = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe se é ida, volta ou ida e volta");
            Console.WriteLine("(1) Ida");
            Console.WriteLine("(2) Volta");
            Console.WriteLine("(3) Ida e Volta");
            percurso = int.Parse(Console.ReadLine());

            switch (destino)
            {
                case 1:
                    if (percurso == 1)
                    {
                        Console.WriteLine("Valor R$1550,00");
                    }
                    else if (percurso == 2)
                    {
                        Console.WriteLine("Valor R$950,00");
                    }
                    else
                    {
                        Console.WriteLine($"Valor R${1550 + 950}");
                    }
                    break;
                case 2:
                    if (percurso == 1)
                    {
                        Console.WriteLine("Valor R$850,00");
                    }
                    else if (percurso == 2)
                    {
                        Console.WriteLine("Valor R$550,00");
                    }
                    else
                    {
                        Console.WriteLine($"Valor R${850 + 550}");
                    }
                    break;
                case 3:
                    if (percurso == 1)
                    {
                        Console.WriteLine("Valor R$800,00");
                    }
                    else if (percurso == 2)
                    {
                        Console.WriteLine("Valor R$500,00");
                    }
                    else
                    {
                        Console.WriteLine($"Valor R${800 + 500}");
                    }
                    break;
                case 4:
                    if (percurso == 1)
                    {
                        Console.WriteLine("Valor R$500,00");
                    }
                    else if (percurso == 2)
                    {
                        Console.WriteLine("Valor R$450,00");
                    }
                    else
                    {
                        Console.WriteLine($"Valor R${500 + 450}");
                    }
                    break;
            }
            */
        }
    }
}
