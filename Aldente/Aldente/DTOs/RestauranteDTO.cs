using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.DTOs
{
    public class RestauranteDTO : PlatillaRestauranteDTO
    {
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
