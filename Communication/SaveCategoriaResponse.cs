using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;

namespace ApiRestExample.Communication
{
    public class SaveCategoriaResponse: BaseResponse
    {
        public Categoria Categoria {get; private set;}
        private SaveCategoriaResponse(bool sucess, string message, Categoria categoria): base(sucess, message)
        {
            Categoria = categoria;
        }

        public SaveCategoriaResponse(Categoria categoria): this(true,string.Empty,categoria)
        {

        }
        public SaveCategoriaResponse(string message): this(false,message,null)
        {

        }
    }
}