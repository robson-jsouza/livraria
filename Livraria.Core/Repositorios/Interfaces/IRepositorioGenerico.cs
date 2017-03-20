using System.Collections.Generic;
using Livraria.Core.Modelos;

namespace Livraria.Core.Repositorios.Interfaces
{
    public interface IRepositorioGenerico<TModelo, TChave> where TModelo : Entidade<TChave>
    {
        TModelo Obter(TChave id);
        void Adicionar(TModelo modelo, bool novo);
        IEnumerable<TModelo> ObterTodos();
        void Remover(TChave id);
        void Remover(TModelo entidade);
    }
}
