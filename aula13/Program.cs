using System;

namespace aula13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 11/05/2021
            /*1) Ler 10 números inteiros utilizando vetor.

            int[] vetNum = new int[10];

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.WriteLine($"Digite um número na posição {i} do vetor:");
                vetNum[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O VETOR PREENCHIDO");

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.Write($"{vetNum[i]}|");
            }
            */

            /*2) Faça um programa que o usuário informe o nome e a idade de cinco alunos. Utilize um vetor para o cada um dados informados, ou seja, um vetor para os nomes e um vetor para as idades. Após o preenchimento dos vetores mostrar os nomes com suas respectivas idades.

            int[] vetIdade = new int[5];
            string[] vetNome = new string[5];

            for (int i = 0; i < vetNome.Length; i++)
            {
                Console.Write($"Digite o nome do {i + 1}° aluno: ");
                vetNome[i] = Console.ReadLine();
                Console.Write($"Digite a idade do {i + 1}° aluno: ");
                vetIdade[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O VETOR PREENCHIDO");

            for (int i = 0; i < vetNome.Length; i++)
            {
                Console.Write($"{vetNome[i]} tem {vetIdade[i]} anos");
            }
            */

            //Ex:
            /*1) Crie um programa que leia 6 valores inteiros, armazene em um vetor, em seguida, 
            mostre na tela os valores lidos.

            int[] vetNum = new int[6];

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.WriteLine($"Digite um número na posição {i} do vetor:");
                vetNum[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O VETOR PREENCHIDO");

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.Write($"{vetNum[i]}|");
            }
            */

            /*2)Faça um algoritmo que leia um conjunto de números inteiros, armazenando-o em 
            vetor e calcular o quadrado das componentes deste vetor, armazenando o resultado em 
            outro vetor. Cada vetor tem 10 elementos cada. Mostrar os valores dos dois vetores.

            int[] vetNum = new int[10];
            int[] vetQuad = new int[10];

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.WriteLine($"Digite um número na posição {i + 1} do vetor:");
                vetNum[i] = int.Parse(Console.ReadLine());

                vetQuad[i] = vetNum[i] * vetNum[i];
            }

            Console.WriteLine("O QUADRADO DO VETOR PREENCHIDO");

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.WriteLine($"O quadrado do número {vetNum[i]} é {vetQuad[i]}");
            }
            */

            /*3) Faça um programa que leia um vetor de 8 posições e, em seguida, leia também dois 
            valores X e Y quaisquer correspondentes a duas posições no vetor. Ao final seu programa 
            deverá escrever a soma dos valores encontrados nas respectivas posições X e Y.

            int[] vetNum = new int[8];
            int x, y, i;

            for (i = 0; i < vetNum.Length; i++)
            {
                Console.WriteLine($"Digite um número na posição {i} do vetor:");
                vetNum[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite a posição de X: ");
            i = int.Parse(Console.ReadLine());
            x = vetNum[i];
            Console.WriteLine("Digite a posição de Y: ");
            i = int.Parse(Console.ReadLine());
            y = vetNum[i];

            Console.WriteLine($"X: {x} e Y: {y}");
            */

            /*4) Leia um vetor de 10 posições. Contar e escrever quantos valores pares ele possui.

            int[] vetNum = new int[4];
            int cont = 0;

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.WriteLine($"Digite um número na posição {i} do vetor:");
                vetNum[i] = int.Parse(Console.ReadLine());

                if (vetNum[i] % 2 == 0)
                {
                    cont ++;
                    Console.WriteLine($"A posição {i} é par");
                    Console.WriteLine($"Número de Pares: {cont}");
                }
            }
            */

            /*5) Faça um programa que o usuário preencha um vetor de 10 posições. Em seguida 
            deverá ser impresso o maior e o menor elemento do vetor;

            int[] vetNum = new int[4];
            int menor, maior;

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.WriteLine($"Digite um número na posição {i} do vetor:");
                vetNum[i] = int.Parse(Console.ReadLine());
            }

            maior = vetNum[0];
            menor = vetNum[0];

            for (int i = 0; i < vetNum.Length; i++)
            {
                if (vetNum[i] > maior)
                {
                    maior = vetNum[i];
                }

                if (vetNum[i] < menor)
                {
                    menor = vetNum[i];
                }
            }

            Console.WriteLine($"Maior: {maior}");
            Console.WriteLine($"Menor: {menor}");
            */

            /*6) Crie um programa que lê 6 valores inteiros e, em seguida, mostre na tela os valores 
            lidos na ordem inversa.

            int[] vetNum = new int[6];

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.WriteLine($"Digite um número na posição {i} do vetor:");
                vetNum[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ordem inversa");
            for (int i = 6; i > 0; i--)
            { 
                Console.WriteLine($"{vetNum[i-1]}");
            }
            */
        }
    }
}
