using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LockCent.Encryption
{
    /*
     LockCent @2022
     by LynxarA
    */
    static class EFunctions
    {
        public static string Encrypt(this string plainText, byte[] key)
        {
            byte[] iv = { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
            Aes encryptor = Aes.Create();

            // Changed encryptor mode
            encryptor.Mode = CipherMode.CBC;

            // Setted key and IV
            encryptor.Key = key;
            encryptor.IV = iv;

            // Instantiated a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiated a new encryptor from our Aes object
            ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();

            // Instantiated a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

            // Converted the plainText string into a byte array
            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

            // Encrypted the input plaintext string
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);

            // Completed the encryption process
            cryptoStream.FlushFinalBlock();

            // Converted the encrypted data from a MemoryStream to a byte array
            byte[] cipherBytes = memoryStream.ToArray();

            // Closed both the MemoryStream and the CryptoStream
            memoryStream.Close();
            cryptoStream.Close();

            // Converted the encrypted byte array to a base64 encoded string
            string cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);

            // Returned the encrypted data as a string
            return cipherText;
        }

        public static string Decrypt(this string cipherText, byte[] key)
        {
            byte[] iv = { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
            Aes encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;

            // Setted key and IV
            encryptor.Key = key;
            encryptor.IV = iv;

            // Instantiated a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiated a new encryptor from our Aes object
            ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();

            // Instantiated a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

            // Will contain decrypted plaintext
            string plainText = String.Empty;

            try
            {
                // Converted the ciphertext string into a byte array
                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                // Decrypted the input ciphertext string
                cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);

                // Completed the decryption process
                cryptoStream.FlushFinalBlock();

                // Converted the decrypted data from a MemoryStream to a byte array
                byte[] plainBytes = memoryStream.ToArray();

                // Converted the decrypted byte array to string
                plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
            }
            finally
            {
                // Closed both the MemoryStream and the CryptoStream
                memoryStream.Close();
                cryptoStream.Close();
            }

            // Returned the decrypted data as a string
            return plainText;
        }
    }
}
