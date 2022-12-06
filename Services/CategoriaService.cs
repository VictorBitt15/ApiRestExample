using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;
using ApiRestExample.Repository.Interfaces;
using ApiRestExample.Services.Interfaces;

namespace ApiRestExample.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public async Task<IEnumerable<Categoria>> ListAsync()
        {
           return await _categoriaRepository.ListAsync();
        }
    }
}