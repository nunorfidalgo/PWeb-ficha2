using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2Ex4_1
{
    class Professor : Pessoa
    {
        private String habilitacoes;

        public Professor(string nome, DateTime data_nascimento, string habilitacoes) : base(nome, data_nascimento)
        {
            this.habilitacoes = habilitacoes;
            }


        public override string ToString()
        {
            return "[Professor] " + base.ToString() + $"; Habilitacoes= {habilitacoes}";
            }
    }
}
