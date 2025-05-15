using System;
using System.Security.Cryptography;
using System.Text;

namespace CultureWaveInterForm.Utils
{
    public class BCryptClass
    {
        /// <summary>
        /// Hashea la contraseña usando SHA-256
        /// </summary>
        /// <param name="plainText">Contraseña en texto plano</param>
        /// <returns>Hash SHA-256 como string hexadecimal</returns>
        public static string EncryptSHA256(string plainText)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));

                    // Convertimos a string hexadecimal
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        builder.Append(b.ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error durante el hashing SHA-256: {ex.Message}");
                return null;
            }
        }
    }
}
