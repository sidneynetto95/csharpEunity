using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A < B+C e B < A+C e C < A+B

            int a = 0;
            int b = 0;
            int c = 0;

            Console.WriteLine("Programa que determina se os valores representam os dados de um triângulo");
            Console.Write("Informe o valor de do Lado A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor de do Lado B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor de do Lado C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a < b+c) && (b < a+c) && (c < a+b))
            {
                Console.WriteLine("Os valroes representam os lados de um triângulo");
            }
            else
            {
                Console.WriteLine("Os valores não representam os lados de um triângulo");
            }
            Console.ReadKey();
        }
    }
}
