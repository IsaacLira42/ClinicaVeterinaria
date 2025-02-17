using System;

namespace ProjetoPOO.Models
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; set; }
        public float Salario { get; set; }

        public Funcionario() { }

        public Funcionario(int id, string nome, string email, string senha, int nivel, string cargo, float salario) 
            : base(id, nome, email, senha, nivel)
        {
            Cargo = cargo;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Nome: {Nome} | Email: {Email} | Cargo: {Cargo} | Salário: {Salario:C}";
        }
    }
}
