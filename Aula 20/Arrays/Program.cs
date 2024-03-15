using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] nomes = { "Danilo", "Livia", "Alice" };
            string[] Lista = new string[5];
            string nome = "";

            Console.WriteLine("Lista de 5 nomes");
            for (int i = 0; i < 5; i++) 
            {
                Console.Write("Informe um nome: ");
                Lista[i] = Console.ReadLine();
            }
            Console.Write("Nomes: ");
            for (int i = 0;i < 5;i++)
            {
                Console.Write(Lista[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}
