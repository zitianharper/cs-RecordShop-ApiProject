using Microsoft.AspNetCore.Mvc;
using RecordShop.Services;
using RecordShop.Models;

namespace RecordShop.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    
    public class AlbumController : ControllerBase
    {
        private readonly AlbumService _albumService;

        public AlbumController(AlbumService albumService)
        {
            _albumService = albumService;
        }

        //GET all albums in stock 

        [HttpGet]
        public ActionResult <List<Album>> GetAllAlbum()
        {
            return Ok(_albumService.ListAllAlbum());
        }
    }
}
