using System.ComponentModel.DataAnnotations;

namespace Livraria.Core.Modelos
{
    public abstract class Entidade<TChave>
    {
        [Key]
        public TChave Id { get; set; }
    }
}
