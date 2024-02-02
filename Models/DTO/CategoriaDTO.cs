using System.ComponentModel.DataAnnotations;

namespace BlazorServerBienesRaices.Models.DTO
{
    public class CategoriaDTO
    {
        [Key]
        public int IDCategoria { get; set; }
        [Required(ErrorMessage = "EL nombre es obligatorio")]
        public string NombreCategoria { get; set; }
        [Required(ErrorMessage = "Descripcion obligatoria")]
        public string Descripcion { get; set; }
    }
}
