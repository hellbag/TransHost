using AutoMapper;
using TransHostApi.Model;
using TransHostApi.Services;

namespace TransHostApi
{
    public class AutoMapperProfile
    {
        public class AppMappingProfile : Profile
        {
            public AppMappingProfile()
            {			
                CreateMap<TeleportAirportDto, Airport>();
                CreateMap<TeleportLocationDto, Location>();
            }
        }
    }
}