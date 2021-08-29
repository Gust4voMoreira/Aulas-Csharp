using System;
using System.Collections.Generic;
namespace Desafio
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bem-vindo, Walkiria!\n");
			var nome = "";
			int matricula = 0;
			var resultado = "";
			var opcao = "s";
			List<dynamic> alunos = new List<dynamic>();

			while (opcao.ToLower() == "s")
			{
				Console.WriteLine("Digite nome do aluno: \n");
				nome = Console.ReadLine();
				Console.WriteLine("Digite Matricula do aluno: \n");
				matricula = int.Parse(Console.ReadLine());
				Console.WriteLine("Digite Notas do aluno: \n");
				double[] notas = new double[3];
				double soma = 0;
				double media = 0;

				for (int i = 0; i < 3; i++)
				{
					Console.WriteLine($"{i + 1}ª nota:");
					notas[i] = Convert.ToDouble(Console.ReadLine());
					soma += notas[i];
				}
				media = soma / notas.Length;
				if (media >= 6)
				{
					resultado = "Aprovado";
				}
				else
				{
					resultado = "Reprovado";
				}
				alunos.Add(new
				{
					Nome = nome,
					Matricula = matricula,
					Notas = notas,
					Media = media,
					Situacao = resultado
				});
				Console.Clear();
				Console.WriteLine("Deseja cadastrar um novo aluno? S ou N: \n");
				opcao = Console.ReadLine();
			}
			Console.Clear();
			foreach(var aluno in alunos)
			{
				Console.WriteLine($"--------------------------------------");
				Console.WriteLine($"Nome: {aluno.Nome} - Matricula : {aluno.Matricula}");
				Console.WriteLine($"--------------------------------------");
				Console.WriteLine($"Notas: ");
				int n = 1;
				foreach (double nota in aluno.Notas)
				{
					Console.WriteLine($"{n}ª Nota :{nota}");
					n += 1;
				}
				Console.WriteLine($"Média: {Math.Round(aluno.Media,2)} - Situação: {aluno.Situacao}");
				Console.WriteLine($"--------------------------------------");
			}
		}
	}
}