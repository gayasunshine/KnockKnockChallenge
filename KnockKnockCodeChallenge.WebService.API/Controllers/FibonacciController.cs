using KnockKnockCodeChallenge.WebService.API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace KnockKnockCodeChallenge.WebService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : Controller
    {
        private readonly IFibonacciNumberService _service;
        private readonly ILogger<FibonacciController> _logger;
    public FibonacciController(IFibonacciNumberService service, ILogger<FibonacciController> logger)
    {
        _service = service;
        _logger = logger;
    }

        // GET: api/Fibonacci
        [HttpGet]
        public IActionResult Get(long n)
        {
            try
            {
                _logger.LogInformation(n.ToString());
                var result = _service.GetFibonacciNumber(n);
                return Ok(result);

            }

            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                return BadRequest();
            }


        }


    }
}
