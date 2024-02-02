using AutoMapper;
using BlazorServerBienesRaices.Models;
using BlazorServerBienesRaices.Models.DTO;

namespace BlazorServerBienesRaices.Mapper
{
    public class PerfilMapa : Profile
    {
        public PerfilMapa()
        {   //Se vinculan 
            CreateMap<CategoriaDTO, Categoria>();
            CreateMap<Categoria,CategoriaDTO > ();

        }
    }
}
