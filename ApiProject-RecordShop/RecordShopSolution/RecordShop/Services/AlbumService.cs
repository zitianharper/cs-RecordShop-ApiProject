using RecordShop.Models;
using System.Linq;

namespace RecordShop.Services
{
    public class AlbumService
    {
        private readonly IAlbumRepository _albumModel;

        public AlbumService (IAlbumRepository albumModel)
        {
            _albumModel = albumModel; 
        }


        //GET all albums in stock 
        public List<Album> ListAlbumInStock()
        {
            return _albumModel
                .FindAlbumInStock()
                .Where(a => a.StockQuantity > 0)
                .ToList();
        }
    }
}
