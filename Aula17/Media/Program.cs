using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double num = 0; //num informado do user
            Double media = 0; //media dos num informados
            Double total = 0; //soma dos num informados
            int tl = 0; //quantidade de num informados
            int i = 0; //contador do for 

            Console.WriteLine("Programa que calcula a média dos números informados");
            Console.WriteLine("Quantos número deseja informar: ");
            tl = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= tl; i++)
            {
                Console.Write("Informe um número: ");
                num = Convert.ToDouble(Console.ReadLine());
                //total = total + num;
                total += num;
            }
            media = total / tl;
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Média: {0}", media);
            Console.ReadKey();  
        }
    }
}
