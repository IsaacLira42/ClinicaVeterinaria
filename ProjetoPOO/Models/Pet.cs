using System;

namespace ProjetoPOO.Models
{
    class Pet : ModeloId
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public int IdCliente { get; set; }

        public Pet() { }

        public Pet(int id, string nome, string especie, string raca, int idCliente)
        {
            Id = id;
            Nome = nome;
            Especie = especie;
            Raca = raca;
            IdCliente = idCliente;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Nome: {Nome} | Espécie: {Especie} | Raça: {Raca} | ID Cliente: {IdCliente}";
        }
    }
}
