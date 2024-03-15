using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int count = 0;
            int i = 0;

            Console.WriteLine("Núemero Primo");
            Console.Write("informe um número...");
            num = Convert.ToInt32(Console.ReadLine());

            count = 0;
            i = 1;
            while (i <= num)
            {
                if(num%i == 0)
                {
                    count++;
                }
                i++;
            }
            if(count == 2)
            {
                Console.WriteLine("O valor informado é um número primo");
            }
            else
            {
                Console.WriteLine("O valor informado não é um número primo");
            }
            Console.ReadKey();
        }
    }
}
