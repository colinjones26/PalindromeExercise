using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("madam", true)]
        [InlineData("apple",  false)]
        [InlineData("a", true)]
        [InlineData("", false)]

        public void TestIsAPalindrome(string input, bool expected)
        {
            //Arrange
            WordSmith wordSmith = new WordSmith();

            //Act
            bool actual = wordSmith.IsAPalindrome(input);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
