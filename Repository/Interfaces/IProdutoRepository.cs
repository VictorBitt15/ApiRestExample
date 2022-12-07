using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;

namespace ApiRestExample.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> ListAsync();
        Task AddAsync(Produto produto);
    }
}