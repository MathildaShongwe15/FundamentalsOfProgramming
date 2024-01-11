using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringController : ControllerBase
    {

        private readonly IReverseStringService _reverseStringService;

        public ReverseStringController(IReverseStringService reverseStringService)
        {
            _reverseStringService = reverseStringService;
        }

        [HttpGet]
        public string GenReverseString(string words)
        {
            return _reverseStringService.ReverseString(words);
        }


    }
}
