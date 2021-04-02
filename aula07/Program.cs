﻿using System;

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
            */
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

        }
    }
}