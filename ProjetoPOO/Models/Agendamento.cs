using System;

namespace ProjetoPOO.Models
{
    class Agendamento : ModeloId
    {
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }
        public int IdPet { get; set; }
        public int IdServico { get; set; }

        public Agendamento(int id, DateTime data, int idCliente, int idpet, int idServico)
        {
            Id = id;
            Data = data;
            IdCliente = idCliente;
            IdPet = idpet;
            IdServico = idServico;
        }
    }
}