using System;

namespace ProjetoPOO.Models
{
    public class Admin : Usuario
    {
        public Admin() { }
        public Admin(int id, string nome, string email, string senha, int nivel) : base(id, nome, email, senha, nivel)
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}