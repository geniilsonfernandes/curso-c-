using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores.models
{
    public class Pessoa
    {

        public Pessoa()
        {
            
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }


        // proteger os atributos

        private string _nome;
        private int _idade;
        public string Nome
        {
            // isso é um body expressions
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        public int Idade
        {
            get => _idade; set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa");
                }

                _idade = value;
            }
        }



        public void Aprensetar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}