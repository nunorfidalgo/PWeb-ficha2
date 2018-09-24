using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f2ex4_1
{
    class Professor : Pessoa
    {
        private string habilitacoes;

        public Professor(string nome, DateTime data_nascimento, string nhabilitacoesaluno) : base(nome, data_nascimento)
        {
            this.habilitacoes = habilitacoes;
        }

        public override string ToString()
        {
            return $"Professor = {base.ToString()}; Habilitações = {habilitacoes}";
        }
    }
}
