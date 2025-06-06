using System.Security.Cryptography;
using System.Text;

namespace LunaBlog.Database.BlogsTables
{
    public class BlogUsers : DBBase
    {
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public required string PasswordHashSalt { get; set; }
        public string? Email { get; set; }

        public string? DisplayName { get; set; }

        public string? AvatarUrl { get; set; }

        public string? Signature { get; set; }

        public static string GeneratePasswordHash(string password, string salt)
        {
            StringBuilder stringBuilder = new();
            int j = salt.Length - 1;
            int jIndex = 0;
            for (int i = 0; i < password.Length; i++)
            {
                var c = password[i];
                stringBuilder.Append(c);
                if (jIndex < j && i % 2 == 0) // Add salt character every second character
                {
                    stringBuilder.Append(salt[jIndex]);
                    jIndex++;
                }
            }
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(stringBuilder.ToString()));
            return Convert.ToBase64String(bytes);
        }

        public static string GenerateSalt(int length = 16)
        {
            using var rng = RandomNumberGenerator.Create();
            byte[] saltBytes = new byte[length];
            rng.GetBytes(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }
    }
}
