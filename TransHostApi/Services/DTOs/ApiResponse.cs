namespace TransHostApi.Services
{
    /// <summary>
    /// Базовый класс ответа
    /// </summary>
    public abstract class ApiResponse
    {
        public bool success { get; set; }
    }
}