using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livraria.Core.Repositorios.Interfaces;
using Livraria.Core.Modelos;
using Livraria.Core.Repositorios;
using Livraria.Core.Repositorios.Contexto;

namespace Livraria.Core.Servicos
{
    public class LivroServico
    {
        private readonly IRepositorioGenerico<Livro, Guid> _livroRepository;
        private readonly LivrariaContexto _contexto;

        public LivroServico()
        {
            _contexto = new LivrariaContexto();
            _livroRepository = new RepositorioGenerico<Livro, Guid>(_contexto);
        }

        public Livro Obter(Guid id)
        {
            return _livroRepository.Obter(id);
        }

        public void Adicionar(Livro livro)
        {
            bool novo = false;
            if (livro.Id == Guid.Empty)
            {
                livro.Id = Guid.NewGuid();
                novo = true;
            }

            _livroRepository.Adicionar(livro, novo);
        }

        public IEnumerable<Livro> ObterTodos()
        {
            return _livroRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _livroRepository.Remover(id);
        }
    }
}
