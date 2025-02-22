using System;
using System.Text.Json;
using ProjetoPOO.Models;

namespace ProjetoPOO.Generics
{
    public class PersistenciaGenerica<T> where T : ModeloId
    {
        protected List<T> objetos = new List<T>();

        string caminho = Path.Combine("/workspaces/ClinicaVeterinaria/Database", $"{typeof(T).Name}.json");

        public void Inserir(T obj)
        {
            Abrir();
            obj.Id = objetos.Any() ? objetos.Max(o => o.Id) + 1 : 1;
            objetos.Add(obj);
            Salvar();
        }

        public List<T> Listar()
        {
            Abrir();
            return new List<T>(objetos);
        }

        public T ListarPorId(int id)
        {
            Abrir();
            return objetos.FirstOrDefault(o => o.Id == id);
        }

        public void Atualizar(T obj)
        {
            Abrir();
            int index = objetos.FindIndex(o => o.Id == obj.Id);
            if (index != -1)
            {
                objetos[index] = obj;
                Salvar();
            }
        }

        public void Excluir(int id)
        {
            Abrir();
            objetos.RemoveAll(o => o.Id == id);
            Salvar();
        }

        protected void Abrir()
        {
            string? diretorio = Path.GetDirectoryName(caminho);

            // Só cria se o diretório existir
            if (!string.IsNullOrEmpty(diretorio)) { Directory.CreateDirectory(diretorio); }

            if (!File.Exists(caminho)) { File.WriteAllText(caminho, "[]");}

            try
            {
                string json = File.ReadAllText(caminho);
                objetos = JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            }
            catch
            {
                objetos = new List<T>();
            }
        }

        protected void Salvar()
        {
            string json = JsonSerializer.Serialize(objetos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminho, json);
        }
    }
}