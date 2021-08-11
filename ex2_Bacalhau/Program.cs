using System;

namespace ex2_Bacalhau
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 10;

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
