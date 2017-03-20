using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Livraria.Core.Modelos;
using Livraria.Core.Servicos;
using Livraria.Web.ViewModel;

namespace Livraria.Web.Api
{
    public class LivroController : ApiController
    {
        private readonly LivroServico _livroServico;

        public LivroController()
        {
            _livroServico = new LivroServico();
        }

        [HttpGet]
        public IEnumerable<Livro> ObterTodos()
        {
            return _livroServico.ObterTodos();
        }

        [HttpGet]
        public Livro Obter(Guid id)
        {
            return _livroServico.Obter(id);
        }

        public void Adicionar(LivroViewModel livroViewModel)
        {
            var livro = new Livro();
            if (livroViewModel.Id != Guid.Empty)
                livro = _livroServico.Obter(livroViewModel.Id);

            livro.Titulo = livroViewModel.Titulo;
            livro.NomeAutor = livroViewModel.NomeAutor;
            livro.Assunto = livroViewModel.Assunto;
            livro.Editora = livroViewModel.Editora;
            livro.AnoPublicacao = livroViewModel.AnoPublicacao;
            
            _livroServico.Adicionar(livro);
        }

        public void Remover(Livro livro)
        {
            _livroServico.Remover(livro.Id);
        }
    }
}