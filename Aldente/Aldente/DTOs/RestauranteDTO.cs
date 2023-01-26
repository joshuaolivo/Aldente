using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.DTOs
{
    public class RestauranteDTO : PlatillaRestauranteDTO
    {
        [Required]
        [EmailAddress]
        public string Correo { get; set; }
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [StringLength(13, ErrorMessage = "El número es demasiado largo")]
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
