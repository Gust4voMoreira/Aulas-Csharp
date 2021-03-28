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

            if(media >= 9.0){
                Console.WriteLine("A - APROVADO");
            } else if(media >= 7.5){
                Console.WriteLine("B - APROVADO");
            } else if(media >= 6.0){
                Console.WriteLine("C - APROVADO");
            } else if(media >= 4.0){
                Console.WriteLine("D - REPROVADO");
            } else if(media >= 0){
                Console.WriteLine("E - REPROVADO");
            } else {
                Console.WriteLine("ERRO");
            }
            */

            /*
            2)
            */
            string combustivel;
            double etanol = 4.75, gasolina = 5.67, custo;
            int litros;
            double desconto1, desconto2, desconto3, desconto4;

            Console.Write("Para Etanol digite E ou para Gasolina digite G: ");
            combustivel = Console.ReadLine();

            if(combustivel == "E"){
                Console.Write("Quantos Litros: ");
                litros = int.Parse(Console.ReadLine());
                custo = litros * etanol;
                if(litros <= 20){
                    desconto1 = (custo * 3)/100;
                    Console.WriteLine($"O preço do Etanol por {litros} litros é: R${custo - desconto1} reais");
                } else {
                    desconto2 = (custo * 5)/100;
                    Console.WriteLine($"O preço do Etanol por {litros} litros é: R${custo - desconto2} reais");
                }
            } else if(combustivel == "G"){
                Console.Write("Quantos Litros: ");
                litros = int.Parse(Console.ReadLine());
                custo = litros * gasolina;
                if(litros <= 20){
                    desconto3 = (custo * 4)/100;
                    Console.WriteLine($"O preço do gasolina por {litros} litros é: R${custo - desconto3} reais");
                } else {
                    desconto4 = (custo * 6)/100;
                    Console.WriteLine($"O preço do gasolina por {litros} litros é: R${custo - desconto4} reais");
                }
            } else {
                Console.WriteLine("ERRO");
            }

            /*
            3)
            
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
            */
        }
    }
}
