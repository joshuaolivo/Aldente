using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.DTOs
{
    public class RestauranteDTO
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public IFormFile Img { get; set; }
        [Required]
        [EmailAddress]
        public string Correo { get; set; }
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [MaxLength(13)]
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Direccion { get; set; }
    }
}
