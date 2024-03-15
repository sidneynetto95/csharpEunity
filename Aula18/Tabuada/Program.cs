using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 0;
            while (i<10) 
            {
                Console.WriteLine("Eu amo o While!!");
                i++;
            }
            Console.ReadKey();
            */
            int i = 0;
            int n = 0;

            Console.WriteLine("Tabuada de um número");
            Console.Write("Informe um Número: ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 1;

            while (i <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));
                i++;
            }

            Console.ReadKey();
            
        }
    }
}
