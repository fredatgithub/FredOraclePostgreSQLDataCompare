using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Tools
{
  public class Crypto
  {
    private static readonly string CARACTERES_MINUSCULES = "abcdefgijkmnopqrstwxyz";
    private static readonly string CARACTERES_MAJUSCULES = "ABCDEFGHJKLMNPQRSTWXYZ";
    private static readonly string CARACTERES_NUMERIQUES = "23456789";
    private static readonly string CARACTERES_SPECIAUX = "*$-+?_=!%{}#";

    public static string Generate(int length)
    {
      return Generate(length, length);
    }

    public static string Generate(int minLength, int maxLength)
    {
      char[] privateKey = null;
      try
      {
        if (minLength <= 0 || maxLength <= 0 || minLength > maxLength)
        {
          return null;
        }

        char[][] charGroups = new char[][]
            {
                CARACTERES_MINUSCULES.ToCharArray(),
                CARACTERES_MAJUSCULES.ToCharArray(),
                CARACTERES_NUMERIQUES.ToCharArray(),
                CARACTERES_SPECIAUX.ToCharArray()
            };

        int[] charsLeftInGroup = new int[charGroups.Length];

        for (int i = 0; i < charsLeftInGroup.Length; i++)
        {
          charsLeftInGroup[i] = charGroups[i].Length;
        }

        int[] leftGroupsOrder = new int[charGroups.Length];

        for (int i = 0; i < leftGroupsOrder.Length; i++)
        {
          leftGroupsOrder[i] = i;
        }

        byte[] randomBytes = new byte[4];

        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        rng.GetBytes(randomBytes);

        int seed = (randomBytes[0] & 0x7f) << 24 |
                    randomBytes[1] << 16 |
                    randomBytes[2] << 8 |
                    randomBytes[3];

        Random random = new Random(seed);

        if (minLength < maxLength)
        {
          privateKey = new char[random.Next(minLength, maxLength + 1)];
        }
        else
        {
          privateKey = new char[minLength];
        }

        int nextCharIdx;
        int nextGroupIdx;
        int nextLeftGroupsOrderIdx;
        int lastCharIdx;
        int lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;

        for (int i = 0; i < privateKey.Length; i++)
        {
          if (lastLeftGroupsOrderIdx == 0)
          {
            nextLeftGroupsOrderIdx = 0;
          }
          else
          {
            nextLeftGroupsOrderIdx = random.Next(0, lastLeftGroupsOrderIdx);
          }

          nextGroupIdx = leftGroupsOrder[nextLeftGroupsOrderIdx];
          lastCharIdx = charsLeftInGroup[nextGroupIdx] - 1;

          if (lastCharIdx == 0)
          {
            nextCharIdx = 0;
          }
          else
          {
            nextCharIdx = random.Next(0, lastCharIdx + 1);
          }

          privateKey[i] = charGroups[nextGroupIdx][nextCharIdx];
          if (lastCharIdx == 0)
          {
            charsLeftInGroup[nextGroupIdx] = charGroups[nextGroupIdx].Length;
          }
          else
          {
            if (lastCharIdx != nextCharIdx)
            {
              char temp = charGroups[nextGroupIdx][lastCharIdx];
              charGroups[nextGroupIdx][lastCharIdx] = charGroups[nextGroupIdx][nextCharIdx];
              charGroups[nextGroupIdx][nextCharIdx] = temp;
            }

            charsLeftInGroup[nextGroupIdx]--;
          }

          if (lastLeftGroupsOrderIdx == 0)
          {
            lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;
          }
          else
          {
            if (lastLeftGroupsOrderIdx != nextLeftGroupsOrderIdx)
            {
              int temp = leftGroupsOrder[lastLeftGroupsOrderIdx];
              leftGroupsOrder[lastLeftGroupsOrderIdx] = leftGroupsOrder[nextLeftGroupsOrderIdx];
              leftGroupsOrder[nextLeftGroupsOrderIdx] = temp;
            }

            lastLeftGroupsOrderIdx--;
          }
        }

      }
      catch (Exception exception)
      {
        throw new Exception(exception.Message); ;
      }

      return new string(privateKey);
    }

    public static string AesEncrypt(string plainText, string key, string initializeVector)
    {
      if (plainText == null)
      {
        return "ko-plain text cannot be null";
      }

      if (plainText == string.Empty)
      {
        return "ko-plain text cannot be empty";
      }

      if (key == null)
      {
        return "ko-key cannot be null";
      }

      if (key == string.Empty)
      {
        return "ko-key cannot be empty";
      }

      if (initializeVector == null)
      {
        return "ko- initial vector cannot be null";
      }

      if (initializeVector == string.Empty)
      {
        return "ko- initial vector cannot be empty";
      }

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
      if (cipherText == null)
      {
        return "ko-cipher text cannot be null";
      }

      if (cipherText == string.Empty)
      {
        return "ko-cipher Text cannot be empty";
      }

      if (key == null)
      {
        return "ko-key cannot be null";
      }

      if (key == string.Empty)
      {
        return "ko-key cannot be empty";
      }

      if (initializeVector == null)
      {
        return "ko- initial vector cannot be null";
      }

      if (initializeVector == string.Empty)
      {
        return "ko- initial vector cannot be empty";
      }

      //Key : Cette clé doit être de 16 octets pour AES-128, 24 octets pour AES-192, ou 32 octets pour AES-256. Dans cet exemple, j'ai utilisé une clé de 16 octets pour AES-128.
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

    public static string TripleDESEncrypt(string password, string cle)
    {
      byte[] inputArray = Encoding.UTF8.GetBytes(password);
      var tripleDES = new TripleDESCryptoServiceProvider();
      tripleDES.Key = Encoding.UTF8.GetBytes(cle);
      tripleDES.Mode = CipherMode.ECB;
      tripleDES.Padding = PaddingMode.PKCS7;
      ICryptoTransform cTransform = tripleDES.CreateEncryptor();
      byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
      tripleDES.Clear();
      return Convert.ToBase64String(resultArray, 0, resultArray.Length);
    }

    public static string TripleDESDecrypt(string password, string cle)
    {
      byte[] inputArray = Convert.FromBase64String(password);
      var tripleDES = new TripleDESCryptoServiceProvider();
      tripleDES.Key = Encoding.UTF8.GetBytes(cle);
      tripleDES.Mode = CipherMode.ECB;
      tripleDES.Padding = PaddingMode.PKCS7;
      ICryptoTransform cTransform = tripleDES.CreateDecryptor();
      byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
      tripleDES.Clear();
      return Encoding.UTF8.GetString(resultArray);
    }

    public static byte[] EncryptStringToBytesWithAes(string plainText, byte[] key, byte[] salt)
    {
      // Check arguments.
      if (plainText == null || plainText.Length <= 0)
      {
        throw new ArgumentNullException("plainText");
      }

      if (key == null || key.Length <= 0)
      {
        throw new ArgumentNullException("Key");
      }

      if (salt == null || salt.Length <= 0)
      {
        throw new ArgumentNullException("IV = vecteur d'initialisation");
      }

      byte[] encrypted;

      // Create an AesCryptoServiceProvider object
      // with the specified key and IV.
      using (AesCryptoServiceProvider aesAlgo = new AesCryptoServiceProvider())
      {
        aesAlgo.Key = key;
        aesAlgo.IV = salt;

        // Create an encryptor to perform the stream transform.
        ICryptoTransform encryptor = aesAlgo.CreateEncryptor(aesAlgo.Key, aesAlgo.IV);

        // Create the streams used for encryption.
        using (MemoryStream msEncrypt = new MemoryStream())
        {
          using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
          {
            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
            {
              //Write all data to the stream.
              swEncrypt.Write(plainText);
            }

            encrypted = msEncrypt.ToArray();
          }
        }
      }

      // Return the encrypted bytes from the memory stream.
      return encrypted;
    }

    public static string EncryptToStringWithAes(string plainText, byte[] key, byte[] salt)
    {
      var encryptedString = Encoding.UTF8.GetString(EncryptStringToBytesWithAes(plainText, key, salt));
      return encryptedString;
    }

    /// <summary>
    /// Decode an encrypted text to a plain text.
    /// </summary>
    /// <param name="codedText">The encrypted text.</param>
    /// <param name="key">The encryption key.</param>
    /// <param name="salt">The salt.</param>
    /// <returns>A human-readable text.</returns>
    public static string DecodeToStringWithAes(string codedText, string key, string salt)
    {
      var keyToByte = Convert.FromBase64String(key); // Encoding.UTF8.GetBytes(key);
      var saltToByte = Convert.FromBase64String(salt);
      var encryptedText = Convert.FromBase64String(codedText);
      var plainText = DecodeFromBytes_Aes(encryptedText, keyToByte, saltToByte);
      return plainText;
    }

    public static string DecodeFromBytes_Aes(byte[] cipherText, byte[] key, byte[] salt)
    {
      // Check arguments.
      if (cipherText == null || cipherText.Length <= 0)
      {
        throw new ArgumentNullException("cipherText");
      }

      if (key == null || key.Length <= 0)
      {
        throw new ArgumentNullException("Key");
      }

      if (salt == null || salt.Length <= 0)
      {
        throw new ArgumentNullException("IV = vecteur d'initialisation");
      }

      // Declare the string used to hold the decrypted text.
      string plaintext = null;

      // Create an AesCryptoServiceProvider object with the specified key and IV.
      using (AesCryptoServiceProvider aesAlgo = new AesCryptoServiceProvider())
      {
        aesAlgo.Key = key;
        aesAlgo.IV = salt;

        // Create a decryptor to perform the stream transform.
        ICryptoTransform decryptor = aesAlgo.CreateDecryptor(aesAlgo.Key, aesAlgo.IV);

        // Create the streams used for decryption.
        using (MemoryStream msDecrypt = new MemoryStream(cipherText))
        {
          using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
          {
            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
            {

              // Read the decrypted bytes from the decrypting stream and place them in a string.
              plaintext = srDecrypt.ReadToEnd();
            }
          }
        }
      }

      return plaintext;
    }

    public static byte[][] CreateAesCryptoService()
    {
      byte[][] result = new byte[2][];
      using (var aesAlgorithm = new AesCryptoServiceProvider())
      {
        var key = aesAlgorithm.Key;
        var vector = aesAlgorithm.IV;
        result[0] = key;
        result[1] = vector;
      }

      return result;
    }

    public static byte[][] CreateAesKey()
    {
      byte[][] result = new byte[2][];
      using (Aes aesAlgorithm = Aes.Create())
      {
        //Console.WriteLine($"Aes Cipher Mode : {aesAlgorithm.Mode}");
        //Console.WriteLine($"Aes Padding Mode: {aesAlgorithm.Padding}");
        //Console.WriteLine($"Aes Key Size : {aesAlgorithm.KeySize}");
        //Console.WriteLine($"Aes Block Size : {aesAlgorithm.BlockSize}");
        //var keyBase64 = Convert.ToBase64String(aesAlgorithm.Key);
        //var vectorBase64 = Convert.ToBase64String(aesAlgorithm.IV);
        var key = aesAlgorithm.Key;
        var vector = aesAlgorithm.IV;
        result[0] = key;
        result[1] = vector;
      }

      return result;
    }

    public static string DecodeWithAES(string encryptedText, string key, string vector)
    {
      using (Aes aesAlgo = Aes.Create())
      {
        aesAlgo.Key = Encoding.UTF8.GetBytes(key);
        aesAlgo.IV = Encoding.UTF8.GetBytes(vector);

        ICryptoTransform decryptor = aesAlgo.CreateDecryptor(aesAlgo.Key, aesAlgo.IV);

        using (var msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedText)))
        {
          using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
          {
            using (var srDecrypt = new StreamReader(csDecrypt))
            {
              return srDecrypt.ReadToEnd();
            }
          }
        }
      }
    }

    public static string EncryptWithAES(string plainText, string key, string vector)
    {
      using (Aes aesAlgo = Aes.Create())
      {
        aesAlgo.Key = Encoding.UTF8.GetBytes(key);
        aesAlgo.IV = Encoding.UTF8.GetBytes(vector);

        ICryptoTransform encryptor = aesAlgo.CreateEncryptor(aesAlgo.Key, aesAlgo.IV);

        using (var msEncrypt = new MemoryStream())
        {
          using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
          {
            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
              swEncrypt.Write(plainText);
            }
          }

          return Convert.ToBase64String(msEncrypt.ToArray());
        }
      }
    }

    public static string GenerateRandomcharacters(int numberOfcharacters = 32, bool includeSymbols = true, bool includeNumbers = true, bool includeLowerCase = true, bool includeUppercase = true, bool excludeSimilarCharacters = false, bool excludeAmbiguousCharacters = false)
    {
      string result = string.Empty;
      string candidateCharacters = GenerateCharacters(includeSymbols, includeNumbers, includeLowerCase, includeUppercase, excludeSimilarCharacters, excludeAmbiguousCharacters);

      for (int i = 1; i <= numberOfcharacters; i++)
      {
        result += GenerateOneRandomCharacterWithList(candidateCharacters);
      }

      return result;
    }

    public static string GenerateOneRandomCharacterWithList(string candidateCharacters)
    {
      int charNumber = GenerateRandomNumber(0, candidateCharacters.Length - 1);
      string oneCharacter = candidateCharacters[charNumber].ToString();
      return oneCharacter;
    }

    public static string GenerateCharacters(bool includeSymbols = true, bool includeNumbers = true, bool includeLowerCase = true, bool includeUppercase = true, bool excludeSimilarCharacters = true, bool excludeAmbiguousCharacters = true)
    {
      string result = string.Empty;
      if (includeSymbols)
      {
        result += GetAllSymbols();
      }

      if (includeNumbers)
      {
        result += GetAllNumbers();
      }

      if (includeLowerCase)
      {
        result += GetAlphabetLowerCase();
      }

      if (includeUppercase)
      {
        result += GetAlphabetUpperCase();
      }

      if (excludeSimilarCharacters)
      {
        string similarcharacters = GetSimilarCharacters();
        for (int i = 0; i < similarcharacters.Length; i++)
        {
          result = result.Replace(similarcharacters[i].ToString(), string.Empty);
        }
      }

      if (excludeAmbiguousCharacters)
      {
        result = Helper.RemoveCharacters(result, GetAmbiguousCharacters());
      }

      return result;
    }

    public static string GetAlphabetLowerCase()
    {
      return "abcdefghijklmnopqrstuvwxyz";
    }

    public static string GetAlphabetUpperCase()
    {
      return GetAlphabetLowerCase().ToUpper();
    }

    public static string GetAllNumbers()
    {
      return "0123456789";
    }

    public static string GetAllSymbols()
    {
      return "@#$%}[]()/,;:.<>_-";
    }

    public static string GetAmbiguousCharacters()
    {
      return "\\'\"~";
    }

    public static string GetSimilarCharacters()
    {
      return "l1oO0";
    }

    public static string GenerateOneRandomCharacter(bool lowercase = true)
    {
      int charNumber = GenerateRandomNumber(65, 65 + 26);
      string result = ((char)charNumber).ToString();
      result = Helper.ToUpperOrLowercase(result, lowercase);
      return result;
    }

    public static int GenerateRandomNumber(int min, int max)
    {
      if (max > 255 || min < 0)
      {
        return 0;
      }

      if (max == min)
      {
        return min;
      }

      int result;
      var crypto = new RNGCryptoServiceProvider();
      byte[] randomNumber = new byte[1];
      do
      {
        crypto.GetBytes(randomNumber);
        result = randomNumber[0];
      } while (result < min || result > max);

      return result;
    }
  }
}
