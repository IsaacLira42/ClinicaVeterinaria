using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoPOO.Models
{
    public static class Sessao
    {
        public static Usuario UsuarioLogado { get; private set; }

        public static bool Login(List<Admin> admins, List<Funcionario> funcionarios, string email, string senha)
        {
            Usuario usuario = (Usuario?)admins.FirstOrDefault(u => u.Email == email && u.Senha == senha) ?? funcionarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);


            if (usuario != null)
            {
                UsuarioLogado = usuario;
                return true;
            }
            return false;
        }

        public static int ObterNivelAcesso()
        {
            return UsuarioLogado?.NivelAcesso ?? 0;
        }
    }
}
