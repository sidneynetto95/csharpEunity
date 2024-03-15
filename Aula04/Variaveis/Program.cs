using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //tipo nome valor
            string texto;
            //atribuir valor a variavel
            texto = "Variável";

            Console.WriteLine(texto);

            texto = "Sidney Neto";

            Console.WriteLine(texto);
            */

            int n1 = 2;
            int n2 = 4;

            Console.WriteLine(n1 + " > " + n2 + " = " + (n1 > n2));
            Console.WriteLine(n1 + " < " + n2 + " = " + (n1 < n2));
            Console.WriteLine(n1 + " != " + n2 + " = " + (n1 != n2));
            Console.WriteLine(n1 + " == " + n2 + " = " + (n1 == n2));
            Console.ReadKey();
        }
    }
}
