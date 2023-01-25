using Aldente.Data.Entities;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Aldente.DTOs
{
    public class PlatilloDTO
    {
        public string Nombre { get; set; }
        public IFormFile Img { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Rest { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaInt { get; set; }
        public SubCategoia SubCategoia { get; set; }
        public int SubCategoiaInt { get; set; }
        public string Tamanio { get; set; }
        public double Proporcion { get; set; }
        public string Unidad { get; set; }
    }
}
