using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDDAndFizzBuzz
{
    public class TestFizzBuzz
    {
        //Fact ot Theory tells VS this method is a unit test
        [Fact]
        public void TestDivisbleBy3()
        {
            //Arrange - setup 
            FizzBuzz fb = new FizzBuzz();
            string expected = "buzz";

            //Act - run your code and grab the result 
            string actual = fb.ReturnFizzBuzz(6);

            //Assert - use a special class to compare actual vs expected and return the result 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDvisibleBy5()
        {
            //Arrange 
            FizzBuzz fb = new FizzBuzz();
            string expected = "fizz";

            //Act 
            string actual = fb.ReturnFizzBuzz(10);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestBoth()
        {
            //Arrange 
            //In unit tests it is best practice to make a fresh object 
            //each test you run, that way it starts with a blank slate 
            //(But that only really matter if you have data in your object)
            FizzBuzz fb = new FizzBuzz();
            string expected = "fizzbuzz";

            //Act 
            string actual = fb.ReturnFizzBuzz(15);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNonDivisible()
        {
            //Arrange 
            FizzBuzz fb = new FizzBuzz();
            string expected = "";

            //Act 
            string actual = fb.ReturnFizzBuzz(8);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, "buzz")]
        [InlineData(10, "fizz")]
        [InlineData(15, "fizzbuzz")]
        [InlineData(7, "")]
        public void TestAll(int input, string expected)
        {

            //Arrange 
            FizzBuzz fb = new FizzBuzz(); 
            
            //Act 
            string actual = fb.ReturnFizzBuzz(input);

            //Assert 
            Assert.Equal(expected, actual);
        }
    }
}
