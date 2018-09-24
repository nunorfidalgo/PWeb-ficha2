using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2Ex4_1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Pessoa> pessoas = ControladorPessoas.InserirListaPessoas();

            Console.WriteLine("\n---PESSOAS---");
            ControladorPessoas.Mostrar(pessoas);

            Console.WriteLine("\n ---FIM ---");
            Console.ReadKey();
            }
    }
}
