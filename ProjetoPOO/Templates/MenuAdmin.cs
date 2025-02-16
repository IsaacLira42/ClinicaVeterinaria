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
                case 3: View.ListarEntidade<Admin>(); break;
                case 4: 
                    Console.Write("Digite o Id do admin: ");
                    int id_2 = int.Parse(Console.ReadLine());
                    View.ListarEntidadePorId<Admin>(id_2);
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
                case 3: View.ListarEntidade<Cliente>(); break;
                case 4: 
                    Console.Write("Digite o Id do Cliente: ");
                    int id_2 = int.Parse(Console.ReadLine());
                    View.ListarEntidadePorId<Cliente>(id_2);
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


    }
}