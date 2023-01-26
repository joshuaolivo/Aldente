using Microsoft.AspNetCore.Http;
using Aldente.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Aldente.DTOs
{
    public class PlatillaRestauranteDTO
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public IFormFile Img { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public int Rest { get; set; }
        [Required]
        public int Cat { get; set; }
        [Required]
        public SubCategoia SubCategoia { get; set; }

    }
}
