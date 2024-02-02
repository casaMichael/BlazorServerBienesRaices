using System.ComponentModel.DataAnnotations;

namespace BlazorServerBienesRaices.Models
{
    public class Categoria
    {
        [Key]
        public int IDCategoria { get; set; }
        [Required]
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; }


    }
}
