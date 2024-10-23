using FizzBuzzApp.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;

namespace FizzBuzzApp.Api
{
    public class FizzBuzzFunction
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzFunction(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [Function("GetFizzBuzz")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            string numberStr = req.Query["number"];
            int number = int.Parse(numberStr);
            string result = _fizzBuzzService.GetFizzBuzz(number);
            return new OkObjectResult(result);
        }
    }
}
