using System;

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
                            Console.WriteLine("Escolha o dia da semana: ");
                            Console.WriteLine();
                            Console.WriteLine("1- Domingo");
                            Console.WriteLine("2- Segunda-Feira");
                            Console.WriteLine("3- Terça-Feira");
                            Console.WriteLine("4- Quarta-Feira");
                            Console.WriteLine("5- Quinta-Feira");
                            Console.WriteLine("6- Sexta-feira");
                            Console.WriteLine("7- Sábado");
                            Console.Write("Digite a opção desejada: ");

                            // opção escolhida pelo usuário
                            string data = Console.ReadLine();

                            // busca se é válida
                            if (int.TryParse(data, out diaescolhido))
                            {

                                double valorDesconto = 0.0;

                                switch (diaescolhido)
                                {
                                    case "segunda feira":
                                        valorDesconto = 0.01;
                                        Console.WriteLine($"Hoje você tem um desconto de 1% na sua compra!");
                                        break;
                                    case "terça feira":
                                        valorDesconto = 0.15;
                                        Console.WriteLine($"Hoje você tem um desconto de 15% na sua compra!");
                                        break;
                                    case "quarta feira":
                                        valorDesconto = 0.17;
                                        Console.WriteLine($"Hoje você tem um desconto de 17% na sua compra!");
                                        break;
                                    case "quinta-feira":
                                        valorDesconto = 0.02;
                                        Console.WriteLine($"Hoje você tem um desconto de 2% na sua compra!");
                                        break;
                                    case "sexta-feira":
                                        valorDesconto = 0.03;
                                        Console.WriteLine($"Hoje você tem um desconto de 3% na sua compra!");
                                        break;
                                    case "sábado":
                                    case "domingo":
                                        Console.WriteLine("Desculpe, hoje não há descontos disponíveis.");
                                        break;
                                    default:
                                        Console.WriteLine("Dia da semana inválido.");
                                        break;
                                }


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
                                                            Console.WriteLine("Melancia Comum adicionada ao carrinho.");
                                                            break;
                                                        case 2:
                                                            total += 8.50;
                                                            Console.WriteLine("Melancia Baby adicionada ao carrinho.");
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("Valor total do carrinho: R$ " + total * valorDesconto);
                                                            break;

                                                        default:
                                                            Console.WriteLine("Opção inválida.");
                                                            break;
                                                    }

                                                    // Se ainda quer mais melancia
                                                    Console.WriteLine("Deseja adicionar mais melancias? (s/n)");
                                                } while (Console.ReadLine().ToLower() == "s");

                                                // Valor Total
                                                Console.WriteLine("Valor total do carrinho: R$ " + total * valorDesconto);
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
                    }

                    if (tentativas >= 3)
                    {
                        Console.WriteLine("Número máximo de tentativas excedido. Encerrando programa.");
                        Console.ReadKey();
                    }
                }
            }
        }