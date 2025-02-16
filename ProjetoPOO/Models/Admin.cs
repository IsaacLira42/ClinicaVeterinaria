using System;

namespace ProjetoPOO.Models
{
    class Admin : Usuario
    {
        public Admin(int id, string nome, string email, string senha, int nivel) : base(id, nome, email, senha, nivel)
        {
            
        }
    }
}