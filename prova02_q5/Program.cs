using System;

namespace prova02_q5
{
    class Program
    {
        /*
        5)Faça um programa em c# que leia 5 números inteiros positivos (utilize uma função que leia esse 
        número e verifique se ele é positivo). Para cada número informado escrever a soma de seus 
        divisores (exceto ele mesmo). 
        Utilize a função SomaDivisores para obter a soma. 
        Nome: SomaDivisores 
        Descrição: Calcula a soma dos divisores do número informado (exceto ele mesmo). 
        Entrada: Um número inteiro e positivo. 
        Saída: A soma dos divisores. 
        Exemplo: Para o valor 8: 1+2+4 = 7
        */
        static void Main(string[] args)
        {
            int numero, total;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° número");
                numero = int.Parse(Console.ReadLine());

                total = somaDivisores(numero);
                Console.WriteLine($"A soma dos divisores de {numero} é {total}");
                Console.WriteLine();
            }
        }
        static int somaDivisores(int num)
        {
            int soma = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    soma += i;
                }
            }
            return soma;
        }
    }
}
