using Aldente.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.DTOs.MapperProfile
{
    public class MapperProfile : Profile 
    {
        public MapperProfile()
        {
            CreateMap<Restaurante,RestauranteDTO>();
            CreateMap<RestauranteDTO, Restaurante>();
            CreateMap<PlatillaRestauranteDTO, Restaurante>();
            CreateMap<Restaurante, PlatillaRestauranteDTO>();
            CreateMap<PlatilloDTO, Platillo>();
            CreateMap<Platillo, PlatilloDTO>();
        }
    }
}
