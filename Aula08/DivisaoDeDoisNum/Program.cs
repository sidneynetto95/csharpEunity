using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisaoDeDoisNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0;//Dividendo
            double n2 = 0;//Divisor
            double r = 0; //Resto da Divisão
            double q = 0; //Consciente da Divisão

            Console.WriteLine("Programa que efetua divisão de dois números");
            Console.Write("Informe o dividendo: ") ;
            n1 = Convert.ToDouble(Console.ReadLine()) ;

            Console.Write("Informe o divisor: ") ;
            n2 = Convert.ToDouble(Console.ReadLine()) ;

            q = n1 / n2;
            r = n1 % n2;



            Console.WriteLine("Resposta da divisão") ;
            Console.WriteLine("{0} / {1} = {2}", n1, n2 ,q) ;
            Console.WriteLine("Resto {0}", r);

            Console.ReadKey();
        }
    }
}
