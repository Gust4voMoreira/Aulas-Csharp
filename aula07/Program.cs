using System;

namespace aula07 {
    class Program {
        static void Main(string[] args) {
            //Data: 30/03/2021
            /*
            1) Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C. 
            
            float a, b, c;
            Console.Write("valor A: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("valor B: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("valor C: ");
            c = float.Parse(Console.ReadLine());

            if ((a + b) > c)
            {
                Console.Write($"A soma de A + B é maior que o C");
            }
            */

            /*
            2) Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o ano que casou e mostrar o tempo de casada.
            
            string nome, estado_civil;
            char sexo;
            int tempo_casada, ano_casou, ano = DateTime.Now.Year;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite (M) para Masculino e (F) para Ferminino");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Estado civil: ");
            estado_civil = Console.ReadLine();

            if (sexo == 'F' && estado_civil == "CASADA")
            {
                Console.WriteLine("Digite o ano em que casou: ");
                ano_casou = int.Parse(Console.ReadLine());

                tempo_casada = ano - ano_casou;

                Console.WriteLine($"Tempo de casada é {tempo_casada} anos");
            }
            */

            /*
            3) Faça um algoritmo que leia um número e informar se o número é par ou ímpar.
            
            int n1;

            Console.Write("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            if((n1 % 2) == 0)
            {
                Console.Write("PAR");
            } 
            else
            {
                Console.Write("ÍMPAR")
            }
            //ou
            //string resposta = (resto == 0)? "par" : "impar";
            */

            /*
            4) Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se
            somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

            int A, B, C;

            Console.Write("Digite o primeiro número: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                C = A + B;
                Console.Write($"Os valores são iguais, portanto A + B = {C}");
            }
            else
            {
                C = A * B;
                Console.Write($"Os valores são diferentes, portanto A x B = {C}");
            }
            //ou
            // c = (A + B) ? A + B : A * B;
            //console.Write(c);
            */

            /*
            5) Faça um algoritmo que leia um número e imprima o seu dobro caso seja positivo e o seu triplo caso seja
            negativo.

            int n1;

            Console.Write("Digite um Número: ");
            n1 = int.Parse(Console.ReadLine());
            if (n1 < 0)
            {
                Console.Write($"O triplo do número digitado é: {n1 * 3}");
            }
            else if (n1 == 0)
            {
                Console.Write("Zero é neutro");
            }
            else
            {
                Console.Write($"O dobro do número digitado é: {n1 * 2}");
            }
            */

            /*
            6) O IMC – Indice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / ( altura )2. Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a tabela abaixo:		
            a - IMC em adultos Condição		
            b - Abaixo de 18,5 Abaixo do peso		
            c - Entre 18,5 e 25 Peso normal		
            d - Entre 25 e 30 Acima do peso		
            e - Acima de 30 obeso
            
            float altura, peso, imc;

            Console.Write("Digite o seu peso (em Kg): ");
            peso = float.Parse(Console.ReadLine());
            Console.Write("Digite o sua altura (em metros): ");
            altura = float.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            Console.WriteLine($ "IMC: {imc}");

            if (imc < 18.5) {
                Console.WriteLine("Abaixo do normal");
            } else if (imc > 18.5 && imc < 25) {
                Console.WriteLine("Peso normal");
            } else if (imc > 25 && imc < 30) {
                Console.WriteLine("Acima do Peso");
            } else if (imc > 30) {
                Console.WriteLine("Obeso");
            }
            */

            /*
            7) Faça um algoritmo que calcule o valor a ser pago por um produto de acordo com a forma de pagamento. Formas de pagamento: 
            
            (1) - À vista, recebe 10% de desconto;   
            (2) - Cartão de Débito 8% de desconto;   
            (3) - Cartão de Crédito à vista 5% de desconto;   
            (4) - Parcelado em 10X, preço normal mais 5% de juros; 
            
            O usuário deverá informar o valor do produto, a forma de pagamento e ter como resultado o valor a ser pago.
            */

            double valor_pago, produto;
            int escolha;

            Console.WriteLine("Digite o valor do Produto: ");
            produto = double.Parse(Console.ReadLine());
            Console.Write("\n(1) - À vista, recebe 10% de desconto.\n(2) - Cartão de Débito 8% de desconto.\n(3) - Cartão de Crédito à vista 5% de desconto.\n(4) - Parcelado em 10X, preço normal mais 5% de juros.\n");
            Console.WriteLine("\nEscolha a forma de pagamento: ");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1) 
            {
                Console.WriteLine("À vista, recebe 10% de desconto");
                valor_pago = produto - ((produto * 10) / 100);
                Console.WriteLine($"Valor: R$ {Math.Round(valor_pago, 2)} reais");
            } 
            else if (escolha == 2) 
            {
                Console.WriteLine("Cartão de Débito 8% de desconto");
                valor_pago = produto - ((produto * 8) / 100);
                Console.WriteLine($"Valor: R$ {Math.Round(valor_pago, 2)} reais");
            } 
            else if (escolha == 3) 
            {
                Console.WriteLine("Cartão de Crédito à vista 5% de desconto");
                valor_pago = produto - ((produto * 5) / 100);
                Console.WriteLine($"Valor: R$ {Math.Round(valor_pago, 2)} reais");
            } 
            else if (escolha == 4) 
            {
                Console.WriteLine("Parcelado em 10X");
                valor_pago = produto + ((produto * 5)/100);
                Console.WriteLine($"Valor por parcela: R$ {Math.Round(valor_pago/10, 2)} reais");
                Console.WriteLine($"Valor total: R$ {Math.Round(valor_pago, 2)} reais");
            } 
            else 
            {
                Console.Write("ERRO");
            }
        }
    }
}