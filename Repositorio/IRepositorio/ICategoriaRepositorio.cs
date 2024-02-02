using BlazorServerBienesRaices.Models.DTO;

namespace BlazorServerBienesRaices.Repositorio.IRepositorio
{
    public interface ICategoriaRepositorio
    {
        public Task<IEnumerable<CategoriaDTO>> GetTodasCategorias();
        public Task<CategoriaDTO> GetCategoria(int categoriaId);
        public Task<CategoriaDTO> CrearCategoria(CategoriaDTO categoriaDTO);
        public Task<CategoriaDTO> ActualizarCategoria(int categoriaId, CategoriaDTO categoriaDTO);
        public Task<CategoriaDTO> NombreCategoriaExiste(string nombre);
        public Task<int> BorrarCategoria(int categoriaId);
        //Lista desplegable que trae todas las categorias
        //public Task<IEnumerable<CategoriaDTO>> GetDropDownCategorias();


    }
}
