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
            string name = "";
            string nameApp = "Tabuada";
            string numEntrada1 = "";
            int num1 = 0;
            

            Console.WriteLine("{0}",nameApp);
            Console.Write("Digite seu nome:");
            name = Console.ReadLine();
            Console.WriteLine("{0}, Escolha um número para ver a sua tabuada completa.",name);
            Console.Write("Digite um número:");
            numEntrada1 = Console.ReadLine();
            num1 = Convert.ToInt32(numEntrada1);
            Console.WriteLine("Tabuada de {0}:",num1);
            Console.WriteLine("{0} x 1 = {1}", num1, (num1 * 1));
            Console.WriteLine("{0} x 2 = {1}", num1, (num1 * 2));
            Console.WriteLine("{0} x 3 = {1}", num1, (num1 * 3));
            Console.WriteLine("{0} x 4 = {1}", num1, (num1 * 4));
            Console.WriteLine("{0} x 5 = {1}", num1, (num1 * 5));
            Console.WriteLine("{0} x 6 = {1}", num1, (num1 * 6));
            Console.WriteLine("{0} x 7 = {1}", num1, (num1 * 7));
            Console.WriteLine("{0} x 8 = {1}", num1, (num1 * 8));
            Console.WriteLine("{0} x 9 = {1}", num1, (num1 * 9));
            Console.WriteLine("{0} x 10 = {1}", num1, (num1 * 10));



            Console.ReadKey();

        }
    }
}
