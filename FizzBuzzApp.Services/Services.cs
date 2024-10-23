using FizzBuzzApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string GetFizzBuzz(int number)
        {
            if (number % 15 == 0) return "FizzBuzz";
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();
        }
    }
}
