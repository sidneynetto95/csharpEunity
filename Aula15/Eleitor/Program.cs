using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            Console.WriteLine("Votação");
            Console.Write("Digite a sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 16) 
            {
                Console.WriteLine("Você não pode votar.");
            } else
            {
                if ((idade > 15 && idade < 18) || idade > 65)
                {
                    Console.WriteLine("Você é um eleitor facultativo");
                } else
                {
                    Console.WriteLine("Seu voto é obrigatório");
                }
            }

            Console.ReadKey();           
        }
    }
}
