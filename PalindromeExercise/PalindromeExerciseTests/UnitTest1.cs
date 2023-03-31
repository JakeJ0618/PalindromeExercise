using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("palindrome", false)]
        [InlineData("racecar", true)]
        [InlineData("hello",  false)]
        [InlineData("kayak", true)]
        [InlineData("Jake", false)]
        [InlineData("madam", true)]
        [InlineData("tacocat", true)]
        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            WordSmith tester = new WordSmith();

            //Act
            var actual = tester.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
