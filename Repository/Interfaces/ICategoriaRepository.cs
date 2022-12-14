using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;

namespace ApiRestExample.Repository.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> ListAsync();
        Task AddAsync(Categoria categoria);
        Task<Categoria> FindByIdAsync(int id);

        void Update(Categoria categoria);
        void Remove(Categoria categoria);
    }
}