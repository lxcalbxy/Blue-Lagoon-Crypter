using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Blue_Lagoon_Crypter__Windowed_.Tools
{
    internal class Encryption
    {
        public static byte[] AesEncryption(byte[] shellcode, byte[] key, byte[] iv)
        {
            try
            {
                using (var aes = Aes.Create())
                {
                    aes.KeySize = 128;
                    aes.BlockSize = 128;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.Mode = CipherMode.CBC;

                    aes.Key = key;
                    aes.IV = iv;

                    using (var encryptor = aes.CreateEncryptor())
                    {
                        using (var msEncShellcode = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(msEncShellcode, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(shellcode, 0, shellcode.Length);
                                cryptoStream.FlushFinalBlock();

                                // Log the encryption result
                                LogEncryptionResult("Encryption", msEncShellcode.ToArray());

                                return msEncShellcode.ToArray();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during encryption: " + ex.Message);
                LogError("Encryption", ex.Message);
                return null;
            }
        }

        public static byte[] AesDecryption(byte[] shellcode, byte[] key, byte[] iv)
        {
            try
            {
                using (var aes = Aes.Create())
                {
                    aes.KeySize = 128;
                    aes.BlockSize = 128;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.Mode = CipherMode.CBC;

                    aes.Key = key;
                    aes.IV = iv;

                    using (var encryptor = aes.CreateDecryptor())
                    {
                        using (var msEncShellcode = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(msEncShellcode, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(shellcode, 0, shellcode.Length);
                                cryptoStream.FlushFinalBlock();

                                // Log the decryption result
                                LogEncryptionResult("Decryption", msEncShellcode.ToArray());

                                return msEncShellcode.ToArray();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during decryption: " + ex.Message);
                LogError("Decryption", ex.Message);
                return null;
            }
        }

        private static void LogEncryptionResult(string operation, byte[] data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("logging_encryption.txt", true))
                {
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    writer.WriteLine(timestamp + " " + operation + " Result:");

                    string hexString = BitConverter.ToString(data).Replace("-", "");
                    writer.WriteLine(hexString);

                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error logging " + operation + " result: " + ex.Message);
            }
        }

        private static void LogError(string operation, string errorMessage)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("logging_encryption.txt", true))
                {
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    writer.WriteLine(timestamp + " Error in : " + operation);

                    writer.WriteLine(errorMessage);

                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error logging " + operation + " error: " + ex.Message);
            }
        }
    }
}
