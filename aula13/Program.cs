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

            do
            {
                Console.WriteLine("Digite dois números de 0 a 7");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            } while (x < 0 || x > 7 || y < 0 || y > 7);

            Console.WriteLine($"A soma de {vetNum[x]} + {vetNum[y]} = {vetNum[x] + vetNum[y]}");
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
            */
            int[] vetNum = new int[10];
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
                Console.WriteLine($"{vetNum[i]}");
            }
            */

            /*7) Faça um programa para ler a nota da prova de 15 alunos e armazene num vetor, 
            calcule e imprima a média geral.
            
            int[] vetNum = new int[15];
            int i;
            float media = 0;

            for (i = 0; i < vetNum.Length; i++)
            {
                Console.WriteLine($"Digite a nota do {i+1}° aluno: ");
                vetNum[i] = int.Parse(Console.ReadLine());

                media += vetNum[i];
            }

            Console.WriteLine($"{media/15}");
            */

            /*8) Faça um programa que preencha um vetor com 10 números reais, calcule e mostre a 
            quantidade de números negativos e a soma dos números positivos desse vetor.

            double soma = 0, negativo = 0;
            double[] vetNum = new double[4];
            

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("digite um número: ");
                vetNum[i] = double.Parse(Console.ReadLine());

                if (vetNum[i] > 0)
                {
                    soma += vetNum[i];
                }
                if (vetNum[i] < 0)
                {
                    negativo += +1;
                }
            }

            Console.WriteLine($"Soma dos números positivos: {soma}");
            Console.WriteLine($"Negativo: {negativo}");
            */

            /*9) Faça um programa que leia um vetor de 10 posições e verifique se existem valores iguais e os escreva na tela.  
            
            int [] vetNum = new int[10];

            for (int i = 0; i < vetNum.Length; i++)
            {
                vetNum[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("os números que repete no vetor");
            for (int i = 0; i < vetNum.Length; i++)
            {
                for (int j = i + 1; j < vetNum.Length; j++)
                {
                    if (vetNum[i] == vetNum[j])
                    {
                        Console.WriteLine(vetNum[i]);
                    }
                }
            }
            */

            /*10) Leia um vetor com 20 números inteiros. Escreva os elementos do vetor eliminando 
            elementos repetidos.
            
            int[] vetNum = new int[10];
            int cont;

            for (int i = 0; i < vetNum.Length; i++)
            {
                vetNum[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Os números que não se repete no vetor");
            for (int i = 0; i < vetNum.Length; i++)
            {
                cont = 0;
                for (int j = 0; j < vetNum.Length; j++)
                {
                    if (i != j)
                    {
                        if (vetNum[i] == vetNum[j])
                        {
                            cont++;
                        }
                    }
                }
                if (cont == 0)
                {
                    Console.WriteLine(vetNum[i]);
                }
            }
            */

            /*11) Faça um programa que leia um vetor de 5 posições para números reais e, depois, 
            um código inteiro. Se o código for zero, finalize o programa; se for 1, mostre o vetor na 
            ordem direta; se for 2, mostre o vetor na ordem inversa. Caso, o código for diferente de 
            1 e 2 escreva uma mensagem informando que o código é inválido.


            int[] vetNum = new int[5];
            int escolha;

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º Número: ");
                vetNum[i] = int.Parse(Console.ReadLine());
            }
            do
            {
                Console.Write("\nEscolha uma Opcão: ");
                Console.WriteLine("\n( 0 )Encerrar o programa\n( 1 ) Mostra Vetor na ordem direta\n( 2 ) Mostrar Vetor na ordem inversa  ");
                escolha = int.Parse(Console.ReadLine());

                if (escolha != 1 && escolha != 2 && escolha != 0)
                {
                    Console.WriteLine("Incorreto, escolha outra opção!");
                }

            } while (escolha != 1 && escolha != 2 && escolha != 0);

            if (escolha == 0)
            {
                Console.WriteLine("Programa Encerrado.");
            }
            else if (escolha == 1)
            {
                for (int i = 0; i < vetNum.Length; i++)
                {
                    Console.WriteLine("Vetor na forma Direta: ");
                    Console.WriteLine($"{vetNum[i]} |");
                }
            }
            else if (escolha == 2)
            {
                for (int i = 4; i > 0; i--)
                {
                    Console.WriteLine("Vetor na forma inversa: ");
                    Console.WriteLine($"{vetNum[i]}");
                }
            }
            */
        }
    }
}
