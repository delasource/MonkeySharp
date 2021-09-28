namespace MonkeySharp
{
    public class MonkeyApiConfig
    {
        public string  ApiUrl         { get; init; }
        public string  Username       { get; init; }
        public string  Password       { get; init; }
        public bool    IsBasicAuth    { get; init; }
        public string? DefaultFirmaId { get; init; }

        public MonkeyApiConfig(string apiUrl, string username, string password)
        {
            ApiUrl   = apiUrl;
            Username = username;
            Password = password;
        }
    }
}
