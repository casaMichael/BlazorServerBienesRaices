using AutoMapper;
using BlazorServerBienesRaices.Data;
using BlazorServerBienesRaices.Models;
using BlazorServerBienesRaices.Models.DTO;
using BlazorServerBienesRaices.Repositorio.IRepositorio;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerBienesRaices.Repositorio
{
    public class ImagenPropiedadRepositorio : IImagenPropiedadRepositorio
    {
        private readonly ApplicationDbContext _bd;
        private readonly IMapper _mapper;

        public ImagenPropiedadRepositorio(ApplicationDbContext bd, IMapper mapper)
        {
            _bd = bd;
            _mapper = mapper;
        }

        public async Task<int> BorrarPropiedadImagenPorIdImagen(int imagenId)
        {//Obtiene el id de imagen y lo borra
            var imagen = await  _bd.ImagenPropiedad.FindAsync(imagenId);
            _bd.ImagenPropiedad.Remove(imagen);
            return await _bd.SaveChangesAsync();
        }

        public async Task<int> BorrarPropiedadImagenPorIdPropiedad(int propiedadId)
        {
            var listaImagenes = await _bd.ImagenPropiedad.Where(x => x.IdImagen == propiedadId).ToListAsync();
            _bd.ImagenPropiedad.RemoveRange(listaImagenes);
            return await _bd.SaveChangesAsync();
        }

        public async Task<int> BorrarPropiedadImagenPorUrlImagen(string imagenUrl)
        {
            var todasImagenes = await _bd.ImagenPropiedad.FirstOrDefaultAsync
                (x => x.UrlImagenPropiedad.ToLower()== imagenUrl.ToLower());
            if (todasImagenes == null)
            {
                return 0;
            }

            _bd.ImagenPropiedad.Remove(todasImagenes);
            return await _bd.SaveChangesAsync();
        }

        public async Task<int> CrearPropiedadImagen(ImagenPropiedadDTO imagenDTO)
        {
            var imagen = _mapper.Map<ImagenPropiedadDTO, ImagenPropiedad>(imagenDTO);
            await _bd.ImagenPropiedad.AddAsync(imagen);
            return await _bd.SaveChangesAsync();
        }

        public async Task<IEnumerable<ImagenPropiedadDTO>> GetImagenesPropiedad(int propiedadId)
        {//Busca las imagenes asocias a la propiedad
            return _mapper.Map<IEnumerable<ImagenPropiedad>, IEnumerable<ImagenPropiedadDTO>>
                (await _bd.ImagenPropiedad.Where(x => x.PropiedadId == propiedadId).ToListAsync());
        }
    }
}
