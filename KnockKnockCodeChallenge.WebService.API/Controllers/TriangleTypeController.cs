using KnockKnockCodeChallenge.WebService.API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace KnockKnockCodeChallenge.WebService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriangleTypeController : Controller
    {
        private readonly ITriangleTypeService _service;
        private readonly ILogger<TriangleTypeController> _logger;

        public TriangleTypeController(ITriangleTypeService service, ILogger<TriangleTypeController> logger)
        {
            _service = service;
            _logger = logger;
        }

        // GET: api/TriangleType
        [HttpGet]
        public IActionResult Get(int a, int b, int c)
        {
            try
            {
                var result = _service.GetTriangleType(a, b, c);
                return Ok(result);
            }

            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                var errorModel = new { error = "Error" };
                return BadRequest();

            }

        }


    }
}
