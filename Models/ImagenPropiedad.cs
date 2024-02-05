using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerBienesRaices.Models
{
    public class ImagenPropiedad
    {
        [Key]
        public int IdImagen { get; set; }
        public int PropiedadId { get; set; }
        //Ruta para guardar las imagenes(en local)
        public string UrlImagenPropiedad { get; set; }
        //Relacion imagenes a propiedad
        [ForeignKey("PropiedadId")]
        public virtual Propiedad Propiedad { get; set; }
    }
}
