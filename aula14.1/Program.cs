using System;

namespace aula14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data:25/05/2021
            int qtd;

            Console.WriteLine("Calcular Média Bimestral");
            Console.WriteLine("Digite o número de alunos da turma:");
            qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro Bimestre");
            var notPri = pVetor(qtd);
            Console.WriteLine("Segundo Bimestre");
            var notSeg = pVetor(qtd);

            Console.WriteLine("Notas Primeiro Bimestre");
            imprimir(notPri);
            Console.WriteLine("Notas Segundo Bimestre");
            imprimir(notSeg);
            impMedia(notPri, notSeg);
            impResul(notPri, notSeg);
        }

        static float[] pVetor(int qtd)
        {
            float[] vetNotas = new float[qtd];

            for (int i = 0; i < vetNotas.Length; i++)
            {
                Console.WriteLine($"Digite a nota do {i + 1}° aluno: ");
                vetNotas[i] = float.Parse(Console.ReadLine());
            }
            return vetNotas;
        }

        static float media(float nota1, float nota2)
        {
            return (nota1 + nota2) / 2;
        }

        static void imprimir(float[] vetNotas)
        {
            for (int i = 0; i < vetNotas.Length; i++)
            {
                Console.Write($" {vetNotas[i]} |");
            }
            Console.WriteLine();
        }

        static void impMedia(float[] notPri, float[] notSeg)
        {
            Console.WriteLine("Media dos alunos da turma");
            for (int i = 0; i < notPri.Length; i++)
            {
                Console.Write($"{media(notPri[i], notSeg[i])} |");
            }
        }

        static void impResul(float[] notPri, float[] notSeg)
        {
            for (int i = 0; i < notPri.Length; i++)
            {
                if ( media(notPri[i],notSeg[i]) >= 6)
                {
                    Console.WriteLine($"O aluno {i+1} está aprovado");
                }
                else
                {
                     Console.WriteLine($"O aluno {i+1} está reprovado");
                }
            }
        }
    }
}
