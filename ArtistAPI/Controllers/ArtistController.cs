using ArtistServiceReference1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArtistAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {

        private ArtistServiceReference1.ArtistSoapClient service;

        public ArtistController(ArtistSoapClient service)
        {
            this.service = service;
        }


        [HttpGet]
        public string GetArtists()
        {
            return service.GetAll();
        }

        [HttpGet("{name}")]
        public string GetOsobeByDate(string name)
        {
            return service.FindByName(name);
        }

    }
}
