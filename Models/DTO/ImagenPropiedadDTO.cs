using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerBienesRaices.Models.DTO
{
    public class ImagenPropiedadDTO
    {
        public int IdImagen { get; set; }
        public int PropiedadId { get; set; }
        //Ruta para guardar las imagenes(en local)
        public string UrlImagenPropiedad { get; set; }
    }
}
