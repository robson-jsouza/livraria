using Livraria.Core.Modelos;
using Livraria.Core.Repositorios.Interfaces;
using Livraria.Core.Repositorios.Contexto;
using System.Collections.Generic;

namespace Livraria.Core.Repositorios
{
    public class RepositorioGenerico<TModelo, TChave> : IRepositorioGenerico<TModelo, TChave>
        where TModelo : Entidade<TChave>
    {
        private readonly LivrariaContexto _contexto;

        public RepositorioGenerico(LivrariaContexto contexto)
        {
            _contexto = contexto;
        }

        public TModelo Obter(TChave id)
        {
            return _contexto.Set<TModelo>().Find(id);
        }

        public void Adicionar(TModelo model, bool novo)
        {
            if(novo)
                _contexto.Set<TModelo>().Add(model);
            _contexto.SaveChanges();
        }

        public IEnumerable<TModelo> ObterTodos()
        {
            return _contexto.Set<TModelo>();
        }

        public void Remover(TChave id)
        {
            var modelo = Obter(id);
            Remover(modelo);
        }

        public void Remover(TModelo entity)
        {
            _contexto.Set<TModelo>().Remove(entity);
            _contexto.SaveChanges();
        }
    }
}
