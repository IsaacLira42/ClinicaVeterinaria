using System;
using ProjetoPOO.Models;


namespace ProjetoPOO.Templates
{
    public class Login
    {
        public void ShowTelaLogin()
        {
            List<Admin> admins = View.ListarEntidade<Admin>();
            List<Funcionario> funcionarios =  View.ListarEntidade<Funcionario>();

            Console.WriteLine("=== Sistema de Login ===");
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (Sessao.Login(admins, funcionarios, email, senha))
            {
                Console.WriteLine($"\nBem-vindo, {Sessao.UsuarioLogado.Nome}!");

                if (Sessao.ObterNivelAcesso() == 3)
                {
                    MenuAdmin.ShowMenuAdmin();
                }
                else if (Sessao.ObterNivelAcesso() == 2)
                {
                    MenuFuncionario.ShowMenuFuncionarios();
                }
            }
            else
            {
                Console.WriteLine("\nEmail ou senha incorretos.");
            }
        }
    }
}