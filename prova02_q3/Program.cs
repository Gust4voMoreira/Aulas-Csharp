using System;

namespace prova02_q3
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
            //não precisa de função
        static void Main(string[] args)
        {
            int tamanho = 10;//10

            Console.WriteLine("//////////PARCIAL////////////");
            var vet1 = vetUm(tamanho);
            Console.WriteLine("//////////OFICIAL////////////");
            var vet2 = vetDois(tamanho);
            Console.WriteLine("//////////MÉDIA////////////");
            var vetM = vetMedia(tamanho, vet1, vet2);
            imprimir(vetM, vet1, vet2);
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
                vetNum[i] = ((vet1[i] * 2) + (vet2[i] * 8)) / 100;
            }
            return vetNum;
        }

        static void imprimir(float[] vetM, float[] vet1, float[] vet2)
        {
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.WriteLine($"Notas do {i+1}° aluno: \nPARCIAL: {vet1[i]/10}\nOFICIAL: {vet2[i]/10}\nMÉDIA: {vetM[i].ToString("N1")}");
            }
        }
    }
}
