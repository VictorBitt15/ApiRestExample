using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;

namespace ApiRestExample.Resources
{
    public class ProdutoResource
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; } 
        public string UnidMedida { get; set; }
        public CategoriaResource Categoria { get; set; }
    }
}