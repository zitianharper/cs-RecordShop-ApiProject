using RecordShop.Models;


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
        public List<Album> ListAllAlbum()
        {
            return _albumModel.FindAllAlbum();
        }
    }
}
