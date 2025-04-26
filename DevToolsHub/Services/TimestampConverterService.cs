namespace DevToolsHub.Services
{
    public class TimestampConverterService
    {
        public (bool Success, string UtcTime, string LocalTime) ConvertTimestampToDate(string input)
        {
            if (!long.TryParse(input, out var timestamp))
            {
                return (false, string.Empty, string.Empty);
            }

            try
            {
                var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(timestamp);
                var utcTime = dateTimeOffset.UtcDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                var localTime = dateTimeOffset.LocalDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                return (true, utcTime, localTime);
            }
            catch
            {
                return (false, string.Empty, string.Empty);
            }
        }

        public string ConvertDateToTimestamp(DateTime dateTime)
        {
            var timestamp = new DateTimeOffset(dateTime).ToUnixTimeSeconds();
            return timestamp.ToString();
        }
    }
}
