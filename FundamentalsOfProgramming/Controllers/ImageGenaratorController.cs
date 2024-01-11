using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImageGenaratorController : ControllerBase
    {

        private readonly IImageService _imageservice;
        public ImageGenaratorController(IImageService imageService) { 
        
             _imageservice = imageService;
        
        }


        [HttpGet]
        public string GenDogImage()
        {
            return _imageservice.GenerateDog();

        }

       
    }
}
