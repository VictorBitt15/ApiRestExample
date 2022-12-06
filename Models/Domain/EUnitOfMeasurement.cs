using System.ComponentModel;

namespace ApiRestExample.Models.Domain
{
    public enum EUnitOfMeasurement : byte
    {
        [Description("UN")]
        Unidade = 1,
        [Description("MG")]
        Miligrama =2,
        [Description("G")]
        Grama =3,
        [Description("KG")]
        Quilograma = 4,
        [Description("L")]
        Litro = 5
    }
}