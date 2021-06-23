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
            var media = new float[10];

            var notP1 = fVetor1(10);
            var notP2 = fVetor2(10);
            
            imprimir(notP1, notP2);
            
            for (int i = 0; i < 10; i++)
            {
                media[i] = ((notP1[i] * 2) + (notP2[i] * 8)) / 10;
                if (media[i] > 10)
                {
                    Console.WriteLine($"{i+1}° aluno, não tem uma media valida"); 
                }
                else
                {
                    Console.WriteLine($"A média do {i+1}° aluno é: {media[i]}"); 
                }
            }
        }

        static float[] fVetor1(int vet1)
        {
            float[] vetor1 = new float[vet1];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine($"Digite a nota da prova parcial do {i+1}° aluno: ");
                vetor1[i] = float.Parse(Console.ReadLine());
            }
            return vetor1;
        }

        static float[] fVetor2(int vet2)
        {
            float[] vetor2 = new float[vet2];

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine($"Digite a nota da prova oficial do {i+1}° aluno: ");
                vetor2[i] = float.Parse(Console.ReadLine());
            }
            return vetor2;
        } 

        static void imprimir(float[] vetNotas1, float[] vetNotas2)
        {
            for (int i = 0; i < vetNotas1.Length; i++)
            {
                Console.WriteLine($"{i+1}° aluno, nota da prova Parcial: {vetNotas1[i]}, prova Oficial: {vetNotas2[i]}");
            }
        }
    }
}
