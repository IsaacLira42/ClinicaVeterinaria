using System;

namespace ProjetoPOO.Models
{
    class Cliente : Usuario
    {
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public Cliente(int id, string nome, string email, string senha, int nivel, string telefone, string endereco) : base(id, nome, email, senha, nivel)
        {
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}