﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodingPractice
{
    public class Kata
    {
        #region previous katas
        public static int ExpressionsMatter(int a, int b, int c)
        {
            int[] results = new int[]
            {
                a + b + c,
                a * b * c,
                a + b * c,
                a * b + c,
                a * (b + c),
                (a + b) * c
            };
            return results.Max();
        }

        public static IEnumerable<int> Between(int start, int end) 
            => Enumerable.Range(start, end - start + 1);

        public static IEnumerable<char> DuplicateEncode(string beginningString)
        {
            throw new NotImplementedException();
        }

        public static string EvenOrOdd(int inputNumber)
        {
            return inputNumber % 2 == 0
                ? "Even"
                : "Odd";
        }

        public static int GetVowelCount(string stringWithVowels) => stringWithVowels.Count("aeiou".Contains);

        public static int CenturyFromYear(int year) => (year - 1) / 100 + 1;

        

        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(x => x);
        }

        public static List<string> Anagrams(string word, List<string> list)
        {
            var pattern = word.OrderBy(c => c);

            return list.Where(str => str.OrderBy(c => c).SequenceEqual(pattern)).ToList();
        }

        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).Count(b => b == '1');
        }

        private static int getBitCount(int n, int currentSum)
        {
            return n == 0 ? currentSum : getBitCount(n / 2, currentSum + n % 2);
        }

        public static bool IsPangram(string str) => String.IsNullOrEmpty(str)
            ? false
            : str.ToLower()
                .Where(Char.IsLetter)
                .Distinct()
                .Count() == 26;

        #endregion

        #region new kata
        public static bool is_valid_IP(string pattern)
        {
            var sections = pattern.Split('.');
            if(sections.Count() != 4)
            {
                return false;
            }

            if (pattern == "0.0.0.0") return true;
            
            foreach(string section in sections)
            {
                int parsedSection;
                bool isInt32 = int.TryParse(section, out parsedSection);

                if (!isInt32)
                {
                    return false;
                }
                else if (parsedSection <= 0 || parsedSection >= 256 || section.Length > 2)
                {
                    return false;
                }
            }

            if(pattern.Contains(" "))
            {
                return false;
            }

            return true;
        }
        #endregion
    }
}