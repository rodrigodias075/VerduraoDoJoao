
using System;
using System.Diagnostics.Eventing.Reader;

namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OLÁ JOÃO, BEM VINDO AO SEU INVENTÁRIO");
            Console.WriteLine();
            Console.WriteLine("QUAL MELANCIA VOCÊ DESEJA ADICIONAR AO SEU INVENTÁRIO?");
            Console.WriteLine("1 - Melancia Comum (R$ 5,50)");
            Console.WriteLine("2 - Melancia Baby (R$ 8,50)");
            int op = int.Parse(Console.ReadLine());
            double preco;
            double totalComum = 0;
            double totalBaby = 0;

            string resposta = "sim";



            do
            {
                if (op == 1)
                {
                    preco = 5.50;
                    totalComum += preco;
                    Console.WriteLine("Melancia Comum: " + preco.ToString());


                }
                else if (op == 2)
                {
                    preco = 8.56;
                    totalBaby += preco;
                    Console.WriteLine("Melancia Baby: " + preco.ToString());
                }
                else
                {
                    Console.WriteLine("Não existe essa opção!");
                }

                Console.WriteLine("Deseja adicionar outra? (digite 'sim' ou 'não')");
                resposta = Console.ReadLine();


            } while (resposta.ToLower() != "não");

            if (resposta.ToLower() == "não")



                Console.WriteLine("Valor Total de Melancia Comum --- R$ " + totalComum.ToString());
            Console.WriteLine("Valor Total de Melancia Baby --- R$ " + totalBaby.ToString());


            ////int cont = 1;
            ///
            ////while (cont < 10)
            ////{
            ////    Console.WriteLine("Você entendeu?");
            ////    if (cont == 3)
            ////        break;
            ////    cont = cont + 1;
            ////}

            Console.ReadKey();

        }
    }
}
