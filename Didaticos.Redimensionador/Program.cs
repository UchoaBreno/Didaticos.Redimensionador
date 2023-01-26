using System;
namespace Didaticos.Redimensionador
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Iniciador nosso redimencionador");

			//faz com que o programa rode duas tarefas ao mesmo tempo de maneira com que rode mais rapido
			//No caso, nesse quesito por exemplo, fez com que o for executasse depois do writeline, mesmo o writeline tendo sido executado antes
			//Dito isso, fez os dois ao mesmo tempo

			System.Threading.Thread thread = new System.Threading.Thread(Redimencionar);
			thread.Start();
			//a cima nao foi colocoado-> "(redimencionar()); <- por que eu to so dizendo que estou
			//citando esse abaixo e nao puxando uma nova função ao redimencionar

			Redimencionar();

			Console.WriteLine("Tecle para fechar");
			//terminal aguarda o usuario dar uma ordem
			Console.Read();
		}

		static void Redimencionar()
		{
			for (int i =0; i<10000; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}	