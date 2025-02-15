using System;
using ProjetoPOO.Generics;
using ProjetoPOO.Models;

namespace ProjetoPOO
{
    class View
    {
        public static int ValidarUsuario(string usuario, string senha)
        {
            return 0;
        }

        public static void InserirEntidade<T>(T obj) where T : ModeloId
        {
            var persistencia = new PersistenciaGenerica<T>();
            persistencia.Inserir(obj);
        }

        public static void RemoverEntidade<T>(T obj) where T : ModeloId
        {
            
        }
    }
}