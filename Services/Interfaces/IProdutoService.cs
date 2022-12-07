using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Communication;
using ApiRestExample.Models.Domain;

namespace ApiRestExample.Services.Interfaces
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> ListAsync();
        Task<SaveProdutoResponse> SaveAsync(Produto produto);

    }
}