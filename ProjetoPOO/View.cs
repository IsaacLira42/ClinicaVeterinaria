using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using ProjetoPOO.Generics;
using ProjetoPOO.Models;

namespace ProjetoPOO
{
    class View
    {

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

        public static string CriptografarAES(string texto)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes("1234567890123456");
                aes.IV = Encoding.UTF8.GetBytes("abcdefghijklmnop");

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(texto);
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }


        public static string DescriptografarAES(string textoCifradoBase64)
        {
            byte[] textoCifrado = Convert.FromBase64String(textoCifradoBase64);
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes("1234567890123456");
                aes.IV = Encoding.UTF8.GetBytes("abcdefghijklmnop");

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream(textoCifrado))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd().Trim(); 
                        }
                    }
                }
            }
    }

    }
}