using Xunit;
using FizzBuzzApp.Services;
using FizzBuzzApp.Domain.Interfaces;

namespace FizzBuzzApp.Tests
{
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService _fizzBuzzService;

        public FizzBuzzServiceTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Fact]
        public void ReturnsFizz()
        {
            var result = _fizzBuzzService.GetFizzBuzz(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ReturnsBuzz()
        {
            var result = _fizzBuzzService.GetFizzBuzz(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ReturnsFizzBuzz()
        {
            var result = _fizzBuzzService.GetFizzBuzz(15);
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void ReturnsNum()
        {
            var result = _fizzBuzzService.GetFizzBuzz(7);
            Assert.Equal("7", result);
        }
    }
}