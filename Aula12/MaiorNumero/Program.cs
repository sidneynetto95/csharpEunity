using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            int maiorNumero = 0;
            string numero = "O 1º valor:";

            Console.WriteLine("Programa que determina o maior número");
            Console.Write("Informe o 1º número: ");
            n = Convert.ToInt32(Console.ReadLine());

            maiorNumero = n;
            Console.Write("Informe o 2º número: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > maiorNumero)
            {
                maiorNumero = n;
                numero = "O 2º valor:";
            }

            Console.Write("Informe o 3º número: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > maiorNumero)
            {
                maiorNumero = n;
                numero = "O 3º valor:";
            }

            Console.WriteLine("{0} {1} é o maior número",numero ,maiorNumero);
            Console.ReadKey();

        }
    }
}
