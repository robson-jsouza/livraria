using System.Data.Entity;
using Livraria.Core.Modelos;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Livraria.Core.Repositorios.Contexto
{
    public class LivrariaContexto : DbContext
    {
        public LivrariaContexto() : base("name=LivrariaConexao") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public IDbSet<Livro> Livros { get; set; }
    }
}
