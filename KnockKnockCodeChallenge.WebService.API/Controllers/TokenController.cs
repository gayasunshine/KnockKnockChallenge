using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace KnockKnockCodeChallenge.WebService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : Controller
    {
        private IConfiguration _configuration;
        private readonly ILogger<TokenController> _logger;
        public TokenController(IConfiguration iConfig, ILogger<TokenController> logger)
        {
            _configuration = iConfig;
            _logger = logger;
        }
        // GET: api/Token
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                string token = _configuration.GetSection("MySettings").GetSection("Token").Value;
                return Ok(token);
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
