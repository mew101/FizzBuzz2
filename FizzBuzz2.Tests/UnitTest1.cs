using System;
using Xunit;

namespace FizzBuzz2.Tests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Get_Returns_1_For_1()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(1);

            Assert.Equal("1", result);
        }
        [Fact]
        public void Get_Returns_2_For_2()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(2);

            Assert.Equal("2", result);          
        }
        [Fact]
        public void Get_Returns_3_For_3()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(3);

            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void Get_Returns_6_For_6()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(6);

            Assert.Equal("Fizz", result);



        }
            





    }

}
