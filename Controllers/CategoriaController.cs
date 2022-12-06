using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Extensions;
using ApiRestExample.Models.Domain;
using ApiRestExample.Resources;
using ApiRestExample.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;
        private readonly IMapper _mapper;

        public CategoriaController(ICategoriaService categoriaService, IMapper mapper)
        {
            _categoriaService = categoriaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoriaResource>> GetAllAsync()
        {
            var categorias = await _categoriaService.ListAsync();
            var recursos = _mapper.Map<IEnumerable<Categoria>,IEnumerable<CategoriaResource>>(categorias);

            return recursos;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoriaResource recurso)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }
            var categoria = _mapper.Map<SaveCategoriaResource,Categoria>(recurso);
            var resultado = await _categoriaService.SaveAsync(categoria);

            if(!resultado.Sucess)
            {
                return BadRequest(resultado.Message);
            }
            var categoriaRecurso = _mapper.Map<Categoria,CategoriaResource>(resultado.Categoria);
            return Ok(categoriaRecurso);
        }
    }
}