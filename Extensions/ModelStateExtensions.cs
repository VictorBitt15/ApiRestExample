using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ApiRestExample.Extensions
{
    public static class ModelStateExtensions
    {
        public static List<string> GetErrorMessages(this ModelStateDictionary dicionario)
        {
            return dicionario.SelectMany(m=> m.Value.Errors)
                                        .Select(m=>m.ErrorMessage)
                                        .ToList();
        }
    }
}