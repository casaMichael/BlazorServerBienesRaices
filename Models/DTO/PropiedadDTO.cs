using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerBienesRaices.Models.DTO
{
    public class PropiedadDTO
    {
        [Key]
        public int IdPropiedad { get; set; }
        [Required(ErrorMessage = "EL nombre es obligatorio")]
        [StringLength(30, MinimumLength =5,ErrorMessage = "EL nombre debe tener entre 5 y 30 caracteres")]
        public string NombreP { get; set; }
        [Required(ErrorMessage = "Descripcion obligatoria")]
        [StringLength(300, MinimumLength = 20, ErrorMessage = "La descripcion debe tener entre 20 y 300 caracteres")]
        public string DescripcionP { get; set; }
        [Required(ErrorMessage = "AREA es obligatorio")]
        [Range(1,5000,ErrorMessage ="Debes ingresar un número valido")]
        public int Area { get; set; }
        [Required(ErrorMessage = "Habitaciones obligatorio")]
        [Range(1, 10, ErrorMessage = "Debes ingresar un número valido")]
        public int Habitaciones { get; set; }
        [Required(ErrorMessage = "Numero de BAÑOS obligatorio")]
        [Range(1, 5, ErrorMessage = "Debes ingresar un número valido")]
        public int Banios { get; set; }
        [Required(ErrorMessage = "CAntidad Parking obligatorio")]
        [Range(1, 5000, ErrorMessage = "Debes ingresar un número valido")]
        public int Parking { get; set; }
        [Required(ErrorMessage = "Parking obligatorio")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "Activo/inactivo obligatorio")]
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; }

        ////Relacion con modelo/tabla categoria
        public int CategoriaIDCategoria { get; set; }
    }
}
