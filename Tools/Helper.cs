using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.XPath;

namespace Tools
{
  public static class Helper
  {
    public const int FirstElement = 0;
    public const int SecondElement = 1;
    public const int ThirdElement = 2;
    public const int FourthElement = 3;
    public const int FithElement = 4;

    public const int TwentyFour = 24;

    public const string OK = "ok";
    public const string KO = "ko";
    public const int One = 1;
    public const char SemiColon = ';';

    public static string[] WriteArrayToFile(string[] lines, string filename, bool append = true)
    {
      var result = new[] { "ok", string.Empty };
      try
      {
        using (StreamWriter sw = new StreamWriter(filename, append))
        {
          for (int i = 0; i < lines.Length; i++)
          {
            sw.WriteLine(lines[i]);
          }
        }
      }
      catch (Exception exception)
      {
        result[0] = "ko";
        result[1] = exception.Message;
      }

      return result;
    }

    /// <summary>
    /// Write a single string to a file.
    /// </summary>
    /// <param name="line">The one line to be written.</param>
    /// <param name="filename">the name of the file.</param>
    /// <param name="append">Do we append the line? the default value is true.</param>
    /// <returns>An array of string, the first item is ok or ko and the second item is the error message.</returns>
    public static string[] WriteStringToFile(string filename, string line, bool append = true)
    {
      var result = new[] { "ok", string.Empty };
      try
      {
        using (StreamWriter sw = new StreamWriter(filename, append))
        {
          sw.WriteLine(line);
        }
      }
      catch (Exception exception)
      {
        result[0] = "ko";
        result[1] = exception.Message;
      }

      return result;
    }

    public static string[] WriteToFileAllBytes(byte[] lines, string filename)
    {
      var result = new[] { "ok", string.Empty };
      try
      {
        File.WriteAllBytes(filename, lines);
      }
      catch (Exception exception)
      {
        result[0] = "ko";
        result[1] = exception.Message;
      }

      return result;
    }

    public static string[] WriteToFile(byte[] lines, string filename)
    {
      var result = new[] { "ok", string.Empty };
      try
      {
        using (StreamWriter sw = new StreamWriter(filename))
        {
          foreach (var item in lines)
          {
            sw.WriteLine(item.ToString());
          }
        }
      }
      catch (Exception exception)
      {
        result[0] = "ko";
        result[1] = exception.Message;
      }

      return result;
    }

    public static string[] WriteToFile(string lines, string filename)
    {
      var result = new[] { "ok", string.Empty };
      try
      {
        File.WriteAllText(filename, lines);
      }
      catch (Exception exception)
      {
        result[0] = "ko";
        result[1] = exception.Message;
      }

      return result;
    }

    public static string[] ReadFile(string filename)
    {
      var result = new List<string> { "ok" };
      try
      {
        using (StreamReader sr = new StreamReader(filename))
        {
          var line = string.Empty;
          while ((line = sr.ReadLine()) != null)
          {
            result.Add(line);
          }
        }
      }
      catch (Exception exception)
      {
        result[0] = $"ko - {exception.Message}";
      }

      return result.ToArray();
    }

    public static string ReadFileOneLine(string filename)
    {
      var result = string.Empty;
      try
      {
        using (StreamReader sr = new StreamReader(filename))
        {
          var line = string.Empty;
          while ((line = sr.ReadLine()) != null)
          {
            if (!string.IsNullOrEmpty(line))
            {
              result = line;
            }
          }
        }
      }
      catch (Exception)
      {
        result = string.Empty;
      }

      return result;
    }

    public static string RemoveCharacters(string theString, string characterstoBeRemoved)
    {
      string result = theString;
      foreach (var oneCharactertoBeRemoved in characterstoBeRemoved)
      {
        result = result.Replace(oneCharactertoBeRemoved.ToString(), string.Empty);
      }

      return result;
    }

    

    public static string ToUpperOrLowercase(string message, bool lowercase = true)
    {
      return lowercase ? message.ToLower() : message.ToUpper();
    }

    /// <summary>
    /// Create a file if it doesn't exist.
    /// </summary>
    /// <param name="filename">The name of the file.</param>
    /// <returns>A boolean value stating if the file exists or not.</returns>
    public static bool CreateFileIfNotExist(string filename)
    {
      var result = true;
      try
      {
        if (!File.Exists(filename))
        {
          File.WriteAllText(filename, string.Empty, UTF8Encoding.UTF8);
        }
      }
      catch (Exception)
      {
        result = false;
      }

      return result;
    }

    /// <summary>
    /// Delete a file.
    /// </summary>
    /// <param name="filename">The name of the file to be deleted.</param>
    /// <returns>True if the file was successfully deleted otherwise false.</returns>
    public static bool DeleteFile(string filename)
    {
      var result = true;
      try
      {
        File.Delete(filename);
      }
      catch (Exception)
      {
        result = false;
      }

      return result;
    }
  }
}
