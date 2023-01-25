using Aldente.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.Data.Entities
{
    public class Platillo : ICommonEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Restaurante Restaurante { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public byte[] Imagen { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public double Precio { get; set; }
        public Categoria Categoria { get; set; }
        public SubCategoia SubCategoia { get; set; }
        public Platillo()
        {
            Categoria = new Categoria();
            SubCategoia = new SubCategoia();
            Restaurante = new Restaurante();
        }
    }
}
