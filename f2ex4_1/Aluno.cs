using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2Ex4_1
{
    class Aluno : Pessoa
    {
        private int nAluno;

        public Aluno(string nome, DateTime data_nascimento, int naluno) : base(nome, data_nascimento)
        {
            nAluno = naluno;
            }


        public override string ToString()
        {
            return $"[Aluno] {base.ToString()}; Nº Aluno= {nAluno}";
            }
    }
}
