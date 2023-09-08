using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Blue_Lagoon_Crypter__Windowed_.Tools
{
    internal class EncryptionConfig
    {
        public static byte[] GetKey(int size)
        {
            byte[] CKey = new byte[size];

            try
            {
                char[] randomChar = "!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~".ToCharArray();

                using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
                {
                    crypto.GetBytes(CKey);
                }

                // Log the generated key
                LogGeneratedKey("Key", CKey);

                return CKey;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error generating key: " + ex.Message);
                LogError("Key", ex.Message);
                return null;
            }
        }

        public static byte[] GetIV(int size)
        {
            byte[] CKey = new byte[size];

            try
            {
                char[] randomChar = "!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~".ToCharArray();

                using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
                {
                    crypto.GetBytes(CKey);
                }

                // Log the generated IV
                LogGeneratedKey("IV", CKey);

                return CKey;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error generating IV: " + ex.Message);
                LogError("IV", ex.Message);
                return null;
            }
        }

        private static void LogGeneratedKey(string type, byte[] key)
        {
            try
            {
                // Create or open the logging_get_keys.txt file in the current working directory
                using (StreamWriter writer = new StreamWriter("logging_Encryption_Config_get_keys.txt", true))
                {
                    // Add a timestamp to the log entry
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    writer.WriteLine(timestamp +  type + " : ");

                    // Add the key as a hex-encoded string
                    string hexString = BitConverter.ToString(key).Replace("-", "");
                    writer.WriteLine(hexString);

                    // Add a new line for separation
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error logging generated " + type + " : " + ex.Message);
            }
        }

        private static void LogError(string type, string errorMessage)
        {
            try
            {
                // Create or open the logging_get_keys.txt file in the current working directory
                using (StreamWriter writer = new StreamWriter("logging_Encryption_Config_get_keys.txt", true))
                {
                    // Add a timestamp to the log entry
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    writer.WriteLine(timestamp + " Error generating " + type + " : ");

                    // Add the error message
                    writer.WriteLine(errorMessage);

                    // Add a new line for separation
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error logging generated " + type + " error: " + ex.Message);
            }
        }
    }
}
