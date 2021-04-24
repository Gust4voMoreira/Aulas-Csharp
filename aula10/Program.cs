using System;

namespace aula10 {
    class Program {
        static void Main(string[] args) {
            //Data: 24/04/2021

            /*
            //1)
            int cont = 1;
            while (cont <= 10)
            {
                Console.WriteLine($"{cont} Gustavo");
                cont ++;
            }
            //--------------
            //2)
            int cont = 11;
            do
            {
                Console.WriteLine($"{cont} Gustavo");
                cont ++;
            } 
            while (cont <= 10);
            //-------------
            //3)
            for (int i = 1; i <= 10; i--) 
            {
                Console.WriteLine($"{i} Gustavo");
            }
            */

            /*
            4) Faça um programa que escreva os números ímpares entre 100 e 200

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0){
                    Console.WriteLine(i);
                }
            }
            //ou
            int cont = 101;

            while (cont < 200)
            {
                Console.WriteLine(cont);
                cont += 2;
            }
            */
            
            /*
            5) Faça um programa que efetue a soma de números entre 1 a 50.

            int num = 1, soma = 0;

            while (num <= 50)
            {
                soma += num; 
                num++; 
            }
            Console.WriteLine(soma);
            */

            /*
            6) Desenvolva um programa que efetue a soma de todos os números ímpares que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500.
            */
            int num = 1, soma = 0;

            while (num <= 500)
            {
                soma += num; 
                if(soma % 2 != 0)
                {
                    if (soma % 3 == 0)
                    {
                        Console.WriteLine(soma);
                    } 
                }
                num++;
            }
            //ERRO
        }
    }
}