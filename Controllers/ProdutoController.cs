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
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoController(IProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoResource>> GetAllAsync()
        {
            var produtos = await _produtoService.ListAsync();
            var recursos = _mapper.Map<IEnumerable<Produto>,IEnumerable<ProdutoResource>>(produtos);
            return recursos;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveProdutoResource recurso)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }
            var produto = _mapper.Map<SaveProdutoResource,Produto>(recurso);
            
        }
    }
}