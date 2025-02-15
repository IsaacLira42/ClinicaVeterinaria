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

            switch (escolha)
            {
                case 1: 
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Senha: ");
                    string senha = Console.ReadLine();

                    Console.Write("Nivel: ");
                    int nivel = int.Parse(Console.ReadLine());


                    Admin obj = new Admin(nome, email, senha, 1);
                    View.InserirEntidade<Admin>(obj); 
                    break;
                //case 2: ; break;

                default: 
                    Console.WriteLine("Opção Inválida, aperte qualquer teclha para tentar novamente.");
                    Console.ReadLine();
                    OpcoesAdmin();
                    break;
            }
        }


    }
}