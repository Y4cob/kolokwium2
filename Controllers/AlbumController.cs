using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : Controller
    {
        private readonly ILogger<AlbumController> _logger;

        public AlbumController(ILogger<AlbumController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        
         [HttpGet("Album/{id}")]
        public async Task<IActionResult>GetAlbum([FromRoute] int id){
           var wynik = await service.GetAlbumAsync(id); 
           if(wynik == null){
              return NoContext();
           }else{
            Return Ok();
           }
}

        private static async Task<IActionResult> DelMuzyk([FromRoute] int id)
        {
            var wynik = await service.DelMuzykAsync(id);
            if (wynik == "Usunieto")
            {
                Return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
