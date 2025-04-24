namespace DevToolsHub.Services
{
    public class UrlService
    {

        public string Encode(string input)
        {
            return Uri.EscapeDataString(input);
        }

        public string Decode(string input)
        {
            return Uri.UnescapeDataString(input);
        }

    }
}
