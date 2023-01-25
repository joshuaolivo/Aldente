using Microsoft.AspNetCore.Http;
using Aldente.Data.Entities;

namespace Aldente.DTOs
{
    public class PlatillaRestauranteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public IFormFile Img { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Rest { get; set; }
        public int Cat { get; set; }
        public SubCategoia SubCategoia { get; set; }

    }
}
