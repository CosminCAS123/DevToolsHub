namespace DevToolsHub.Services
{
    public class UuidService
    {
        public string Generate()
        {
            return Guid.NewGuid().ToString();
        }

    }
}
