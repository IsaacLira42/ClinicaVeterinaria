using System;

namespace ProjetoPOO.Models
{
    class Usuario : ModeloId
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public int NivelAcesso { get; private set; }

        public Usuario(int id, string nome, string email, string senha, int nivel)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            NivelAcesso = nivel;
        }
    }
}