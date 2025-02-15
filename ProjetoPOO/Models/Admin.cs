using System;

namespace ProjetoPOO.Models
{
    class Admin : Usuario
    {
        public Admin(string nome, string email, string senha, int nivel) : base(nome, email, senha, nivel)
        {

        }
    }
}