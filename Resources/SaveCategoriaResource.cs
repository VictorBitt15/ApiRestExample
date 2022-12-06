using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestExample.Resources
{
    public class SaveCategoriaResource
    {
        [Required]
        [MaxLength(30)]
        public string Nome { get; set; }
    }
}