using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int r = 0; //resto 

            Console.WriteLine("Verificador de Par ou Impar");
            Console.Write("Informe um número: ");
            n = Convert.ToInt32(Console.ReadLine());

            r = n % 2;

            if (r != 0) {
            Console.WriteLine("{0} é um número impar", n);
            } else
            {
                Console.WriteLine("{0} é um número par", n);
            }

            Console.ReadKey();
        }
    }
}
