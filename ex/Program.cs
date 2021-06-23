using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetNum = new int[5];

            for (int i = 0; i < vetNum.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º Numéro: ");
                vetNum[i] = int.Parse(Console.ReadLine());

                if (vetNum[i] <= 0)
                {
                    Console.Write("\nDigite numeros maiores que 0, Pressione Para Continuar");
                    Console.ReadKey();
                    Console.Clear();

                    i = i - 1;
                }
            }
            var maNum = MaioNum(vetNum);
            var media = MediaNum(vetNum);
        }

        static int[] MaioNum(int[] vetNum)
        {
            int maior = 0;
            for (int i = 0; i < vetNum.Length; i++)
            {

                if (vetNum[i] > maior)
                {
                    maior = vetNum[i];
                }
            }
            Console.Write($"\nO maior número digitado é: {maior} ");

            return vetNum;
        }

        static int[] MediaNum(int[] vetNum)
        {
            float media = 0, soma = 0, cont = 0;
            for (int i = 0; i < vetNum.Length; i++)
            {
                soma = (float)soma + vetNum[i];
                cont++;
            }

            media = (float)soma / cont;

            Console.Write($"\nA média dos números digitados é: {media} ");

            return vetNum;
        }
    }
}
