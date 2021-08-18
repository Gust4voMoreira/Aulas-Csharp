using System;

namespace aulaPoo01
{
    class Program
    {
        /*Valkiria é a diretora da escola Mundo Melhor. Ela precisa de um programa que armazene alunos com suas matrículas e notas em uma "tabela" no final,ela tem a necessidade de saber se o aluno foi aprovado ou não faça um programa para resolver a questão da Valkiria*/
        static void Main(string[] args)
        {
            //obs: eu não sei quantas notas são, nem quantos alunos, nem a media :(
            int qtd;
            double n1, n2;

            Console.WriteLine("Digite o número de alunos:");
            qtd = int.Parse(Console.ReadLine());

            double[] vetMedia = new double[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Digite a nota do Primeiro Bimestre do {i+1}° aluno: ");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a nota do Segundo Bimestre do {i+1}° aluno: ");
                n2 = double.Parse(Console.ReadLine());

                vetMedia[i] = n1 + n2;
            }
            
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Média do {i+1}° aluno foi {vetMedia[i]/2}");
                if (vetMedia[i]/2 < 6)
                {
                    Console.WriteLine("Não Aprovado");
                }
                else
                {
                    Console.WriteLine("Aprovado");
                }
                
            }
            
        }
    }
}
