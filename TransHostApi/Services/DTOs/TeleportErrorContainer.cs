namespace TransHostApi.Services
{
    public class TeleportErrorContainer
    {
            public Error[] errors { get; set; }
    }
    
    public class Error
    {
        public string value { get; set; }
        public string msg { get; set; }
        public string param { get; set; }
        public string location { get; set; }
    }
}