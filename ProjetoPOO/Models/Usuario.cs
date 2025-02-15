using System;

namespace ProjetoPOO.Models
{
    class Usuario : ModeloId
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        private string Senha { get; set; }
        public int NivelAcesso { get; private set; }

        public Usuario(string nome, string email, string senha, int nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            NivelAcesso = nivel;
        }
    }
}