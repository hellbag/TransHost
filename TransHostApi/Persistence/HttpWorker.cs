using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TransHostApi.Contracts;
using TransHostApi.Model.Exceptions;
using TransHostApi.Services;

namespace TransHostApi.Persistence
{
    public class HttpWorker : IHttpWorker
    {
        public async Task<string> GetAsync(string uri)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new ExternalServerException();
            }
            

        }
    }
}