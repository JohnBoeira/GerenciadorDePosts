using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post.WebApplication.Models
{
    public class Posts
    {
        public Posts()
        {
            DataPublicacao = DateTime.Now;
        }

        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Conteudo { get; set; }


        public DateTime DataPublicacao { get; set; }

    }
}