using CodingPractice;
using System.Collections.Generic;
using Xunit;

namespace CodingPracticeTests
{
    public class WhereMyAnagramsTests
    {
        [Theory]
        [InlineData("a", new string[] { "a", "b", "C", "d" }, new string[] { "a" })]
        [InlineData("racer", new string[] { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }, new string[] { "carer", "arcre", "carre" })]
        [InlineData("abc", new string[] { "cba", "bac", "bca", "eeeee" }, new string[] { "cba", "bac", "bca" })]
        [InlineData("abc", new string[] { "efg" }, new string[] { })]
        [InlineData("abc", new string[] { "bbb" }, new string[] { })]
        public void Given_word_Return_all_anagrams_in_list(string word, string[] maybeAnagrams, string[] expectedAnagrams)
        {
            var expectedResult = new List<string> (expectedAnagrams);
            Assert.Equal(expectedResult, Kata.Anagrams(word, new List<string>(maybeAnagrams)));
        }

    }
}
