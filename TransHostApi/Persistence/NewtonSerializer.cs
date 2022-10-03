using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TransHostApi.Contracts;

namespace TransHostApi.Persistence
{
    public class NewtonSerializer : IJsonSerializer
    {
        public async Task<string> ToJsonString(object item)
        {
            return await Task.Run(() =>JsonConvert.SerializeObject(item));
        }

        public async Task<T> FromJson<T>(string json)
        {
            var result = await Task.Run(() => JsonConvert.DeserializeObject<T>(json));
            if (result == null)
                throw new ArgumentException($"Не удалось распарсить строку {json}");
            return result;
        }
    }
}