using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Communication;
using ApiRestExample.Models.Domain;

namespace ApiRestExample.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> ListAsync();
        Task<CategoriaResponse> SaveAsync(Categoria categoria);
        
        Task<CategoriaResponse> UpdateAsync(int id, Categoria categoria);
        Task<CategoriaResponse> DeleteAsync(int id);
    }
}