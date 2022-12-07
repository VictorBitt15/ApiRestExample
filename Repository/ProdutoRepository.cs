using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;
using ApiRestExample.Persistence;
using ApiRestExample.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiRestExample.Repository
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IEnumerable<Produto>> ListAsync()
        {
            return await _context.Produtos.Include(p=> p.Categoria).ToListAsync();
        }
        public async Task AddAsync(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
        }
    }
}