using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TransHostApi.Contracts;
using TransHostApi.DomainServices;
using TransHostApi.Model;
using TransHostApi.Model.Exceptions;

namespace TransHostApi.Services
{
    /// <summary>
    /// Сервис для работы контроллеров.
    /// </summary>
    public class AirportService : IAirportService
    {
        private readonly ILogger<AirportService> _logger;
        private readonly ITeleportComService _teleport;

        public AirportService(ILogger<AirportService> logger,
            ITeleportComService teleport)
        {
            _logger = logger;
            _teleport = teleport;
        }

        public async Task<double> GetDistance(string airSrc, string airDest)
        {
            if (!Airport.IsIataValid(airSrc) || !Airport.IsIataValid(airDest))
                throw new IataValidException();
            
            var src = await _teleport.GetAirport(airSrc);
            var dst = await _teleport.GetAirport(airDest);
            return await Task.Run(() => Coordinates.GetDistance(src.Location, dst.Location));
        }
        
    }
}