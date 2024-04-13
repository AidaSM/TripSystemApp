using System;
using System.Security.Cryptography;
using System.Text;

namespace TripSystemApp.Helpers
{
    public static class EncryptionHelper
    {
        public static string EncryptString(string plainText, string key)
        {
            // Implement encryption algorithm (e.g., AES, RSA) using the provided key
            // Return encrypted string
            throw new NotImplementedException();
        }

        public static string DecryptString(string encryptedText, string key)
        {
            // Implement decryption algorithm (e.g., AES, RSA) using the provided key
            // Return decrypted string
            throw new NotImplementedException();
        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            var hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
        }
    }
}
