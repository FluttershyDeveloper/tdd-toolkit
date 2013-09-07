﻿using System.Linq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Kernel;
using TddEbook.TddToolkit.ImplementationDetails;

namespace TddEbook.TddToolkit
{
  public static partial class Any
  {
    public static string String()
    {
      return _generator.Create<string>();
    }

    public static string StringMatching(string pattern)
    {
      var request = new RegularExpressionRequest(pattern);

      var result = _regexGenerator.Create(request, new DummyContext());
      return result.ToString();
    }

    public static string StringOfLength(int charactersCount)
    {
      var result = System.String.Empty;
      while (result.Count() < charactersCount)
      {
        result += String();
      }
      return result.Substring(0, charactersCount);
    }

    public static string StringOtherThan(params string[] alreadyUsedStrings)
    {
      return ValueOtherThan(alreadyUsedStrings);
    }

    public static string StringNotContaining(params string[] excludedSubstrings)
    {
      var result = String();
      do
      {
        result = String();
      } while (excludedSubstrings.Any(result.Contains));
      return result;
    }

    public static string StringContaining(string str)
    {
      return String() + str + String();
    }

    public static string AlphaString()
    {
      return AlphaString(String().Length);
    }

    public static string AlphaString(int maxLength)
    {
      var result = System.String.Empty;
      for (var i = 0; i < maxLength; ++i)
      {
        result += AlphaChar();
      }
      return result;
    }

    public static string Identifier()
    {
      string result = AlphaChar().ToString();
      for (var i = 0; i < 5; ++i)
      {
        result += DigitChar();
        result += AlphaChar();
      }
      return result;
    }

    public static char AlphaChar()
    {
      return _letters.Next();
    }

    static char DigitChar()
    {
      return _digits.Next();
    }

  }
}
