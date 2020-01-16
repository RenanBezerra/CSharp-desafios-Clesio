using System;
using System.Collections.Generic;
using System.Text;

namespace resolução_prova_ex04
{
    class Gerente :Funcionario
    {
		public Gerente(): base()
		{
			

		}

		public Gerente(String nome, int idade, double salario) : base(nome, idade, salario)
		{
			

		}

		public void bonificação(double sal)
		{
			base.bonificação(sal);
			Salario += 10000.0;

		}

		
		public void status()
		{
			base.status();
			Console.WriteLine("Gerente");
		}
	}
}
