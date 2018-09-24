using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2Ex4_1
{
    class ControladorDados
    {

        public static string LerTexto(string texto)
        {
            string nome = string.Empty;

            do
            {   Console.Write(texto);
                nome = Console.ReadLine();
                }
            while (String.IsNullOrWhiteSpace(nome) || String.IsNullOrEmpty(nome));

            return nome;
            }


        public static int LerNumero(string texto, int min, int max)
        {
            bool valido = false;
            int num;

            do
            {
                Console.Write(texto);
                if (int.TryParse(Console.ReadLine(), out num))
                    if (num >= min && num <= max) valido = true;
                }
                while (!valido);

            return num;
            }


        public static DateTime LerData(string data_min= null)
        {
            DateTime dt= DateTime.Now;

            do { Console.Write("Introduza a Data Nascimento (dd/mm/aaaa) "); }
            while (!DateTime.TryParseExact(Console.ReadLine(), "d/M/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out dt));

            return dt;
            }

    }
}
