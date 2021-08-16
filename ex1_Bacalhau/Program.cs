using System;

namespace ex1_Bacalhau
{
    class Program
    {
      
        static void Main(string[] args)
        {
            /*
            1) Desenvolva um programa capaz de ler um valor inteiro N. N * 2 linhas de saída
            vão ser apresentadas na execução do programa, seguindo a lógica do exemplo
            mais abaixo. Para os valores com mais de seis dígitos, todos os dígitos devem
            ser apresentados.
            
            int num;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine($"{i} {i*i} {(i*i)*i}");
                    Console.WriteLine($"{i} {i*i+1} {(i*i)*i+1}");
                }
            }
            */

            /*
            2) Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
            obs: Imprima a variável MEDIA conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. 
            
            Console.WriteLine($"Digite a nota A do aluno:");
            double notaA = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Digite a nota B do aluno:");
            double notaB = double.Parse(Console.ReadLine());
     
            Console.WriteLine($"Digite a nota C do aluno:");
            double notaC = double.Parse(Console.ReadLine());

            Console.WriteLine("//////////MÉDIA////////////");
            double media = ((notaA * 2) + (notaB * 3) + (notaC * 5)) / 100;

            Console.WriteLine($"Notas do aluno: \nA: {notaA/10}\nB: {notaB/10}\nC: {notaC/10}\nMÉDIA: {media.ToString("N1")}");
            */

            /*
            3) Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.
            obs: A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.
            obs: O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores positivos digitados.

            //erro
            */

            double num, cont = 0, soma = 0;
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um número: ");
                num = double.Parse(Console.ReadLine());

                if (num > 0)
                {
                    cont++;
                    soma += num;
                }
            }

            Console.WriteLine($"{cont} valores positivos");
            Console.WriteLine($"{soma/cont}");
            
            /*
            4) Você recebeu o desafio de ler um valor e criar um programa que coloque o valor lido na primeira posição de um vetor N[10]. Em cada posição subsequente, coloque o dobro do valor da posição anterior. Por exemplo, se o valor lido for 1, os valores do vetor devem ser 1,2,4,8 e assim sucessivamente. Mostre o vetor em seguida.
            obs: Para cada posição do vetor, escreva "N[i] = X", onde i é a posição do vetor e X é o valor armazenado na posição i. O primeiro número do vetor N (N[0]) irá receber o valor de V.

            int num;
            int i = 1; 

            Console.WriteLine("Digite um número");
            num = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"N[{i}] = {num}"); 

                num = num * 2;

                i++;
            } 
            while (i < 10);
            */
        }
    }
}
