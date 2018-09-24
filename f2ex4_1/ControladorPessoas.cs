using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2Ex4_1
{
    class ControladorPessoas
    {

        public static void Mostrar(List<Pessoa> pessoas)
        {
            foreach (Pessoa p in pessoas) p.Mostrar();
            }


        public static List<Pessoa> InserirListaPessoas()
        {
            string nome, grau;
            int numero_aluno;
            DateTime data_nascimento;

            Boolean continuar = true;
            List<Pessoa> pessoas = new List<Pessoa>();

            do
            {
                int op = ControladorDados.LerNumero("Aluno (1) / Docente (2) / Sair (0) ", 0, 2);
                switch (op)
                {
                    case 1:
                        nome = ControladorDados.LerTexto("Introduza o Nome ");
                        data_nascimento = ControladorDados.LerData();
                        numero_aluno = ControladorDados.LerNumero("Numero de Aluno [1..200] ", 1, 200);

                        Aluno aluno = new Aluno(nome, data_nascimento, numero_aluno);
                        pessoas.Add(aluno);
                        break;
                    case 2:
                        nome = ControladorDados.LerTexto("Introduza o Nome ");
                        data_nascimento = ControladorDados.LerData();
                        grau = ControladorDados.LerTexto("Grau de Ensino ");

                        Professor docente = new Professor(nome, data_nascimento, grau);
                        pessoas.Add(docente);
                        break;
                    case 0:
                        continuar = false;
                        break;
                    }

                } while (continuar) ;

            return pessoas;

            }


    }
}
