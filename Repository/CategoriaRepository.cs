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
    public class CategoriaRepository : BaseRepository, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IEnumerable<Categoria>> ListAsync()
        {
           return await _context.Categorias.ToListAsync();
        }
    }
}