using System;
using System.Collections;
using System.Collections.Generic;

namespace resolução_prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			// TODO Auto-generated method stub
			Pessoa p1 = new Pessoa("João", 15);
			Pessoa p2 = new Pessoa("Leandro", 21);
			Pessoa p3 = new Pessoa("Paulo", 17);
			Pessoa p4 = new Pessoa("Jessica", 18);

			List<Pessoa> pessoas = new List<Pessoa>();
			pessoas.Add(p1);
			pessoas.Add(p2);
			pessoas.Add(p3);
			pessoas.Add(p4);

			// imprime o nome de todos 
			foreach (Pessoa pessoa in pessoas)
			{
				Console.WriteLine("Nome: " + pessoa.Nome + "  Idade: " + pessoa.Idade);
			}
			// imprime o nome do mais velho
			int maior = 0;
			String nomeMaior = "", nomeMenor = "";
			foreach (Pessoa pessoa in pessoas)
			{
				if (pessoa.Idade > maior)
				{
					maior = pessoa.Idade;
					nomeMaior = pessoa.Nome;
				}

			}
			Console.WriteLine("A pessoa mais velha é " + nomeMaior + " " + maior);
			int menor = maior;
			//imprime o nome do menor
			foreach (Pessoa pessoa in pessoas)
			{
				if (pessoa.Idade < menor)
				{
					menor = pessoa.Idade;
					nomeMenor = pessoa.Nome;
				}
				;
			}
			Console.WriteLine(" A pessoa mais nova é " + nomeMenor + " " + menor);

			// removendo o mais novo
			Console.WriteLine("impressão antes de removido");
			for (int i = 0; i < pessoas.Count; i++)
			{
				Console.WriteLine(pessoas[i].Nome + "");
			}

			for (int i = 0; i < pessoas.Count; i++)
			{
				Pessoa p = pessoas[i];

				if (p.Idade < 18)
				{
					pessoas.RemoveAt(i);
				}

			}
			Console.WriteLine("impressão depois de removido");
			for (int i = 0; i < pessoas.Count; i++)
			{
				Console.WriteLine(pessoas[i].Nome + "");
			}

			//	exibindo o nome de jessica
			foreach (Pessoa pessoa in pessoas)
			{
				if (pessoa.Nome == "Jessica")
				{
					Console.WriteLine(pessoa.Nome + " " + pessoa.Idade);
				}

			}
		}
    }
}
