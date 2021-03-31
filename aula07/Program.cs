using System;

namespace aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1) Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C. 
            
            float a, b, c;
            Console.Write("valor A: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("valor B: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("valor C: ");
            c = float.Parse(Console.ReadLine());

            if((a + b) > c){
                Console.Write($" A + B = {a+b}, é maior que c");
            } else {
                Console.Write($"C = {c}, é maior que a soma de A e B");
            }
            */

            /*
            2) Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o ano que casou e mostrar o tempo de casada.
            */

            string nome, estado_civil;
            char sexo;
            int tempo_casada, ano_casou, ano = DateTime.Now.Year;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite (M) para Masculino e (F) para Ferminino");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Estado civil: ");
            estado_civil = Console.ReadLine();

            if(sexo == 'F' && estado_civil == "CASADA"){
                Console.WriteLine("Digite o ano em que casou: ");
                ano_casou = int.Parse(Console.ReadLine());

                tempo_casada = ano - ano_casou;

                Console.WriteLine($"Tempo de casada é {tempo_casada} anos");
            }

            /*
            3) Faça um algoritmo que o leia um número e informar se o número é par ou ímpar.
            */
        }
    }
}
