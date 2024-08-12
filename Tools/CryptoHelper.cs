using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Tools
{
  internal class CryptoHelper
  {
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("1234567890123456"); // Clé de 16 octets (128 bits)
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("1234567890123456");  // IV de 16 octets (128 bits)
    //Key : Cette clé doit être de 16 octets pour AES-128, 24 octets pour AES-192, ou 32 octets pour AES-256. Dans cet exemple, j'ai utilisé une clé de 16 octets pour AES-128.

    public static string AesEncrypt(string plainText, string key, string initializeVector)
    {
      if (plainText == null) return "ko-plain text cannot be null";
      if (plainText == string.Empty) return "ko-plain text cannot be empty";
      if (key == null) return "ko-key cannot be null";
      if (key == string.Empty) return "ko-key cannot be empty";
      if (initializeVector == null) return "ko- initial vector cannot be null";
      if (initializeVector == string.Empty) return "ko- initial vector cannot be empty";
      if (key.Length != 16 && key.Length != 24 && key.Length != 32)
      {
        return "ko-key length not 16, 24 or 32 bits";
      }

      byte[] Key = Encoding.UTF8.GetBytes(key);
      byte[] InitializeVector = Encoding.UTF8.GetBytes(initializeVector);
      using (Aes aesAlg = Aes.Create())
      {
        aesAlg.Key = Key;
        aesAlg.IV = InitializeVector;

        ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

        using (MemoryStream msEncrypt = new MemoryStream())
        {
          using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
          {
            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
            {
              swEncrypt.Write(plainText);
            }

            return Convert.ToBase64String(msEncrypt.ToArray());
          }
        }
      }
    }

    public static string AesDecrypt(string cipherText, string key, string initializeVector)
    {
      if (cipherText == null) return "ko-cipher text cannot be null";
      if (cipherText == string.Empty) return "ko-cipher Text cannot be empty";
      if (key == null) return "ko-key cannot be null";
      if (key == string.Empty) return "ko-key cannot be empty";
      if (initializeVector == null) return "ko- initial vector cannot be null";
      if (initializeVector == string.Empty) return "ko- initial vector cannot be empty";
      if (key.Length != 16 && key.Length != 24 && key.Length != 32)
      {
        return "ko-key length not 16, 24 or 32 bits";
      }

      byte[] Key = Encoding.UTF8.GetBytes(key);
      byte[] InitializeVector = Encoding.UTF8.GetBytes(initializeVector);
      using (Aes aesAlg = Aes.Create())
      {
        aesAlg.Key = Key;
        aesAlg.IV = InitializeVector;

        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

        using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
        {
          using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
          {
            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
            {
              return srDecrypt.ReadToEnd();
            }
          }
        }
      }
    }
  }
}
