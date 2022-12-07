using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Communication;
using ApiRestExample.Models.Domain;
using ApiRestExample.Repository.Interfaces;
using ApiRestExample.Services.Interfaces;

namespace ApiRestExample.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProdutoService(IProdutoRepository produtoRepository, IUnitOfWork unitOfWork)
        {
            _produtoRepository = produtoRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Produto>> ListAsync()
        {
           return await _produtoRepository.ListAsync();
        }

        public async Task<SaveProdutoResponse> SaveAsync(Produto produto)
        {
            try{
                await _produtoRepository.AddAsync(produto);
                await _unitOfWork.CompleteAsync();

                return new SaveProdutoResponse(produto);


            }catch(Exception ex)
            {
                return new SaveProdutoResponse($"Ocorreu um erro ao adicionar um produto: {ex.Message}");
            }
        }
    }
}