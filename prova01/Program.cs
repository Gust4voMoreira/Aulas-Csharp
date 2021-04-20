using System;

namespace prova01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1) Todo ano a escola Marechal Rondon realiza um torneio interclasse de queimada. Esse jogo é 
            composto por dois times com cinco participantes cada, onde o integrante de um time tem que atingir 
            o adversário com uma bola para tirá-lo do jogo. O professor de educação física precisa separar os 
            times por idade e altura.
                • Alunos com idade entre 10 e 12 anos e com altura de 1,20 a 1,40 irá para o time ALFA;
                • Alunos com idade entre 13 e 15 anos e com altura de 1,40 a 1,60 irá para o time BETA;
                • Alunos com idade entre 16 e 18 anos e com altura de 1,50 a 1,70 irá para o time GAMA;
            O professor precisa de um programa para separar os alunos nos times, ele deve informar o nome 
            do aluno, sua idade e sua altura e tenha como resposta o time de queimada adequado para esse 
            aluno.

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
            2) O Secretaria de Saúde recentemente adquiriu lotes de vacinas contra o covid-19. Esses lotes são 
            limitados e requer um filtro para separar as pessoas que serão vacinadas. Os dias de vacinação 
            será distribuído nos meses do ano. Janeiro, fevereiro e março, será as pessoas idosas (idade 
            superior ou igual a 65 anos). Abril, maio e junho pessoas maior de idade. Julho, agosto e setembro 
            pessoas menor de idade. Outubro, novembro e dezembro crianças de colo de zero a 3 anos.
            De acordo com esse calendário a prefeitura precisa que seja desenvolvido um programa para que 
            a pessoa saiba em qual mês irá ser vacinada. A pessoa deve entrar no sistema informar o seu 
            nome, CPF e ano em que nasceu. O programa deverá mostrar o mês de vacinação de acordo com 
            sua idade.

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
            3) A loja Brasileiras está com uma promoção imperdível na semana do consumidor. Ela está
            disponibilizando vários produtos com descontos que dependendo da forma de pagamento vai de 
            10% a 25%. Para aproveitar o máximo possível de desconto faça um programa que calcule e 
            mostre o valor a ser pago de um produto e o valor das parcelas. Utilize a tabela a seguir para ler 
            qual a condição de pagamento escolhida e efetuar o cálculo adequado. 
                • À vista em dinheiro, recebe 25% de desconto;
                • À vista no cartão de crédito, recebe 15% de desconto;
                • Em duas vezes, recebe 10% de desconto;
                • Em três vezes, recebe 5% de desconto;
                • Em dês vezes, preço normal.

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
            4) Uma empresa de transporte rodoviário necessita de um programa para verificar qual ônibus é
            mais rápido em uma viagem entre duas cidades. Considerando que dois ônibus fazem o mesmo 
            percurso, o programa deverá ler a distância entra as duas cidades a hora de saída e a hora de 
            chegada de cada um dos ônibus, e informa a velocidade do ônibus mais rápido.

            
            Console.Write("Digite a distancia entre as duas cidades em (km): ");
            int distancia = int.Parse(Console.ReadLine());
            Console.Write("Digite o tempo do percurso do PRIMEIRO ônibus em (horas): ");
            double tempo1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o tempo do percurso do SEGUNDO ônibus em (horas): ");
            double tempo2 = double.Parse(Console.ReadLine());

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
            5) Faça um programa console em c# que leia o destino do passageiro e se a viagem inclui volta ou 
            se é somente ida e informar o preço da passagem conforme a tabela a seguir: 
            CIDADE              IDA         VOLTA
            Bahia               1550,00     950,00
            Rio de Janeiro      850,00      550,00
            São Paulo           800,00      500,00
            Brasília            500,00      450,00
            

            Console.Write("Escolha seu desistino:\n (1) Brasília;\n (2) Rio de Janeiro;\n (3) São Paulo;\n (4) Bahia.\n");
            int destino = int.Parse(Console.ReadLine());
            Console.Write("A viagem ida e volta?\n (1)SIM\n (2)NÂO\n");
            int retorno = int.Parse(Console.ReadLine());

            if (retorno == 1)
            {
                if (destino == 1)
                {
                    Console.WriteLine("Brasília - Ida R$ 500,00 Volata R$ 450,00");
                    Console.WriteLine("Valor total: R$950,00 reais");
                }
                else if (destino == 2)
                {
                    Console.WriteLine("Rio de Janeiro - Ida R$ 850,00 Volta R$ 550,00");
                    Console.WriteLine("Valor total: R$1400,00 reais");
                }
                else if (destino == 3)
                {
                    Console.WriteLine("São Paulo - Ida R$ 800,00 Volta R$ 500,00");
                    Console.WriteLine("Valor total: R$1300,00 reais");
                }
                else if (destino == 4)
                {
                    Console.WriteLine("Bahia - Ida R$ 1550,00 Volta R$ 950,00");
                    Console.WriteLine("Valor total: R$2500,00 reais");
                }
                else
                {
                    Console.WriteLine("ERRO");
                }
            }
            else if (retorno == 2)
            {
                if (destino == 1)
                {
                    Console.WriteLine("Brasília - Ida R$ 500,00");
                    Console.WriteLine("Valor total: R$500,00 reais");
                }
                else if (destino == 2)
                {
                    Console.WriteLine("Rio de Janeiro - Ida R$ 850,00");
                    Console.WriteLine("Valor total: R$850,00 reais");
                }
                else if (destino == 3)
                {
                    Console.WriteLine("São Paulo - Ida R$ 800,00");
                    Console.WriteLine("Valor total: R$800,00 reais");
                }
                else if (destino == 4)
                {
                    Console.WriteLine("Bahia - Ida R$ 1550,00");
                    Console.WriteLine("Valor total: R$1550,00 reais");
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
        }
    }
}
