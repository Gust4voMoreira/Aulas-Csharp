using System;

namespace aulaPoo01
{
    class Program
    {
        /*Valkiria é a diretora da escola Mundo Melhor. Ela precisa de um programa que armazene alunos com suas matrículas e notas em uma "tabela" no final,ela tem a necessidade de saber se o aluno foi aprovado ou não faça um programa para resolver a questão da Valkiria*/
        static void Main(string[] args)
        {
            //obs: eu não sei quantas notas são, nem quantos alunos, nem a media :(
            // int qtd;
            // double n1, n2;

            // Console.WriteLine("Bem-vindo, Walkiria!");
            // Console.WriteLine("Digite o número de alunos:");
            // qtd = int.Parse(Console.ReadLine());

            // double[] vetMedia = new double[qtd];

            
            

////////////////////////////
        var nome = "";
        int matricula = 0;
        var opcao = "s";

        Console.WriteLine("Bem-vindo, Walkiria!\n");

        while (opcao.ToLower() =="s" )
        {
            
            Console.WriteLine("Digite o nome do aluno:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a Matricula do aluno:");
            matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite as Notas do aluno: \n");
            double [] nota = new double[3];

            double soma = 0;
            double media = 0;
        
            for(int i=0; i<3; i++)
            {
                Console.WriteLine($"{i + 1}ª nota:");
                nota[i] = Convert.ToDouble(Console.ReadLine());
                soma += nota[i];
            }

            media = soma / nota.Length;

            Console.WriteLine($"\nMédia do Aluno {nome} foi de {media.ToString("N1")}");

            if( media >= 6)
            {
                Console.WriteLine("APROVADO\n");
            }
            else
            {
                Console.WriteLine("REPROVADO\n");
            }
    
            Console.WriteLine("Deseja cadastrar um novo aluno? S ou N: \n");
            opcao = Console.ReadLine();
            Console.Clear();
        }
            
        }
    }
}
