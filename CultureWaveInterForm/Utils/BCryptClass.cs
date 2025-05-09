using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CultureWaveInterForm.Utils
{
    public class BCryptClass
    {
        /// <summary>
        /// Encripta la contraseña en AES
        /// </summary>
        /// <param name="plainText">Pasamos los contraseña escripta por el usuario</param>
        /// <param name="key">Clave para la encriptación</param>
        /// <returns>Devuelve la contraseña encriptada</returns>
        public static string EncryptAES(string plainText, string key)
        {
            try
            {
                // Asegurarnos de que la clave es de 16 bytes (128 bits)
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);

                // IV fijo de 16 bytes (puedes poner un IV predeterminado, por ejemplo, un array de ceros)
                byte[] ivBytes = new byte[16]; // IV con valores a cero (16 bytes)

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = keyBytes;
                    aesAlg.IV = ivBytes; // Usamos el IV fijo

                    using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                    {
                        using (MemoryStream msEncrypt = new MemoryStream())
                        {
                            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                            {
                                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                                {
                                    swEncrypt.Write(plainText); // Encriptamos el texto
                                }
                            }

                            // Convertir a Base64 para almacenar de manera legible
                            byte[] encrypted = msEncrypt.ToArray();
                            return Convert.ToBase64String(encrypted);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error durante la encriptación: {ex.Message}");
                return null;
            }
        }
    }
}
