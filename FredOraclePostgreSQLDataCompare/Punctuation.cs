/*
The MIT License(MIT)
Copyright(c) 2015-2024 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;

namespace FredOraclePostgreSQLDataCompare
{
  public static class Punctuation
  {
    public const char Comma = ',';
    public const char Colon = ':';
    public const char SemiColon = ';';
    public const char OneSpace = ' ';
    public const char Dash = '-';
    public const char UnderScore = '_';
    public const char SignAt = '@';
    public const char Ampersand = '&';
    public const char SignSharp = '#';
    public const char Period = '.';
    public const char Backslash = '\\';
    public const char Slash = '/';
    public const char OpenParenthesis = '(';
    public const char CloseParenthesis = ')';
    public const char OpenCurlyBrace = '{';
    public const char CloseCurlyBrace = '}';
    public const char OpenSquareBracket = '[';
    public const char CloseSquareBracket = ']';
    public const char LessThan = '<';
    public const char GreaterThan = '>';
    public const char DoubleQuote = '\"';
    public const char SimpleQuote = '\'';
    public const char Tilde = '~';
    public const char Pipe = '|';
    public const char Plus = '+';
    public const char Minus = '-';
    public const char Multiply = '*';
    public const char Divide = '/';
    public const char Dollar = '$';
    public const char Pound = '£';
    public const char Percent = '%';
    public const char QuestionMark = '?';
    public const char ExclamationPoint = '!';
    public const char Chapter = '§';
    public const char Micro = 'µ';
    public static string CrLf = Environment.NewLine;

    public static string Tabulate(ushort numberOfTabulation = 1)
    {
      string result = string.Empty;
      for (int number = 0; number < numberOfTabulation; number++)
      {
        result += " ";
      }

      return result;
    }
  }
}