using System;
using System.Globalization;

namespace CodingPractice
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string inputString)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(inputString.ToLower());
        }
    }
}
