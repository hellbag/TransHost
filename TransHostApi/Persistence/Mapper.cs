using AutoMapper;
using TransHostApi.Model;
using TransHostApi.Services;

namespace TransHostApi.Persistence
{
    public class Mapper
    {
        private readonly IMapper _mapper;
        public Mapper()
        {
            var config = new Mapper(new AutoMapperProfile());
            _mapper = new 
        }
        Airport Map(AirportDto dto)
        {
            return 
        }
    }
}