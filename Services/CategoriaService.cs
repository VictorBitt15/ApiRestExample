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
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoriaService(ICategoriaRepository categoriaRepository, IUnitOfWork unitOfWork)
        {
            _categoriaRepository = categoriaRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Categoria>> ListAsync()
        {
           return await _categoriaRepository.ListAsync();
        }

        public async Task<CategoriaResponse> SaveAsync(Categoria categoria)
        {
            try
            {
                await _categoriaRepository.AddAsync(categoria);
                await _unitOfWork.CompleteAsync();

                return new CategoriaResponse(categoria);
            }
            catch (Exception ex)
            {
                return new CategoriaResponse($"Um erro ocorreu ao adicionar uma categoria: {ex.Message}");
            }
        }

        public async Task<CategoriaResponse> UpdateAsync(int id, Categoria categoria)
        {
            var categoriaExistente = await _categoriaRepository.FindByIdAsync(id);

            if(categoriaExistente == null)
            {
                return new CategoriaResponse("Categoria não encontrada!");
            }
            categoriaExistente.Nome = categoria.Nome;
            try
            {
                _categoriaRepository.Update(categoriaExistente);
                await _unitOfWork.CompleteAsync();
                
                return new CategoriaResponse(categoriaExistente);

            }
            catch (Exception ex)
            {
                return new CategoriaResponse($"Um erro ocorreu ao atualizar a categoria: {ex.Message}");
            }
        }

        public async Task<CategoriaResponse> DeleteAsync(int id)
        {
            var categoriaExistente = await _categoriaRepository.FindByIdAsync(id);
            if(categoriaExistente == null)
            {
                return new CategoriaResponse("Categoria não encontrada!");

            }
            try
            {
                _categoriaRepository.Remove(categoriaExistente);
                await _unitOfWork.CompleteAsync();

                return new CategoriaResponse(categoriaExistente);
            }
            catch (Exception ex)
            {
                return new CategoriaResponse($"Ocorreu um erro ao tentar remover a categoria: {ex.Message}");
                
            }
        }
    }
}