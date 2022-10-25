using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExamples;
using Xunit;

namespace Tests
{
    public class TestConverter
    {
        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "one")]
        [InlineData(2, "two")]
        [InlineData(3, "three")]
        [InlineData(4, "four")]
        [InlineData(5, "five")]
        [InlineData(6, "six")]
        [InlineData(7, "seven")]
        [InlineData(8, "eight")]
        [InlineData(9, "nine")]
        [InlineData(10, "ten")]
        [InlineData(11, "eleven")]
        [InlineData(12, "tweleve")]
        [InlineData(13, "thirteen")]
        [InlineData(14, "forteen")]
        [InlineData(15, "fifteen")]
        [InlineData(16, "sixteen")]
        [InlineData(17, "seventeen")]
        [InlineData(18, "eighteen")]
        [InlineData(19, "nineteen")]
        [InlineData(20, "twenty")]
        [InlineData(21, "twenty one")]

        public void TestValues(int input, string expected)
        {
            //Arrange 
            NumsConverter nc = new NumsConverter();

            //Act 
            string actual = nc.Convert(input);

            //Assert 
            Assert.Equal(expected, actual);
        }
    }
}
