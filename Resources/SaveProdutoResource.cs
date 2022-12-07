using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;

namespace ApiRestExample.Resources
{
    public class SaveProdutoResource
    {
        [Required]
        [MaxLength(20)]
        public string Nome { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public EUnitOfMeasurement unidMedida { get; set; }
        [Required]
        public int CategoriaId { get; set; }
    }
}