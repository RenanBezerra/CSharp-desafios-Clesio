using System;

namespace resolução_prova_ex04
{
    class Program
    {
        static void Main(string[] args)
        {
			Gerente g1 = new Gerente("Pedro", 20, 0);
			Supervisor s1 = new Supervisor("Renan", 29, 0);
			Vendedor v1 = new Vendedor("carol", 26, 0);

			g1.status();
			s1.status();
			v1.status();



			g1.bonificação(2000);
			s1.bonificação(1000);
			v1.bonificação(500);

			g1.status();
			s1.status();
			v1.status();


		}
	}
}
