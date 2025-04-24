namespace DevToolsHub.Services
{
    using Pages;
    public class Base64Service
    {
        public string Result(int mode , string _input)
        {
            return mode == 0 ? Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(_input)) :
            System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(_input));
        }

    }
}
