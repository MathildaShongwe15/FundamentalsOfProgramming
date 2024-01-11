using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactorialController : ControllerBase
    {
        private readonly IFactorial _factorial;

        public FactorialController(IFactorial factorial)
        {
            _factorial = factorial;
        }

        [HttpGet]

        public int GenerateFactorial(int num1, int num2)
        {
            return "";
        }

    }
}
