using AutoMapper;
using BlazorServerBienesRaices.Data;
using BlazorServerBienesRaices.Models;
using BlazorServerBienesRaices.Models.DTO;
using BlazorServerBienesRaices.Repositorio.IRepositorio;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlazorServerBienesRaices.Repositorio
{
    public class PropiedadRepositorio : IPropiedadRepositorio
    {
        private readonly ApplicationDbContext _bd;
        private readonly IMapper _mapper;

        public PropiedadRepositorio(ApplicationDbContext bd, IMapper mapper)
        {
            _bd = bd;
            _mapper = mapper;
        }


        public async Task<PropiedadDTO> ActualizarPropiedad(int propiedadId, PropiedadDTO propiedadDTO)
        {
            try
            {
                if (propiedadId == propiedadDTO.IdPropiedad)
                {//Valido para actualizar
                    Propiedad propiedad = await _bd.Propiedad.FindAsync(propiedadId);
                    Propiedad propie = _mapper.Map<PropiedadDTO, Propiedad>(propiedadDTO, propiedad);
                    propie.FechaActualizacion = DateTime.Now;
                    var propiedadActualizada = _bd.Propiedad.Update(propie);
                    await _bd.SaveChangesAsync();
                    return _mapper.Map<Propiedad, PropiedadDTO>(propiedadActualizada.Entity);
                }
                else
                {//Invalido
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> BorrarPropiedad(int propiedadId)
        {
            var propiedad = await _bd.Propiedad.FindAsync(propiedadId);
            //Si se encuentra una propiedad
            if (propiedad != null)
            {
                _bd.Propiedad.Remove(propiedad);
                return await _bd.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<PropiedadDTO> CrearPropiedad(PropiedadDTO propiedadDTO)
        {
            Propiedad propiedad = _mapper.Map<PropiedadDTO, Propiedad>(propiedadDTO);
            propiedad.FechaCreacion = DateTime.Now;
            var propiedadAgregada = await _bd.Propiedad.AddAsync(propiedad);
            await _bd.SaveChangesAsync();
            return _mapper.Map<Propiedad, PropiedadDTO>(propiedadAgregada.Entity);
        }

        public async Task<PropiedadDTO> GetPropiedad(int propiedadId)
        {
            try
            {
                PropiedadDTO propiedadDTO =
                    _mapper.Map<Propiedad, PropiedadDTO>
                    (await _bd.Propiedad.FirstOrDefaultAsync
                    (c => c.IdPropiedad == propiedadId));
                return (propiedadDTO);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<PropiedadDTO>> GetTodasPropiedad()
        {
            try
            {
                IEnumerable<PropiedadDTO> propiedadsDTO =
                    _mapper.Map<IEnumerable<Propiedad>, IEnumerable<PropiedadDTO>>(_bd.Propiedad);
                return (propiedadsDTO);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<PropiedadDTO> NombrePropiedadExiste(string nombreP)
        {
            try
            {
                PropiedadDTO propiedadDTO =
                    _mapper.Map<Propiedad, PropiedadDTO>
                (await _bd.Propiedad.FirstOrDefaultAsync
                    (c => c.NombreP.ToLower() == nombreP.ToLower()));
                return (propiedadDTO);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
