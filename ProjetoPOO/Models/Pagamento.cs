using System;

namespace ProjetoPOO.Models
{
    class Pagamento : ModeloId
    {
        public float Valor { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }

        public Pagamento() { }

        public Pagamento(int id, float valor, DateTime dataPagamento, int idFuncionario, int idCliente)
        {
            Id = id;
            Valor = valor;
            DataPagamento = dataPagamento;
            IdFuncionario = idFuncionario;
            IdCliente = idCliente;          
        }

        public override string ToString()
        {
            return $"ID: {Id} | Valor: {Valor:C} | Data: {DataPagamento:dd/MM/yyyy HH:mm} | Funcionário: {IdFuncionario} | Cliente: {IdCliente}";
        }
    }
}
