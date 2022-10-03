using System.Collections.Generic;
using System.Threading.Tasks;

namespace TransHostApi.Contracts
{
    public interface IHttpWorker
    {
        Task<string> GetAsync(string uri);
    }
}