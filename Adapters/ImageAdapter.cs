using Services.Interfaces;

namespace Adapters
{

 
    public class ImageAdapter:IImageAdapter
    {
         public string GenerateDog()
         {
                return "https://images.dog.ceo/breeds/hound-blood/n02088466_9167.jpg";
         }

    }
}
