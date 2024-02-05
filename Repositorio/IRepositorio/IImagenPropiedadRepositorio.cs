using BlazorServerBienesRaices.Models.DTO;

namespace BlazorServerBienesRaices.Repositorio.IRepositorio
{
    public interface IImagenPropiedadRepositorio
    {
        public Task<int> CrearPropiedadImagen(ImagenPropiedadDTO imagenDTO);

        public Task<int> BorrarPropiedadImagenPorIdImagen(int imagenId);
        public Task<int> BorrarPropiedadImagenPorIdPropiedad(int propiedadId);
        public Task<int> BorrarPropiedadImagenPorUrlImagen(string imagenUrl);
        //Lista todas las imagenes
        public Task<IEnumerable<ImagenPropiedadDTO>> GetImagenesPropiedad(int propiedadId);
    }
}
