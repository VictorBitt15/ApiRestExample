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

        public async Task AddAsync(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
        }

        public async Task<Categoria> FindByIdAsync(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }
        public void Update(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
        }
        public void Remove(Categoria categoria)
        {
            _context.Categorias.Remove(categoria);
        }
    }
}