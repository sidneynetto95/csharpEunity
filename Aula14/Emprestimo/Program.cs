using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean empregado = false;
            Boolean fiador = false;
            String entrada = "";

            Console.WriteLine("Empréstimo...");
            Console.WriteLine("Possui fiador (S/N): ");
            entrada = Console.ReadLine();

            if ((entrada == "S") || (entrada == "s"))
            {
                fiador = true;
            }

            Console.WriteLine("Está Empregado (S/N): ");
            
            entrada = Console.ReadLine();

            if ((entrada == "S") || (entrada == "s"))
            {
                empregado = true;
            }

            if ((empregado==true) || (fiador== true))
            {
                Console.WriteLine("Empréstimo Aprovado");
            }
            else
            {
                Console.WriteLine("Empréstimo Recusado");
            }
            Console.ReadKey();
        }
    }
}
