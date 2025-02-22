using System;
using ProjetoPOO.Generics;
using ProjetoPOO.Models;

namespace ProjetoPOO.Models
{
    class MenuFuncionario
    {
        public static void ShowMenuFuncionarios()
        {
            Console.Clear();
            Console.WriteLine("==== MENU DE FUNCIONARIOS =====");
            Console.WriteLine("|                              |");
            Console.WriteLine("|  1. Opções do Cliente        |");
            Console.WriteLine("|  2. Opções de Agendamento    |");
            Console.WriteLine("|  3. Opções do Pet            |");
            Console.WriteLine("|                              |");
            Console.WriteLine("================================");
            Console.WriteLine(); // Pular linha

            Console.Write("Digite a sua escolha: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: OpcoesCliente(); break;
                case 2: OpcoesAgendamento(); break;
                case 3: OpcoesPet(); break;

                default: 
                    Console.WriteLine("Opção Inválida, aperte qualquer teclha para tentar novamente.");
                    Console.ReadLine();
                    ShowMenuFuncionarios();
                    break;
            }
        }

        public static void OpcoesCliente()
        {
            Console.Clear();

            Console.WriteLine("====== Opções do Cliente ======");
            Console.WriteLine("|                              |");
            Console.WriteLine("|  1. Listar Cliente           |");
            Console.WriteLine("|  2. Listar Por ID            |");
            Console.WriteLine("|  0. Voltar                   |");
            Console.WriteLine("|                              |");
            Console.WriteLine("================================");
            Console.WriteLine(); // Pular linha

            Console.Write("Digite a sua escolha: ");
            int escolha = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (escolha)
            {
                case 0:
                    ShowMenuFuncionarios();
                    break;
                
                case 1: // Listar todos os clientes
                    var clientes = View.ListarEntidade<Cliente>(); // Obtém a lista de clientes

                    if (clientes.Any()) // Verifica se há clientes na lista
                    {
                        Console.WriteLine("Lista de Clientes:");
                        foreach (var cliente in clientes)
                        {
                            Console.WriteLine($"ID: {cliente.Id} | Nome: {cliente.Nome} | Telefone: {cliente.Telefone} | Endereço: {cliente.Endereco}");
                        }
                    } else { Console.WriteLine("Nenhum cliente encontrado."); }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadLine();
                    OpcoesCliente();
                    break;

                case 2: // Listar cliente por ID
                    Console.Write("Digite o Id do Cliente: ");
                    int id_2 = int.Parse(Console.ReadLine());

                    var clienteEncontrado = View.ListarEntidade<Cliente>().FirstOrDefault(c => c.Id == id_2);

                    if (clienteEncontrado != null)
                    {
                        Console.WriteLine($"ID: {clienteEncontrado.Id} | Nome: {clienteEncontrado.Nome} | Telefone: {clienteEncontrado.Telefone} | Endereço: {clienteEncontrado.Endereco}");
                    }
                    else
                    {
                        Console.WriteLine("Cliente não encontrado.");
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesCliente();
                    break;

                case 5: 
                    Console.Write("Id: ");
                    int id_atualizar = int.Parse(Console.ReadLine());

                    Console.Write("Nome: ");
                    string nome_atualizar = Console.ReadLine();

                    Console.Write("Email: ");
                    string email_atualizar = Console.ReadLine();

                    Console.Write("Senha: ");
                    string senha_atualizar = Console.ReadLine();

                    Console.Write("Telefone: ");
                    string telefone_atualizar = Console.ReadLine();

                    Console.Write("Endereço: ");
                    string endereco_atualizar = Console.ReadLine();

                    Cliente obj_atualizar = new Cliente(id_atualizar, nome_atualizar, email_atualizar, senha_atualizar, 1, telefone_atualizar, endereco_atualizar);
                    View.AtualizarEntidade<Cliente>(obj_atualizar); 
                    break;
                default: 
                    Console.WriteLine("Opção Inválida, aperte qualquer teclha para tentar novamente.");
                    Console.ReadLine();
                    OpcoesCliente();
                    break;
            }
        }
        public static void OpcoesAgendamento()
        {
            Console.Clear();

            Console.WriteLine("====== Opções de Agendamento ======");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|  1. Listar Agendamentos         |");
            Console.WriteLine("|  2. Listar Por ID do Cliente    |");
            Console.WriteLine("|  0. Voltar                      |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("==================================");
            Console.WriteLine(); // Pular linha

            Console.Write("Digite a sua escolha: ");
            int escolha = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (escolha)
            {
                case 0:
                    ShowMenuFuncionarios();
                    break;

                case 1:
                    var agendamentos = View.ListarEntidade<Agendamento>(); // Obtém a lista de agendamentos

                    if (agendamentos.Any()) // Verifica se há agendamentos na lista
                    {
                        Console.WriteLine("Lista de Agendamentos:");
                        foreach (var agendamento in agendamentos)
                        {
                            Console.WriteLine($"ID: {agendamento.Id} | Cliente: {agendamento.IdCliente} | Pet: {agendamento.IdPet} | Serviço: {agendamento.IdServico} | Data: {agendamento.Data}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum agendamento encontrado.");
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesAgendamento();
                    break;

                case 2:
                    Console.Write("Digite o Id do Cliente: ");
                    int id = int.Parse(Console.ReadLine());

                    var listaAgendamentos = View.ListarEntidade<Agendamento>(); // Retorna uma lista do tipo Agendamento

                    var agendamentosFiltrados = listaAgendamentos.Where(a => a.IdCliente == id).ToList();

                    if (agendamentosFiltrados.Count > 0)
                    {
                        Console.WriteLine($"Agendamentos do Cliente {id}:");
                        foreach (var agendamento in agendamentosFiltrados)
                        {
                            Console.WriteLine($"ID: {agendamento.Id} | Pet: {agendamento.IdPet} | Serviço: {agendamento.IdServico} | Data: {agendamento.Data}");
                        }
                    } else { Console.WriteLine("Nenhum agendamento encontrado para este cliente."); }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesAgendamento();
                    break;

                default:
                    Console.WriteLine("Opção Inválida, aperte qualquer tecla para tentar novamente.");
                    Console.ReadLine();
                    OpcoesAgendamento();
                    break;
            }
        }
        public static void OpcoesPet()
        {
            Console.Clear();

            Console.WriteLine("====== Opções de Pet ======");
            Console.WriteLine("|                          |");
            Console.WriteLine("|  1. Listar Pets          |");
            Console.WriteLine("|  2. Listar Por ID        |");
            Console.WriteLine("|  0. Voltar               |");
            Console.WriteLine("|                          |");
            Console.WriteLine("==========================");
            Console.WriteLine(); // Pular linha

            Console.Write("Digite a sua escolha: ");
            int escolha = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (escolha)
            {
                case 0:
                    ShowMenuFuncionarios();
                    break;

                case 1:
                    var pets = View.ListarEntidade<Pet>(); // Obtém a lista de pets

                    if (pets.Any()) // Verifica se há pets na lista
                    {
                        Console.WriteLine("Lista de Pets:");
                        foreach (var pet in pets)
                        {
                            Console.WriteLine($"ID: {pet.Id} | Nome: {pet.Nome} | Espécie: {pet.Especie} | Raça: {pet.Raca} | Cliente: {pet.IdCliente}");
                        }
                    } else { Console.WriteLine("Nenhum pet encontrado."); }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesPet();
                    break;

                case 2:
                    Console.Write("Digite o Id do Pet: ");
                    int id = int.Parse(Console.ReadLine());

                    var listaPets = View.ListarEntidade<Pet>();

                    var petsFiltrados = listaPets.Where(p => p.Id == id).ToList();

                    if (petsFiltrados.Count > 0)
                    {
                        Console.WriteLine($"Dados do Pet {id}:");
                        foreach (var pet in petsFiltrados)
                        {
                            Console.WriteLine($"ID: {pet.Id} | Nome: {pet.Nome} | Espécie: {pet.Especie} | Raça: {pet.Raca} | Cliente: {pet.IdCliente}");
                        }
                    } else { Console.WriteLine("Nenhum pet encontrado com este ID."); }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesPet();
                    break;

                default:
                    Console.WriteLine("Opção Inválida, aperte qualquer tecla para tentar novamente.");
                    Console.ReadLine();
                    OpcoesPet();
                    break;
            }
        }
    }
}