using Aldente.Data.Entities;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aldente.DTOs
{
    public class PlatilloDTO
    {
        [Required]
        public string Nombre { get; set; }
        public IFormFile Img { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public int Rest { get; set; }
        public Categoria Categoria { get; set; }
        [Required]
        public int CategoriaInt { get; set; }
        public SubCategoia SubCategoia { get; set; }
        [Required]
        public int SubCategoiaInt { get; set; }
        [Required]
        public string Tamanio { get; set; }
        [Required]
        public double Proporcion { get; set; }
        [Required]
        public string Unidad { get; set; }
        [Required]
        public int Id { get; set; }
    }
}
