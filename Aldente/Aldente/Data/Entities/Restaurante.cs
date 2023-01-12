using Aldente.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.Data.Entities
{
    public class Restaurante : ICommonEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [EmailAddress]
        [Required]
        public string Correo { get; set; }
        [MaxLength(13)]
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Logo { get; set; }

    }
}
