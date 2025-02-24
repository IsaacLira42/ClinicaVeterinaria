using System;

namespace ProjetoPOO.Models
{
    class Agendamento : ModeloId
    {
        public string Data { get; set; }
        public int IdCliente { get; set; }
        public int IdPet { get; set; }
        public int IdServico { get; set; }
        public int IdFuncionario { get; set; }

        public Agendamento()
        {
            
        }
        public Agendamento(int id, string data, int idCliente, int idpet, int idServico, int idFuncionario)
        {
            Id = id;
            Data = data;
            IdCliente = idCliente;
            IdPet = idpet;
            IdServico = idServico;
            IdFuncionario = idFuncionario;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Data: {Data:dd/MM/yyyy HH:mm} | Cliente: {IdCliente} | Pet: {IdPet} | Serviço: {IdServico} | Funcionario: {IdFuncionario}";
        }

    }
}