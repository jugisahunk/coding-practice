using System;
using Xunit;
using CodingPractice;

namespace CodingPracticeTests
{
    public class JadenCaseTests
    {

        [Fact]
        public void Given_simple_allcap_sword_Return_capitalized_word()
        {
            //Assert.Equal("Hello", JadenCase.ToJadenCase("HELLO"));
            Assert.Equal("Hello", "HELLO".ToJadenCase());
        }


        [Fact]
        public void Given_simple_allcap_phrase_Return_capitalized_phrase()
        {
            Assert.Equal("Hello World!", "HELLO WORLD!".ToJadenCase());
        }


        [Fact]
        public void Given_sentence_Return_capitalized_sentence()
        {
            string testPhrase = "the answer to life, the universe, and everything is fourty-two!";
            string expectedOutput = "The Answer To Life, The Universe, And Everything Is Fourty-Two!";            

            Assert.Equal(expectedOutput, testPhrase.ToJadenCase());
        }
    }
}
