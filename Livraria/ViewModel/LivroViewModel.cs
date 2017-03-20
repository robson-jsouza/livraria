using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.Web.ViewModel
{
    public class LivroViewModel
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string NomeAutor { get; set; }
        public string Assunto { get; set; }
        public string Editora { get; set; }
        public int AnoPublicacao { get; set; }
    }
}