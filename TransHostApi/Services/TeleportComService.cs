using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using TransHostApi.Contracts;
using TransHostApi.Model;

namespace TransHostApi.Services 
{
    /// <summary>
    /// Сервис для работы с апи  TeleportCom
    /// </summary>
    public class TeleportComService : ITeleportComService
    {
        private readonly ILogger<TeleportComService> _logger;
        private readonly IMapper _mapper;
        private readonly IHttpWorker _worker;
        private readonly IJsonSerializer _json;

        public TeleportComService(ILogger<TeleportComService> logger,IMapper mapper,
            IHttpWorker worker,IJsonSerializer json)
        {
            _logger = logger;
            _mapper = mapper;
            _worker = worker;
            _json = json;
        }
        
        
        public async Task<Airport> GetAirport(string airport)
        {
            var response = await _worker.GetAsync($"https://places-dev.cteleport.com/airports/{airport.ToUpper()}");
            var dto = await _json.FromJson<TeleportAirportDto>(response);
            return _mapper.Map<Airport>(dto);
        }
    }
}