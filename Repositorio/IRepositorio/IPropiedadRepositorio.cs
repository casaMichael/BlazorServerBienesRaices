using BlazorServerBienesRaices.Models.DTO;

namespace BlazorServerBienesRaices.Repositorio.IRepositorio
{
    public interface IPropiedadRepositorio
    {
        public Task<IEnumerable<PropiedadDTO>> GetTodasPropiedad();
        public Task<PropiedadDTO> GetPropiedad(int propiedadId);
        public Task<PropiedadDTO> CrearPropiedad(PropiedadDTO propiedadDTO);
        public Task<PropiedadDTO> ActualizarPropiedad(int propiedadId, PropiedadDTO propiedadDTO);
        public Task<PropiedadDTO> NombrePropiedadExiste(string nombreP);
        public Task<int> BorrarPropiedad(int propiedadId);
        //Lista desplegable que trae todas las propiedads
        //public Task<IEnumerable<PropiedadDTO>> GetDropDownPropiedads();


    }
}
