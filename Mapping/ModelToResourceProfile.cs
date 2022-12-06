using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;
using ApiRestExample.Resources;
using AutoMapper;

namespace ApiRestExample.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Categoria,CategoriaResource>();
            CreateMap<Produto,ProdutoResource>();
        }
    }
}