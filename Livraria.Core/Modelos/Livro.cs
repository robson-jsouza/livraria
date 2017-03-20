using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Core.Modelos
{
    public class Livro : Entidade<Guid>
    {
        [Required]
        [MaxLength(100)]
        public string Titulo { get; set; }
        [Required]
        [MaxLength(100)]
        public string NomeAutor { get; set; }
        [Required]
        [MaxLength(150)]
        public string Assunto { get; set; }
        public string Editora { get; set; }
        public int? AnoPublicacao { get; set; }
    }
}
