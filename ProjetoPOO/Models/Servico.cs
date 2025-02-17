using System;

namespace ProjetoPOO.Models
{
    public class Servico : ModeloId
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }

        public Servico() { }

        public Servico(int id, string nome, string descricao, float preco)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Nome: {Nome} | Descrição: {Descricao} | Preço: {Preco:C}";
        }
    }
}
