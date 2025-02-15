using System;


namespace ProjetoPOO.Templates
{
    class Login
    {
        public static void ShowTelaLogin()
        {
            Console.WriteLine("===== TELA DE LOGIN =====");
            Console.WriteLine(); // Pular linha

            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();
            
            Console.WriteLine(); // Pular linha

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            /// Validar o usuario
            View.ValidarUsuario(usuario, senha);
        }
    }
}