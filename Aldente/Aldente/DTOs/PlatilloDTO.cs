using Aldente.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace Aldente.DTOs
{
    public class PlatilloDTO
    {
        public string Nombre { get; set; }
        public IFormFile Img { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Rest { get; set; }
        public int Cat { get; set; }
        public SubCategoia SubCategoia { get; set; }
    }
}
