using System.Text.RegularExpressions;

namespace DevToolsHub.Services
{
    public class RegexService
    {

        public  string GenerateBasicRegex(string pattern, bool fullMatch = true)
        {
            if (string.IsNullOrWhiteSpace(pattern))
                return string.Empty;

            // Escape regex special characters
            var escapedPattern = Regex.Escape(pattern);

            if (fullMatch)
                return $"^{escapedPattern}$";
            else
                return escapedPattern;
        }


    }
}
