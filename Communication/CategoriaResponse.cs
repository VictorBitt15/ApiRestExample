using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;

namespace ApiRestExample.Communication
{
    public class CategoriaResponse: BaseResponse
    {
        public Categoria Categoria {get; private set;}
        private CategoriaResponse(bool sucess, string message, Categoria categoria): base(sucess, message)
        {
            Categoria = categoria;
        }

        public CategoriaResponse(Categoria categoria): this(true,string.Empty,categoria)
        {

        }
        public CategoriaResponse(string message): this(false,message,null)
        {

        }
    }
}