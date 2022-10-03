namespace TransHostApi.Services
{
    /// <summary>
    /// ДТО для отправки успешного ответа
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class OkResponse<T> : ApiResponse
    {
        public T data { get; set; }
    }
}