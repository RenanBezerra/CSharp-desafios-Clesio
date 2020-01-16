using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace resolução_prova
{
    class Pessoa
    {
        //atributos
        //private String nome;
        //private int idade;

        //atributos getters e setters
        public String Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            
        }

        public Pessoa()
        {
        }
    }
}
