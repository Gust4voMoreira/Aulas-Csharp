using System;

namespace aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 23/03/2021
            /*
            1)Faça um algorirtmo para mostrar o  Maior número e o Menor número digitado pelo usuário. O usuário deverá digitar três números.
            Faça um algorirtmo para mostrar o  Maior número e o Menor número digitado pelo usuário. O usuário deverá digitar três números.
            
            Console.WriteLine("Introduza x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza z: ");
            int z = int.Parse(Console.ReadLine());

            if (x == y && y == z)
            {
                Console.WriteLine("O x e y e z são iguais");
            }
            else if (x > y && x > z)
            {
                Console.WriteLine($"O maior é x: {x}");
            }
            else if (y > z)
            {
                Console.WriteLine($"O maior é y: {y}");
            }
            else
            {
                Console.WriteLine($"O maior é z: {z}");
            }
            
            if (x < y && x < z)
            {
                Console.WriteLine($"O menor é x: {x}");
            }
            else if (y < z)
            {
                Console.WriteLine($"O menor é y: {y}");
            }
            else
            {
                Console.WriteLine($"O menor é z: {z}");
            }   
            */

            /*
            2)Faça um programa para calcular a média ponderada de duas notas que será informada pelo usuário. O peso da primeira nota será 2 e o peso da segunda nota será 8. Mostrar na tela a média e os seguintes textos dependendo das condições: média maior ou igual a 6 – “Aprovado”, média maior que 4 e menor que 6 – “Exame Final” e média menor que 4 – “Reprovado”.
            */

            float nota1, nota2, media;

            Console.Write("Digite a primeira nota com peso 2: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota com peso 8: ");
            nota2 = float.Parse(Console.ReadLine());

            media = ((nota1 * 2) + (nota2 * 8)) / 10;
            Console.WriteLine($"A média é: {media}");

            if (media >= 6)
            {
                Console.Write("APROVADO");
            }
            else if (media >= 4 && media < 6)
            {
                Console.Write("EXAME");
            }
            else
            {
                Console.Write("REPROVADO");
            }
        }
    }
}
