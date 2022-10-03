using System.Threading.Tasks;
using TransHostApi.Model;

namespace TransHostApi.Contracts
{
    public interface ITeleportComService
    {
        Task<Airport> GetAirport(string airport);
    }
}