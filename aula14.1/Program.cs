using System;

namespace aula14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data:25/05/2021
            int qtdAlunos;

            Console.WriteLine("Calcular Média Bimestral");
            Console.WriteLine("Digite o número de alunos da turma:");
            qtdAlunos = int.Parse(Console.ReadLine());

            var ntPrim = pVetor(qtdAlunos);
        }

        static float[] pVetor(int qtd)
        {
            float[] vetNotas = new float[qtd];

            for (int i = 0; i < vetNotas.Length; i++)
            {
                Console.WriteLine($"Digite a nota do {i+1}° aluno: ");
                vetNotas[i] = float.Parse(Console.ReadLine());
            }
            return vetNotas;
        }
    }
}
