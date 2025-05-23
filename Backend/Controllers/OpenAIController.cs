using Microsoft.AspNetCore.Mvc;
using ResumeAnalyzer.Services;

namespace ResumeAnalyzer.Controllers
{
    [ApiController]
    [Route("api/openai")]
    public class OpenAIController : ControllerBase
    {
        private readonly OpenAIService _openAIService;
        private readonly IConfiguration _configuration;

        public OpenAIController(IConfiguration configuration)
        {
            _configuration = configuration;
            _openAIService = new OpenAIService(_configuration);
        }

        [HttpGet("ask")]
        public async Task<IActionResult> AskAI([FromQuery] string prompt)
        {
            var response = await _openAIService.GetAIResponse(prompt);
            return Ok(new { AIResponse = response });
        }
    }
}
