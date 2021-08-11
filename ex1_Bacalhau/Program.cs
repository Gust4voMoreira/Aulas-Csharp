using System;

namespace ex1_Bacalhau
{
    class Program
    {
        /*
        Desenvolva um programa capaz de ler um valor inteiro N. N * 2 linhas de saída
        vão ser apresentadas na execução do programa, seguindo a lógica do exemplo
        mais abaixo. Para os valores com mais de seis dígitos, todos os dígitos devem
        ser apresentados.
        */
        static void Main(string[] args)
        {
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
        }
    }
}
