using Aldente.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.Data.Entities
{
    public class SubCategoia : ICommonEntity
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Categoria> Id_Categoria { get; set; }
        public string Nombre { get; set; }
    }
}
