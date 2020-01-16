using System;
using System.Collections.Generic;
using System.Text;

namespace resolução_prova_ex04
{
    public abstract class Funcionario
    {
        public String Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, int idade, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }

        protected Funcionario()
        {
        }





        //metodos
        public void bonificação(double sal)
        {
            Salario += sal;
            Console.WriteLine(" o salario é de " + Salario);
        }

        public void status()
        {
            Console.WriteLine(" Nome: " + this.Nome
                    + " Idade: " + this.Idade +
                    " Salario: " + this.Salario);


        }



    }
}
