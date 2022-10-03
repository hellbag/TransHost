using System.Threading.Tasks;

namespace TransHostApi.Contracts
{
    public interface IJsonSerializer
    {
        Task<string> ToJsonString(object item);
        Task<T> FromJson<T>(string json);
    }
}