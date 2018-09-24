using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f2ex4_1
{
    class Pessoa
    {
        public string nome { get; }
        public DateTime data_nascimento { get; }

        public Pessoa()
        {
            nome = "Descohecido";
            this.data_nascimento = DateTime.Now;
        }

        public Pessoa(string nome, DateTime dn)
        {
            this.nome = nome;
            this.data_nascimento = dn;
        }

        public override string ToString()
        {
            return $"Nome = {nome}; Data nascimento = {data_nascimento.ToShortDateString()}";
            //base.ToString();
        }

        public void Mostrara()
        {
            Console.WriteLine(ToString());
        }
    }
}
