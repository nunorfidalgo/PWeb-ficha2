using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2Ex4_1
{
    class Pessoa
    {
        public String nome { get; }
        public DateTime data_nascimento { get; }

        public Pessoa()
        {
            nome = "Desconhecido";
            data_nascimento = DateTime.Now;
            }

        public Pessoa(string nome, DateTime dn)
        {
            this.nome = nome;
            this.data_nascimento = dn;
            }

        public override string ToString()
        {
            return $"Nome = {nome}; Data de Nascimento = {data_nascimento.ToShortDateString()}";
            }

        public void Mostrar()
        {
            Console.WriteLine(ToString());
            }
    }
}
