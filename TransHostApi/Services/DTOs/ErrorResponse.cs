namespace TransHostApi.Services
{
    /// <summary>
    /// ДТО для отправки ошибки на запрос
    /// </summary>
    public class ErrorResponse : ApiResponse
    {
        public ErrorResponse(string error)
        {
            this.error = error;
            success = false;
        }
    
        public string error { get; set; }
    }
}