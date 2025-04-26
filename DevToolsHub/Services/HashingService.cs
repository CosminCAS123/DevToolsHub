namespace DevToolsHub.Services
{
    using System.Security.Cryptography;
    using System.Text;
    public class HashingService
    {
        public string GenerateSHA1(string input)
        {
            using var sha1 = SHA1.Create();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BytesToHex(hash);
        }

        public string GenerateSHA256(string input)
        {
            using var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BytesToHex(hash);
        }

        public string GenerateSHA384(string input)
        {
            using var sha384 = SHA384.Create();
            var hash = sha384.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BytesToHex(hash);
        }

        public string GenerateSHA512(string input)
        {
            using var sha512 = SHA512.Create();
            var hash = sha512.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BytesToHex(hash);
        }
        private  string BytesToHex(byte[] bytes)
        {
            var sb = new StringBuilder(bytes.Length * 2);
            foreach (var b in bytes)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }


    }
}
