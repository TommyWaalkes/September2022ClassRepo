using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExamples;
using Xunit;

namespace Tests
{
    public class OddEvenPrimeTest
    {
        [Theory]
        [InlineData(15, "ODD")]
        [InlineData(10, "EVEN")]
        [InlineData(17, "PRIME")]
        [InlineData(2, "PRIME")]
        public void TestOddEvenPrime(int num, string expected)
        {
            //Arrange
            OddEvenPrime o = new OddEvenPrime();

            //Act 
            string actual = o.GetPrintOut(num);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BatchTest()
        {
            //Arrange 
            OddEvenPrime o = new OddEvenPrime();
            List<int> primes 
                = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
            for(int i = 0; i <=100; i++)
            {
                string actual = o.GetPrintOut(i);

                string expected;

                if (i == 1 || i == 0)
                {
                    expected = "SPECIAL CASE";
                }
                else if (primes.Contains(i))
                {
                    expected = "PRIME";
                }
                else if(i % 2 == 0)
                {
                    expected = "EVEN";
                }
                else
                {
                    expected = "ODD";
                }

                Assert.Equal(expected, actual);
            }
        }
    }
}
