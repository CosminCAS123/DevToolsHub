namespace DevToolsHub.Services
{
    using System.Runtime.InteropServices;
    using System.Text.Json;
    public class JsonService
    {
        public (bool success , string result) Format(string input)
        {
            try
            {
                using var json = JsonDocument.Parse(input);
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                var formattedJson = JsonSerializer.Serialize(json.RootElement, options);
                return (true, formattedJson);
            }
            catch(Exception e) 
            {
                return (false, $"Error: {e.Message}");
            }
        }

    }
}
