using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestExample.Models.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public EUnitOfMeasurement unidMedida{get;set;}
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria {get;set;}
        
    }
}