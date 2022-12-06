using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;

namespace ApiRestExample.Resources
{
    public class SaveProdutoResource
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public EUnitOfMeasurement unidMedida { get; set; }
        public int CategoriaId { get; set; }
    }
}