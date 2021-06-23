using System;

namespace prova02_q3
{
    class Program
    {
        static void Main(string[] args)
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

            var vet1 = new float[3];
            var vet2 = new float[3];
            var media = new float[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota da prova parcial do {i+1}° aluno: ");
                vet1[i] = int.Parse(Console.ReadLine());   
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota da prova oficial do {i+1}° aluno: ");
                vet2[i] = int.Parse(Console.ReadLine());   
            }

            for (int i = 0; i < 3; i++)
            {
                media[i] = ;
                Console.WriteLine($"A média é: {media[i]}");   
            }
        }

        // static void Imprimir(int vet)
        // {
        //     for (int i = 0; i < vet; i++)
        //     {
        //         Console.Write($"{i+1}° aluno, nota da prova Parcial {vet1[i]}: ");
        //     }
        // }        
    }
}
