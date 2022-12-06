using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;
using ApiRestExample.Repository.Interfaces;
using ApiRestExample.Services.Interfaces;

namespace ApiRestExample.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<IEnumerable<Produto>> ListAsync()
        {
           return await _produtoRepository.ListAsync();
        }
    }
}