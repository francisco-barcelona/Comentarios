using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEComentarios.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Creador { get; set; }
        [Required]
        public string Texto { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
