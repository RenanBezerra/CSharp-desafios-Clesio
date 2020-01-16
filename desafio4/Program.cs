﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace desafio4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
			Livro l1 = new Livro("Harry poter", 40, 50, "j.K.Rowling", "fantasia", 300);
			Livro l2 = new Livro("Senhor dos aneis ", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
			Livro l3 = new Livro("Java Poo", 20, 50, "GFT", "educativo", 500);

			VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
			VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
			VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

			List<Livro> livros = new List<Livro>();
			
			livros.Add(l1);
			livros.Add(l2);
			livros.Add(l3);

			List<VideoGame> games = new List<VideoGame>();
			games.Add(ps4);
			games.Add(ps4Usado);
			games.Add(xbox);

			Loja americanas = new Loja("Americanas", "123456", livros, games);

			l2.calculaImposto();
			l3.calculaImposto();
			ps4Usado.calculaImposto();
			ps4.calculaImposto();
			ps4Usado.calculaImposto();
			Console.WriteLine("ps4 teste return  " + ps4.calculaImposto());

			americanas.listaLivros();
			americanas.listaVideoGames();
			americanas.calculaPatrimonio();
		}
    }
}
