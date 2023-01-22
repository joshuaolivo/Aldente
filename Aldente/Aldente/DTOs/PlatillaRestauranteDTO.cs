using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.DTOs
{
    public class PlatillaRestauranteDTO
    {
        public int Id { get; set; }
        public IFormFile Logo { get; set; }
        public string Nombre { get; set; }

    }
}
