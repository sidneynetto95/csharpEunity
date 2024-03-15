using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int d = 0; //Dia do nascimento
            int m = 0; //mês do nascimento
            int b = 0; //Ano de nascimento
            var n = DateTime.Now;
            

            Console.WriteLine("Cálculo da sua idade com bane no ano de nascimento");
            Console.Write("Digite o dia do seu nascimento: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o mês do seu nascimento: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o ano do seu nascimento: ");
            b = Convert.ToInt32(Console.ReadLine());

            //validar a data de nascimento
            var date = new DateTime(b, m, d); //Data do nascimento
            var idade = n.Year - date.Year;

            Console.WriteLine("Data Atual:{0}", n);
            Console.WriteLine("Data do seu nascimento: {0}", date);
            if (date.Year < n.Year)
            {
                if (date.Month > n.Month)
                {
                    idade = idade - 1;
                }



                if (date.Month == n.Month)
                {
                    if (date.Day > n.Day)
                    {
                        idade = idade - 1;
                    }
                }
                var formatada = string.Format("{0:d}", idade);
                Console.WriteLine("Sua idade: {0}", formatada);
                
            }

            else
            {
                Console.WriteLine("Data de nascimento inválida, feche e execute o programa novamente.");
            }
            Console.ReadKey();
        }
    }
}
