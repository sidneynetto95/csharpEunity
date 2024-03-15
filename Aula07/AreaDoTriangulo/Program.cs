using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0; //Área
            double b = 0; //Base
            double h = 0; //Altura
            string entrada = "";

            Console.WriteLine("Cálculo da Área de um triângulo");

            Console.Write("Digite a Base do Triângulo: ");
            entrada = Console.ReadLine();
            b = Convert.ToDouble(entrada);

            Console.Write("Digite a Altura do Triângulo: ");
            entrada = Console.ReadLine();
            h = Convert.ToDouble(entrada);

            a = (b * h ) / 2 ;

            Console.Write("O cálculo de {0} x {1} / 2 é igual a: {2}", b, h, a);

            Console.ReadKey();
            
        }
    }
}
