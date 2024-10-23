using FizzBuzzApp.Domain.Interfaces;
using FizzBuzzApp.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Newtonsoft.Json;

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
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "GET", "POST")] HttpRequest req)
        {
            string numberStr = req.Query["number"];
            if (req.Method == "GET" && numberStr != null)
            {
                int number = int.Parse(numberStr);
                string result = _fizzBuzzService.GetFizzBuzz(number);
                return new OkObjectResult(result);
            }

            if (req.Method == "POST")
            {
                using var streamReader = new StreamReader(req.Body);
                string requestBody = await streamReader.ReadToEndAsync();
                var rangeRequest = JsonConvert.DeserializeObject<FizzBuzzRangeRequest>(requestBody);

                var results = new List<string>();
                for (int i = rangeRequest.Start.Value; i <= rangeRequest.End.Value; i++)
                {
                    results.Add(_fizzBuzzService.GetFizzBuzz(i));
                }
                return new OkObjectResult(results);
            }
            return new BadRequestObjectResult("Error. Invalid input.");
        }
    }
}
