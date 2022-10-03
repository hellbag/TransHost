using System.Threading.Tasks;

namespace TransHostApi.Contracts
{
    public interface IAirportService
    {
        Task<double> GetDistance(string airSrc, string airDest);
    }
}