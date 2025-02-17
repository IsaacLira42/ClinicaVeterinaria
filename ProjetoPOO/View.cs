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

        public static void RemoverEntidade<T>(int id) where T : ModeloId
        {
            var persistencia = new PersistenciaGenerica<T>();
            persistencia.Excluir(id);
        }

        public static List<T> ListarEntidade<T>() where T : ModeloId
        {
            var persistencia = new PersistenciaGenerica<T>();
            return persistencia.Listar();  // ira retornar uma lista
        }

        public static T ListarEntidadePorId<T>(int id) where T : ModeloId
        {
            var persistencia = new PersistenciaGenerica<T>();
            return persistencia.ListarPorId(id);
        }

        public static void AtualizarEntidade<T>(T obj) where T : ModeloId
        {
            var persistencia = new PersistenciaGenerica<T>();
            persistencia.Atualizar(obj);
        }

    }
}