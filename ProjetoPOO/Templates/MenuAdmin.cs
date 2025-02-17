using System;
using ProjetoPOO.Generics;
using ProjetoPOO.Models;

namespace ProjetoPOO.Templates
{
    class MenuAdmin
    {
        public static void ShowMenuAdmin()
        {
            Console.Clear();
            Console.WriteLine("========== MENU ADMIN ==========");
            Console.WriteLine("|                              |");
            Console.WriteLine("|  1. Opções do Admin          |");
            Console.WriteLine("|  2. Opções do Cliente        |");
            Console.WriteLine("|  3. Opções do Funcionario    |");
            Console.WriteLine("|  4. Opções de Pagamento      |");
            Console.WriteLine("|  5. Opções de Agendamento    |");
            Console.WriteLine("|  6. Opções do Pet            |");
            Console.WriteLine("|  7. Opções de Servico        |");
            Console.WriteLine("|  0. Sair                     |");
            Console.WriteLine("|                              |");
            Console.WriteLine("================================");
            Console.WriteLine(); // Pular linha

            Console.Write("Digite a sua escolha: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: OpcoesAdmin(); break;
                case 2: OpcoesCliente(); break;
                case 3: OpcoesFuncionario(); break;
                case 4: OpcoesPagamento(); break;
                case 5: OpcoesAgendamento(); break;
                case 6: OpcoesPet(); break;
                case 7: OpcoesServico(); break;
                default: 
                    Console.WriteLine("Opção Inválida, aperte qualquer teclha para tentar novamente.");
                    Console.ReadLine();
                    ShowMenuAdmin();
                    break;
            }
        }

        public static void OpcoesAdmin()
        {
            Console.Clear();

            Console.WriteLine("======= Opções do Admin =======");
            Console.WriteLine("|                              |");
            Console.WriteLine("|  1. Inserir Admin            |");
            Console.WriteLine("|  2. Remover Admin            |");
            Console.WriteLine("|  3. Listar Admins            |");
            Console.WriteLine("|  4. Listar Por ID            |");
            Console.WriteLine("|  5. Atualizar Admin          |");
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
                    ShowMenuAdmin();
                    break;
                case 1: 
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Senha: ");
                    string senha = Console.ReadLine();

                    Admin obj = new Admin(0, nome, email, senha, 3);
                    View.InserirEntidade<Admin>(obj); 
                    break;
                case 2: 
                    Console.Write("Digite o Id do admin que deseja excluir: ");
                    int id = int.Parse(Console.ReadLine());
                    View.RemoverEntidade<Admin>(id);
                    break;
                case 3: // Listar todos os administradores
                    var admins = View.ListarEntidade<Admin>(); // Obtém a lista de administradores

                    if (admins.Any()) // Verifica se há administradores na lista
                    {
                        Console.WriteLine("Lista de Administradores:");
                        foreach (var admin in admins)
                        {
                            Console.WriteLine($"{admin.ToString()}");
                        }
                    } else { Console.WriteLine("Nenhum administrador encontrado."); }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadLine();
                    OpcoesAdmin();
                    break;
                case 4: // Listar administrador por ID
                    Console.Write("Digite o Id do Administrador: ");
                    int id_2 = int.Parse(Console.ReadLine());

                    var adminEncontrado = View.ListarEntidade<Admin>().FirstOrDefault(a => a.Id == id_2);

                    if (adminEncontrado != null)
                    {
                        Console.WriteLine($"ID: {adminEncontrado.Id} | Nome: {adminEncontrado.Nome} | Email: {adminEncontrado.Email}");
                    }
                    else
                    {
                        Console.WriteLine("Administrador não encontrado.");
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesAdmin();
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

                    Admin obj_atualizar = new Admin(id_atualizar, nome_atualizar, email_atualizar, senha_atualizar, 3);
                    View.AtualizarEntidade<Admin>(obj_atualizar);
                    break;
                default: 
                    Console.WriteLine("Opção Inválida, aperte qualquer teclha para tentar novamente.");
                    Console.ReadLine();
                    OpcoesAdmin();
                    break;
            }
        }
        public static void OpcoesCliente()
        {
            Console.Clear();

            Console.WriteLine("====== Opções do Cliente ======");
            Console.WriteLine("|                              |");
            Console.WriteLine("|  1. Inserir Cliente          |");
            Console.WriteLine("|  2. Remover Cliente          |");
            Console.WriteLine("|  3. Listar Cliente           |");
            Console.WriteLine("|  4. Listar Por ID            |");
            Console.WriteLine("|  5. Atualizar Cliente        |");
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
                    ShowMenuAdmin();
                    break;
                case 1: 
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Senha: ");
                    string senha = Console.ReadLine();

                    Console.Write("Telefone: ");
                    string telefone = Console.ReadLine();

                    Console.Write("Endereço: ");
                    string endereco = Console.ReadLine();

                    Cliente obj = new Cliente(0, nome, email, senha, 1, telefone, endereco);
                    View.InserirEntidade<Cliente>(obj); 
                    break;
                case 2: 
                    Console.Write("Digite o Id do Cliente: ");
                    int id = int.Parse(Console.ReadLine());
                    View.RemoverEntidade<Cliente>(id);
                    break;
                case 3: // Listar todos os clientes
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

                case 4: // Listar cliente por ID
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
        public static void OpcoesFuncionario()
        {
            Console.Clear();

            Console.WriteLine("====== Opções do Funcionario ======");
            Console.WriteLine("|                              |");
            Console.WriteLine("|  1. Inserir Funcionario      |");
            Console.WriteLine("|  2. Remover Funcionario      |");
            Console.WriteLine("|  3. Listar Funcionario       |");
            Console.WriteLine("|  4. Listar Por ID            |");
            Console.WriteLine("|  5. Atualizar Funcionario    |");
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
                    ShowMenuAdmin();
                    break;

                case 1: 
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Senha: ");
                    string senha = Console.ReadLine();

                    Console.Write("Cargo: ");
                    string cargo = Console.ReadLine();

                    Console.Write("Salário: ");
                    float salario = float.Parse(Console.ReadLine());

                    Funcionario obj = new Funcionario(0, nome, email, senha, 2, cargo, salario);
                    View.InserirEntidade<Funcionario>(obj); 
                    break;
                case 2: 
                    Console.Write("Digite o Id do Funcionario: ");
                    int id = int.Parse(Console.ReadLine());
                    View.RemoverEntidade<Funcionario>(id);
                    break;
                case 3: // Listar todos os funcionários
                    var funcionarios = View.ListarEntidade<Funcionario>(); // Obtém a lista de funcionários

                    if (funcionarios.Any()) // Verifica se há funcionários na lista
                    {
                        Console.WriteLine("Lista de Funcionários:");
                        foreach (var funcionario in funcionarios)
                        {
                            Console.WriteLine($"ID: {funcionario.Id} | Nome: {funcionario.Nome} | Cargo: {funcionario.Cargo} | Salário: {funcionario.Salario}");
                        }
                    } else { Console.WriteLine("Nenhum funcionário encontrado."); }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesFuncionario();
                    break;

                case 4: // Listar funcionário por ID
                    Console.Write("Digite o Id do Funcionário: ");
                    int id_2 = int.Parse(Console.ReadLine());

                    var funcionarioEncontrado = View.ListarEntidade<Funcionario>().FirstOrDefault(f => f.Id == id_2);

                    if (funcionarioEncontrado != null)
                    {
                        Console.WriteLine($"ID: {funcionarioEncontrado.Id} | Nome: {funcionarioEncontrado.Nome} | Cargo: {funcionarioEncontrado.Cargo} | Salário: {funcionarioEncontrado.Salario}");
                    }
                    else
                    {
                        Console.WriteLine("Funcionário não encontrado.");
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesFuncionario();
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

                    Console.Write("Cargo: ");
                    string cargo_atualizar = Console.ReadLine();

                    Console.Write("Salario: ");
                    float salario_atualizar = float.Parse(Console.ReadLine());

                    Funcionario obj_atualizar = new Funcionario(id_atualizar, nome_atualizar, email_atualizar, senha_atualizar, 2, cargo_atualizar, salario_atualizar);
                    View.AtualizarEntidade<Funcionario>(obj_atualizar); 
                    break;
                default: 
                    Console.WriteLine("Opção Inválida, aperte qualquer teclha para tentar novamente.");
                    Console.ReadLine();
                    OpcoesFuncionario();
                    break;
            }
        }
        public static void OpcoesPagamento()
        {
            Console.Clear();

            Console.WriteLine("====== Opções do Pagamento ======");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  1. Listar Pagamento          |");
            Console.WriteLine("|  2. Listar Por ID do Cliente  |");
            Console.WriteLine("|  0. Voltar                    |");
            Console.WriteLine("|                               |");
            Console.WriteLine("================================");
            Console.WriteLine(); // Pular linha

            Console.Write("Digite a sua escolha: ");
            int escolha = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (escolha)
            {
                case 0:
                    ShowMenuAdmin();
                    break;

                case 1:
                    var pagamentos = View.ListarEntidade<Pagamento>(); // Obtém a lista de pagamentos

                    if (pagamentos.Any()) // Verifica se há pagamentos na lista
                    {
                        Console.WriteLine("Lista de Pagamentos:");
                        foreach (var pagamento in pagamentos)
                        {
                            Console.WriteLine($"ID: {pagamento.Id} | Cliente: {pagamento.IdCliente} | Valor: {pagamento.Valor} | Data: {pagamento.DataPagamento}");
                        }
                    } else { Console.WriteLine("Nenhum pagamento encontrado.");}

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesPagamento();
                    break;
                 
                case 2: 
                    Console.Write("Digite o Id do Cliente: ");
                    int id = int.Parse(Console.ReadLine());

                    var objetos = View.ListarEntidade<Pagamento>(); // Retorna uma lista do tipo Pagamento

                    var pagamentosFiltrados = objetos.Where(p => p.IdCliente == id).ToList();

                    if (pagamentosFiltrados.Count > 0)
                    {
                        Console.WriteLine($"Pagamentos do Cliente {id}:");
                        foreach (var pagamento in pagamentosFiltrados)
                        {
                            Console.WriteLine($"ID: {pagamento.Id} | Valor: {pagamento.Valor} | Data: {pagamento.DataPagamento}");
                        }
                    } else { Console.WriteLine("Nenhum pagamento encontrado para este cliente."); }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesPagamento();
                    break;

                default: 
                    Console.WriteLine("Opção Inválida, aperte qualquer teclha para tentar novamente.");
                    Console.ReadLine();
                    OpcoesPagamento();
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
                    ShowMenuAdmin();
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
                    ShowMenuAdmin();
                    break;

                case 1:
                    var pets = View.ListarEntidade<Pet>(); // Obtém a lista de pets

                    if (pets.Any()) // Verifica se há pets na lista
                    {
                        Console.WriteLine("Lista de Pets:");
                        foreach (var pet in pets)
                        {
                            Console.WriteLine($"ID: {pet.Id} | Nome: {pet.Nome} | Espécie: {pet.Especie} | Raça: {pet.Raca}");
                        }
                    } else { Console.WriteLine("Nenhum pet encontrado."); }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesPet();
                    break;

                case 2:
                    Console.Write("Digite o Id do Pet: ");
                    int id = int.Parse(Console.ReadLine());

                    var listaPets = View.ListarEntidade<Pet>(); // Retorna uma lista do tipo Pet

                    var petsFiltrados = listaPets.Where(p => p.Id == id).ToList();

                    if (petsFiltrados.Count > 0)
                    {
                        Console.WriteLine($"Dados do Pet {id}:");
                        foreach (var pet in petsFiltrados)
                        {
                            Console.WriteLine($"ID: {pet.Id} | Nome: {pet.Nome} | Espécie: {pet.Especie} | Raça: {pet.Raca}");
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
        public static void OpcoesServico()
        {
            Console.Clear();

            Console.WriteLine("====== Opções de Serviço ======");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  1. Inserir Serviço           |");
            Console.WriteLine("|  2. Remover Serviço           |");
            Console.WriteLine("|  3. Listar Serviços           |");
            Console.WriteLine("|  4. Listar Por ID             |");
            Console.WriteLine("|  5. Atualizar Serviço         |");
            Console.WriteLine("|  0. Voltar                    |");
            Console.WriteLine("|                               |");
            Console.WriteLine("================================");
            Console.WriteLine(); // Pular linha

            Console.Write("Digite a sua escolha: ");
            int escolha = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (escolha)
            {
                case 0:
                    ShowMenuAdmin();
                    break;
                case 1:
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Descrição: ");
                    string descricao = Console.ReadLine();

                    Console.Write("Preço: ");
                    float preco = float.Parse(Console.ReadLine());

                    Servico novoServico = new Servico(0, nome, descricao, preco);
                    View.InserirEntidade<Servico>(novoServico);
                    break;
                case 2:
                    Console.Write("Digite o Id do Serviço: ");
                    int idRemover = int.Parse(Console.ReadLine());
                    View.RemoverEntidade<Servico>(idRemover);
                    break;
                case 3:
                    var servicos = View.ListarEntidade<Servico>();

                    if (servicos.Any())
                    {
                        Console.WriteLine("Lista de Serviços:");
                        foreach (var servico in servicos)
                        {
                            Console.WriteLine($"ID: {servico.Id} | Nome: {servico.Nome} | Preço: {servico.Preco:C} | Descrição: {servico.Descricao}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum serviço encontrado.");
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesServico();
                    break;
                case 4:
                    Console.Write("Digite o Id do Serviço: ");
                    int idBuscar = int.Parse(Console.ReadLine());
                    var servicoEncontrado = View.ListarEntidade<Servico>().FirstOrDefault(s => s.Id == idBuscar);

                    if (servicoEncontrado != null)
                    {
                        Console.WriteLine($"ID: {servicoEncontrado.Id} | Nome: {servicoEncontrado.Nome} | Preço: {servicoEncontrado.Preco:C} | Descrição: {servicoEncontrado.Descricao}");
                    }
                    else
                    {
                        Console.WriteLine("Serviço não encontrado.");
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    OpcoesServico();
                    break;
                case 5:
                    Console.Write("Id: ");
                    int idAtualizar = int.Parse(Console.ReadLine());

                    Console.Write("Nome: ");
                    string nomeAtualizar = Console.ReadLine();

                    Console.Write("Descrição: ");
                    string descricaoAtualizar = Console.ReadLine();

                    Console.Write("Preço: ");
                    float precoAtualizar = float.Parse(Console.ReadLine());

                    Servico servicoAtualizado = new Servico(idAtualizar, nomeAtualizar, descricaoAtualizar, precoAtualizar);
                    View.AtualizarEntidade<Servico>(servicoAtualizado);
                    break;
                default:
                    Console.WriteLine("Opção Inválida, aperte qualquer tecla para tentar novamente.");
                    Console.ReadLine();
                    OpcoesServico();
                    break;
            }
        }
    }
}