using Post.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post.WebApplication.Data
{
    public class PostRepository
    {
        private static List<Posts> posts = new();

        private static int Contador = 1;

        static PostRepository()
        {
        }

        public static List<Posts> SelecionarTodos()
        {
            return posts;
        }

        public static void Adicionar(Posts post)
        {
            post.Id = Contador++;
            posts.Add(post);
        }

        public static Posts SelecionarPorId(int id)
        {
            return posts.FirstOrDefault(x => x.Id == id);
        }

        public static void Editar(int id, Posts post)
        {
            foreach (var item in posts)
            {
                if (item.Id == id)
                {
                    item.Titulo = post.Titulo;
                    item.Conteudo = post.Conteudo;
                    item.DataPublicacao = post.DataPublicacao;
                    break;
                }
            }
        }

        public static void Excluir(int id)
        {
            posts.Remove(SelecionarPorId(id));
        }
    }
}
