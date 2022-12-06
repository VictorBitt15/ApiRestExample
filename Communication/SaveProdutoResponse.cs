using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;

namespace ApiRestExample.Communication
{
    public class SaveProdutoResponse : BaseResponse
    {
        public Produto Produto {get; private set;}
        
        private SaveProdutoResponse(bool sucess, string message, Produto produto): base(sucess,message)
        {
            Produto = produto;
        }
        public SaveProdutoResponse(Produto produto): this(true,string.Empty,produto)
        {

        }
        public SaveProdutoResponse(string message): this(false,message,null)
        {}
    }
}