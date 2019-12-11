using KnockKnockCodeChallenge.WebService.API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace KnockKnockCodeChallenge.WebService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseWordsController : Controller
    {
        private readonly IReverseWordsService _service;
        private readonly ILogger<ReverseWordsController> _logger;
        public ReverseWordsController(IReverseWordsService service, ILogger<ReverseWordsController> logger)
        {

            _service = service;
            _logger = logger;
        }

        // GET: api/ReverseWords
        [HttpGet]
        public IActionResult Get(string sentence)
        {
            try
            {

                var result = _service.GetReverseWord(sentence);
                return Ok(result);

            }

            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                var errorModel = new { error = "Something went wrong while Processing." };
                //return new JsonErrorResult(errorModel);

                return BadRequest();

            }
        }

    }
}
