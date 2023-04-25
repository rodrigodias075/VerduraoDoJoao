using System;
using System.Collections.Generic;

namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria usuário e senha
            string usuario = "joao";
            string senha = "joao123";

            int tentativas = 0;

            while (tentativas < 3)
            {
                Console.WriteLine("SEJA BEM VINDO, SE IDENTIFIQUE POR FAVOR");
                Console.WriteLine("Usuário:");
                string usuarioInput = Console.ReadLine();
                Console.WriteLine("Senha:");
                string senhaInput = Console.ReadLine();

                if (usuarioInput == usuario && senhaInput == senha)
                {
                    //Identificação
                    Console.WriteLine("OLÁ JOÃO, BEM VINDO AO SEU INVENTÁRIO");
                    Console.WriteLine();
                    int opcao;

                    //Data de hoje

                    {

                        do
                        {
                            Console.WriteLine("O QUE VOCÊ GOSTARIA DE FAZER HOJE?");
                            Console.WriteLine();
                            Console.WriteLine("1- Cadastrar um Caminhão");
                            Console.WriteLine("2- Adicionar Produto");
                            Console.WriteLine("3- Sair");
                            Console.Write("Digite a opção desejada: ");

                            // opção escolhida pelo usuário
                            string entrada = Console.ReadLine();

                            // busca se é válida
                            if (int.TryParse(entrada, out opcao))
                            {
                                // Opção que o usuario escolheu
                                switch (opcao)
                                {
                                    case 1:
                                        Console.WriteLine("Opção 1 selecionada - Registro do Caminhão");
                                        Console.Write("Digite a placa do caminhão: ");
                                        string placa = Console.ReadLine();
                                        Console.WriteLine("Placa cadastrada: " + placa);
                                        break;
                                    case 2:

                                        // Valor inicial de melancia
                                        double total = 0;
                                        double desconto = 0;

                                        Console.WriteLine("Insira o dia da semana atual:");
                                        Console.WriteLine("1 - Segunda-feira");
                                        Console.WriteLine("2 - Terça-feira");
                                        Console.WriteLine("3 - Quarta-feira");
                                        Console.WriteLine("4 - Quinta-feira");
                                        Console.WriteLine("5 - Sexta-feira");
                                        Console.WriteLine("6 - Sábado");
                                        Console.WriteLine("7 - Domingo");
                                        int diaSemana = int.Parse(Console.ReadLine());

                                        int qtdMelanciaComum = 0;
                                        int qtdMelanciaBaby = 0;
                                        List<string> carrinho = new List<string>();

                                        do
                                        {
 
                                            Console.WriteLine("QUAL MELANCIA VOCÊ DESEJA ADICIONAR AO SEU INVENTÁRIO?");
                                            Console.WriteLine("1 - Melancia Comum (R$ 5,50)");
                                            Console.WriteLine("2 - Melancia Baby (R$ 8,50)");
                                            Console.WriteLine("3 - Finalizar");


                                            int melancia = int.Parse(Console.ReadLine());

                                            // Olha quantas melancia adicionou e acrescenta no valor final
                                            switch (melancia)
                                            {
                                                case 1:
                                                    total += 5.50;
                                                    carrinho.Add("Melancia Comum");
                                                    qtdMelanciaComum++;
                                                    Console.WriteLine("Melancia Comum adicionada ao carrinho.");
                                                    break;
                                                case 2:
                                                    total += 8.50;
                                                    carrinho.Add("Melancia Baby");
                                                    qtdMelanciaBaby++;
                                                    Console.WriteLine("Melancia Baby adicionada ao carrinho.");
                                                    break;
                                                case 3:

                                                    Console.WriteLine("Quantidade de melancias COMUNS no carrinho: " + qtdMelanciaComum);
                                                    Console.WriteLine("Quantidade de melancias BABY no carrinho: " + qtdMelanciaBaby);
                                                    Console.WriteLine("Valor total do carrinho: R$ " + total);
                                                    break;
                                                default:
                                                    Console.WriteLine("Opção inválida.");
                                                    break;
                                            }
                                            // Busca o dia e aplica desconto
                                            switch (diaSemana)
                                            {
                                                case 1: // Segunda-feira
                                                    Console.WriteLine("Parabéns! Você ganhou 1% de Desconto Hoje :)");
                                                    desconto = total * 0.01;
                                                    break;

                                                case 2: // Terça-feira
                                                    Console.WriteLine("Parabéns! Você ganhou 15% de Desconto Hoje :)");
                                                    desconto = total * 0.15;

                                                    break;
                                                case 3: // Quarta-feira
                                                    Console.WriteLine("Parabéns! Você ganhou 17% de Desconto Hoje :)");
                                                    desconto = total * 0.17;
                                                    break;
                                                case 4: // Quinta-feira
                                                    Console.WriteLine("Parabéns! Você ganhou 2% de Desconto Hoje :)");
                                                    desconto = total * 0.02;
                                                    break;
                                                case 5: // Sexta-feira
                                                    Console.WriteLine("Parabéns! Você ganhou 3% de Desconto Hoje :)");
                                                    desconto = total * 0.03;
                                                    break;
                                                case 6: // Sábado
                                                    Console.WriteLine("Não tem desconto hoje :(");
                                                    break;
                                                case 7: // Domingo
                                                    Console.WriteLine("Não tem desconto hoje :(");
                                                    break;
                                                default:
                                                    break;
                                            }


                                            // Se ainda quer mais melancia
                                            Console.WriteLine("Deseja adicionar mais melancias? (s/n)");
                                        } while (Console.ReadLine().ToLower() == "s");

                                        // Valor Total
                                        total -= desconto;
                                        Console.WriteLine("Valor total do carrinho: R$ " + total );
                                        break;
                                    case 3:
                                        Console.WriteLine("Encerrando programa...");
                                        break;
                                    default:
                                        Console.WriteLine("Opção inválida. Digite uma opção válida.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida. Digite uma opção válida.");
                            }

                            Console.WriteLine();
                        } while (opcao != 3);

                        Console.ReadKey();

                        // Se o usuário estiver certo, ele irá parar de pedir login
                        break;
                    }
                }




                else
                {
                    Console.WriteLine("Usuário ou senha inválidos. Tente novamente.");
                    tentativas++;
                }




                            if (tentativas >= 3)
                            {
                                Console.WriteLine("Número máximo de tentativas excedido. Encerrando programa.");
                                Console.ReadKey();
                            }

                        };
                    }
                }
            }
        
    










        