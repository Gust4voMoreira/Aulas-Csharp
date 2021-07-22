using System;

namespace ex
{
    class Program
    {
        /*
            3)Faça um programa que leia dois vetores de 10 posições. O primeiro vetor corresponde as notas da 
            prova parcial de dez alunos. O segundo vetor as notas da prova oficial dos mesmos dez alunos. 
            O programa deverá calcular a média aritmética ponderada, sendo peso 2 para parcial e peso 8 para 
            oficial, e armazenar em um outro vetor, ou seja, um novo vetor irá receber as médias. Ao final o 
            programa deverá mostrar as notas da prova parcial, da prova oficial e a média dos alunos.
            Obs: A nota vai de 0 a 10. Não é permitido a entrada de outro valor.
            */
        static void Main(string[] args)
        {
            int tamanho = 5;//10

            Console.WriteLine("//////////PARCIAL////////////");
            var vet1 = vetUm(tamanho);
            Console.WriteLine("//////////OFICIAL////////////");
            var vet2 = vetDois(tamanho);
            Console.WriteLine("//////////MÉDIA////////////");
            var vetM = vetMedia(tamanho,vet1, vet2);
        }

        static float[] vetUm(int tamanho)
        {
            float[] vetNum = new float[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Digite a nota parcial do {i+1}° aluno:");
                vetNum[i] = float.Parse(Console.ReadLine());
            }
            return vetNum;
        }

        static float[] vetDois(int tamanho)
        {
            float[] vetNum = new float[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Digite a nota oficial do {i+1}° aluno:");
                vetNum[i] = float.Parse(Console.ReadLine());
            }
            return vetNum;
        }

        static float[] vetMedia(int tamanho, float[] vet1, float[] vet2)
        {
            float[] vetNum = new float[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                vetNum[i] = vet1[i] * vet2[i];
            }
            return vetNum;
        }

        static void imprimir(int[] mult, int[] vetNum1, int[] vetNum2)
        {
            for (int i = 0; i < mult.Length; i++)
            {
                Console.WriteLine($"{vetNum1[i]} X {vetNum2[i]} = {mult[i]}");
            }
        }
    }
}
