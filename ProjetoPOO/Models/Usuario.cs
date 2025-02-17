using System;

namespace ProjetoPOO.Models
{
    public class Usuario : ModeloId
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int NivelAcesso { get; set; }


        public Usuario() {}
        public Usuario(int id, string nome, string email, string senha, int nivel)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            NivelAcesso = nivel;
        }

        public override string ToString()
        {
            return $"Id: {Id} | Nome: {Nome} | Email: {Email}";
        }
    }
}