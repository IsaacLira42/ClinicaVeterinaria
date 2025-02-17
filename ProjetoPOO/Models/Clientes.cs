using System;

namespace ProjetoPOO.Models
{
    public class Cliente : Usuario
    {
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public Cliente() { }

        public Cliente(int id, string nome, string email, string senha, int nivel, string telefone, string endereco) 
            : base(id, nome, email, senha, nivel)
        {
            Telefone = telefone;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Nome: {Nome} | Email: {Email} | Telefone: {Telefone} | Endereço: {Endereco}";
        }
    }
}
