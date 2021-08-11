using System;

namespace ex1_Bacalhau
{
    class Program
    {
        /*
        1) Desenvolva um programa capaz de ler um valor inteiro N. N * 2 linhas de saída
        vão ser apresentadas na execução do programa, seguindo a lógica do exemplo
        mais abaixo. Para os valores com mais de seis dígitos, todos os dígitos devem
        ser apresentados.
        */
        static void Main(string[] args)
        {
            /*
            1) Desenvolva um programa capaz de ler um valor inteiro N. N * 2 linhas de saída
            vão ser apresentadas na execução do programa, seguindo a lógica do exemplo
            mais abaixo. Para os valores com mais de seis dígitos, todos os dígitos devem
            ser apresentados.
            */
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
        }
    }
}
