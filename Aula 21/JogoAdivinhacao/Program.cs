using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array de dicas
            string[] perguntas =
            {
                "O que tem capa mas não voa.",//0
                "Sem sair do seu cantinho é capaz de viajar ao redor do mundo.",//1
                "É alta quando jovem e baixinha quando fica velha."//2
            };
            //array de respostas
            string[] respostas =
            {
                "Livro",
                "Selo",
                "Vela"
            };

            string jogar = "s"; //controla a repetição do programa
            string resposta = ""; //armazena a leitura da resposta do user
            int index = 0;

            while (jogar == "s")
            {
                //escolher a pergunta
                Random rand = new Random();
                index = rand.Next(0,respostas.Length); //dentro da faixa de valores do array 'respostas'
                Console.WriteLine("Pergunta: {0}", perguntas[index]);
                Console.Write("Resposta: ");
                resposta = Console.ReadLine();
                if(resposta.ToUpper() != respostas[index].ToUpper())
                {
                    Console.WriteLine("Que pena!! Você errour!!");
                } else
                {
                    Console.WriteLine("Parabéns, você acertou!!!");
                }
                Console.WriteLine("Deseja jogar novamente? s/n:");
                 jogar = Console.ReadLine();
            }
        }
    }
}
