using System;

namespace aulaPoo02
{
    class Program
    {
        //DESAFIO 03
        /*Um Programa que o usuário deverá informar o nome e a idade três pessoas. O Programa deverá informar o nome da pesssoa que possuir a maior idade */
        
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3;

            Console.WriteLine("Determinar qual pessoa é a mais velha: ");
            Console.WriteLine("Nome da 1° pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 1° pessoa: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nome da 2° pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 2° pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());
            
            //Opção
            Console.WriteLine("Nome da 3° pessoa: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Idade da 3° pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            p3 = new Pessoa(nome, idade);

            if ((p1.Idade == p2.Idade) && (p2.Idade == p3.Idade))
            {
                Console.WriteLine("Todas as pessoas tem a mesma idade");
            }
            else if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                p1.ExibirDados();
            }
            else if (p2.Idade > p3.Idade)
            {
                p2.ExibirDados();
            }
            else 
            {
                p3.ExibirDados();
            }
        }
    }
}
