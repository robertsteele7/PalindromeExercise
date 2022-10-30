using PalindromeExercise;
using System;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("civic", true)]
        [InlineData("goodbye", false)]
        [InlineData("Civic", true)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var test = new WordSmith();
            
            //act
            var actual = test.IsAPalindrome(word);
            
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
