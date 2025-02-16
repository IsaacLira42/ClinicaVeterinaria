using System;

namespace ProjetoPOO.Models
{
    class Servico : ModeloId
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }

        public Servico(int id, string nome, string descricao, float preco)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }
    }
}