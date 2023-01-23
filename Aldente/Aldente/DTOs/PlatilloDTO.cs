using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.DTOs
{
    public class PlatilloDTO
    {
        public string Nombre { get; set; }
        public IFormFile Img{ get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Restaurante { get; set; }
    }
}
