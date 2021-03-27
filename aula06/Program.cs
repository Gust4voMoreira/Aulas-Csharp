using System;

namespace aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data: 27/03/2021
            /*
            1)
            Console.Write("Digite a nota do primeiro bimestre: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota do segundo bimestre: ");
            float nota2 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é: {media} ");     

            if (media >= 6)
            {
                Console.Write("APROVADO");
            }
            else if (media >= 4)
            {
                Console.Write("EXAME");
            }
            else
            {
                Console.Write("REPROVADO");
            }
            */

            /*
            2)
            */
            Console.Write("Digite a nota do primeiro bimestre: ");
            int mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    Console.WriteLine("JANEIRO");
                    break;
                case 2:
                    Console.WriteLine("FEVEREIRO");
                    break;
                case 3:
                    Console.WriteLine("MARÇO");
                    break;
                case 4:
                    Console.WriteLine("ABRIL");
                    break;
                case 5:
                    Console.WriteLine("MAIO");
                    break;
                case 6:
                    Console.WriteLine("JUNHO");
                    break;
                case 7:
                    Console.WriteLine("JULHO");
                    break;
                case 8:
                    Console.WriteLine("AGOSTO");
                    break;
                case 9:
                    Console.WriteLine("SETEMBRO");
                    break;
                case 10:
                    Console.WriteLine("OUTUBRO");
                    break;
                case 11:
                    Console.WriteLine("NOVEMBRO");
                    break;
                case 12:
                    Console.WriteLine("DEZEMBRO");
                    break;
                default:
                    Console.WriteLine("Mês Inválido");
                    break;
            }
        }
    }
}
