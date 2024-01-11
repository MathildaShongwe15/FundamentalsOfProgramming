using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactorialController : ControllerBase
    {
        private readonly IFactorialService _factorialService;

        public FactorialController(IFactorialService factorialService)
        {
            _factorialService = factorialService;
        }

        [HttpGet]
        public int FactorialNum(int num1)
        {
            return _factorialService.GetFactorial(num1);

        }
    }
}
